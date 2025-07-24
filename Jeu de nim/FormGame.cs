using Jeu_de_nim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace Jeu_de_nim
{



    public partial class FormGame : Form
    {

        private Joueur joueurConnecte;
        private Partie partie;
        private int batonRestant;
        private int tour; // 1 ou 2
        private Timer timerTour;
        private Timer timerPartie;
        private int secondesRestantesTour = 15;
        private int secondesRestantesPartie = 90;
        private Timer timerAttenteJoueur2;
        private Timer timerSync;
        private int joueurTourId; // identifie le joueur dont c’est le tour





        public FormGame(Joueur joueur, Partie p)
        {

            InitializeComponent();
            joueurConnecte = joueur;
            partie = p;




            if (partie.IdJoueur2 == null)
            {
                MessageBox.Show("La partie ne peut commencer qu'avec deux joueurs !");
                this.Close();
                return;
            }

            batonRestant = partie.BatonsRestants;
            joueurTourId = partie.IdJoueurTour ?? partie.IdJoueur1;
            



            if (partie.IdJoueur2 == null)
            {
                MessageBox.Show("En attente d’un second joueur…");

                timerAttenteJoueur2 = new Timer();
                timerAttenteJoueur2.Interval = 2000; // toutes les 2 secondes
                timerAttenteJoueur2.Tick += VerifierSiJoueur2Rejoint;
                timerAttenteJoueur2.Start();
                return;
            }


            LancerTimers();
            LancerSyncTimer();

            RafraichirAffichage();
        }






        private void LancerSyncTimer()
        {
            timerSync = new Timer();
            timerSync.Interval = 2000; // toutes les 2 secondes
            timerSync.Tick += TimerSync_Tick;
            timerSync.Start();
        }


        private void TimerSync_Tick(object sender, EventArgs e)
        {
            using (var db = new NimGameEnzoYanisContext())
            {
                var partieDb = db.Parties.FirstOrDefault(p => p.IdPartie == partie.IdPartie);
                if (partieDb == null)
                    return;

                joueurTourId = partieDb.IdJoueurTour ?? partie.IdJoueur1;


                // Mets à jour les valeurs locales si elles ont changé
                if (partieDb.BatonsRestants != batonRestant)
                {
                    batonRestant = partieDb.BatonsRestants;
                    RafraichirAffichage();
                }

                // Vérifie si la partie est finie
                if (partieDb.IdJoueurPerdant != null || batonRestant <= 0)
                {
                    timerPartie.Stop();
                    timerTour.Stop();
                    timerSync.Stop();

                    string gagnant = (partieDb.IdJoueurGagnant == joueurConnecte.IdJoueur) ? "Vous avez gagné 🎉" : "Vous avez perdu 😢";
                    MessageBox.Show($"Partie terminée. {gagnant}");
                    this.Close();
                }
            }
        }


        private void VerifierSiJoueur2Rejoint(object sender, EventArgs e)
        {
            using (var db = new NimGameEnzoYanisContext())
            {
                var partieActualisee = db.Parties.FirstOrDefault(p => p.IdPartie == partie.IdPartie);

                if (partieActualisee != null && partieActualisee.IdJoueur2 != null)
                {
                    timerAttenteJoueur2.Stop();
                    partie.IdJoueur2 = partieActualisee.IdJoueur2; // mets à jour la partie en mémoire

                    MessageBox.Show("Un joueur vous a rejoint ! La partie commence.");
                    batonRestant = partie.BatonsRestants;
                    tour = 1;
                    LancerTimers();
                    RafraichirAffichage();
                }
            }
        }


        private void LancerTimers()
        {
            timerTour = new Timer();
            timerTour.Interval = 1000;
            timerTour.Tick += TimerTour_Tick;
            timerTour.Start();

            timerPartie = new Timer();
            timerPartie.Interval = 1000;
            timerPartie.Tick += TimerPartie_Tick;
            timerPartie.Start();
        }


        private void TimerTour_Tick(object sender, EventArgs e)
        {
            secondesRestantesTour--;
            label8.Text = $"Temps restant : {secondesRestantesTour / 60}:{secondesRestantesTour % 60:D2}";

            if (secondesRestantesTour <= 0)
            {
                ChangerTour();
            }
        }


        private void TimerPartie_Tick(object sender, EventArgs e)
        {
            secondesRestantesPartie--;
            lbl_time.Text = $"Temps total : {secondesRestantesPartie / 60}:{secondesRestantesPartie % 60:D2}";
            if (secondesRestantesPartie <= 0)
            {
                timerPartie.Stop();
                timerTour.Stop();
                MessageBox.Show("Temps écoulé ! Match nul.");
                this.Close();
            }
        }




       



        private void JouerCoup(int nb)
        {
            if (joueurConnecte.IdJoueur != joueurTourId)
            {
                MessageBox.Show("Ce n’est pas votre tour !");
                return;
            }


            // Décrémente localement le nombre de bâtons
            batonRestant -= nb;

            // Si le dernier bâton est retiré, la partie est terminée
            if (batonRestant <= 0)
            {
                timerPartie.Stop();
                timerTour.Stop();

                int idPerdant = joueurConnecte.IdJoueur;
                int idGagnant = (idPerdant == partie.IdJoueur1)
                    ? (partie.IdJoueur2 ?? -1)
                    : partie.IdJoueur1;

                using (var db = new NimGameEnzoYanisContext())
                {
                    var partieDb = db.Parties.FirstOrDefault(p => p.IdPartie == partie.IdPartie);
                    if (partieDb != null)
                    {
                        partieDb.BatonsRestants = 0;
                        partieDb.IdJoueurPerdant = idPerdant;
                        partieDb.IdJoueurGagnant = idGagnant;
                        partieDb.DateFin = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Vous avez retiré le dernier bâtonnet… Vous avez perdu !");
                this.Close();
                timerSync.Stop();

                return;
            }

            // Mise à jour du nombre de bâtons restant en base
            using (var db = new NimGameEnzoYanisContext())
            {
                var partieDb = db.Parties.FirstOrDefault(p => p.IdPartie == partie.IdPartie);
                if (partieDb != null)
                {
                    partieDb.BatonsRestants = batonRestant;
                    db.SaveChanges();
                }

                // Optionnel : enregistrer le coup dans une table Coup (si tu as une)
                /*
                db.Coups.Add(new Coup
                {
                    PartieId = partie.IdPartie,
                    JoueurId = joueurConnecte.IdJoueur,
                    NbRetire = nb,
                    Date = DateTime.Now
                });
                db.SaveChanges();
                */
            }

            // Rafraîchit l'affichage et passe au joueur suivant
            RafraichirAffichage();
            ChangerTour();
        }



        private void ChangerTour()
        {
            // Inverser le tour en mémoire
            joueurTourId = (joueurTourId == partie.IdJoueur1)
                ? (partie.IdJoueur2 ?? partie.IdJoueur1)
                : partie.IdJoueur1;

            // Mettre à jour en base
            using (var db = new NimGameEnzoYanisContext())
            {
                var partieDb = db.Parties.FirstOrDefault(p => p.IdPartie == partie.IdPartie);
                if (partieDb != null)
                {
                    partieDb.IdJoueurTour = joueurTourId;
                    db.SaveChanges();
                }
            }

            // Réinitialiser le timer et l’affichage
            secondesRestantesTour = 15;
            RafraichirAffichage();
        }


        private void RafraichirAffichage()
        {
            lbl_batonTotal.Text = batonRestant.ToString();

            string nomTour = (joueurTourId == partie.IdJoueur1)
                ? "Joueur 1"
                : "Joueur 2";

            lbl_tourjoueur.Text = $"Tour de : {nomTour}";
            label8.Text = $"{secondesRestantesTour / 60}:{secondesRestantesTour % 60:D2}";
            lbl_time.Text = $"{secondesRestantesPartie / 60}:{secondesRestantesPartie % 60:D2}";
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            JouerCoup(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            JouerCoup(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            JouerCoup(3);
        }

    }
}
