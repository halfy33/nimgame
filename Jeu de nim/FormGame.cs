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
            tour = 1; // Joueur 1 commence par défaut

            LancerTimers();
            RafraichirAffichage();
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
            if (secondesRestantesPartie <= 0)
            {
                timerPartie.Stop();
                timerTour.Stop();
                MessageBox.Show("Temps écoulé ! Match nul.");
                this.Close();
            }
        }

        private void btnMoins1_Click(object sender, EventArgs e) => JouerCoup(1);
        private void btnMoins2_Click(object sender, EventArgs e) => JouerCoup(2);
        private void btnMoins3_Click(object sender, EventArgs e) => JouerCoup(3);



        private void JouerCoup(int nb)
        {
            // Vérifie si c'est bien son tour
            bool estJoueur1 = joueurConnecte.IdJoueur == partie.IdJoueur1;
            bool estMonTour = (tour == 1 && estJoueur1) || (tour == 2 && !estJoueur1);
            if (!estMonTour)
            {
                MessageBox.Show("Ce n'est pas votre tour !");
                return;
            }

            batonRestant -= nb;

            if (batonRestant <= 0)
            {
                timerPartie.Stop();
                timerTour.Stop();
                MessageBox.Show("Vous avez retiré le dernier bâtonnet… Vous avez perdu !");
                this.Close();
                return;
            }

            RafraichirAffichage();
            ChangerTour();
        }


        private void ChangerTour()
        {
            tour = (tour == 1) ? 2 : 1;
            secondesRestantesTour = 15;
            RafraichirAffichage();
        }

        private void RafraichirAffichage()
        {
            lbl_batonTotal.Text = batonRestant.ToString();
            lbl_tourjoueur.Text = $"Tour du joueur : {tour}/2";
            label6.Text = $"Temps restant : {secondesRestantesTour / 60}:{secondesRestantesTour % 60:D2}";
        }



       
    }
}
