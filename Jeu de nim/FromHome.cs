using Jeu_de_nim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Jeu_de_nim
{


    public partial class FromHome : Form
    {
        private Joueur joueurConnecte;  
        private int joueur_id;
        private Timer attenteJoueur2Timer;
        private int idPartieEnAttente;



        public FromHome(Joueur utilisateur)
        {
            InitializeComponent();
            joueurConnecte = utilisateur;      
            joueur_id = utilisateur.IdJoueur;
        }



        private void btn_create_Click(object sender, EventArgs e)
        {
            using (NimGameEnzoYanisContext db = new NimGameEnzoYanisContext())
            {
                Partie nouvellePartie = new Partie()
                {
                    BatonsRestants = 21,
                    Disponible = true,
                    DateCreation = DateTime.Now,
                    IdJoueur1 = joueur_id,
                };

                db.Parties.Add(nouvellePartie);
                db.SaveChanges();

                idPartieEnAttente = nouvellePartie.IdPartie;

                attenteJoueur2Timer = new Timer();
                attenteJoueur2Timer.Interval = 2000; // toutes les 2 secondes
                attenteJoueur2Timer.Tick += AttenteJoueur2Timer_Tick;
                attenteJoueur2Timer.Start();

                MessageBox.Show($"Partie {idPartieEnAttente} créée. En attente d'un joueur 2...");
            }
        }

        private void AttenteJoueur2Timer_Tick(object sender, EventArgs e)
        {
            using (var db = new NimGameEnzoYanisContext())
            {
                var partie = db.Parties.FirstOrDefault(p => p.IdPartie == idPartieEnAttente);

                if (partie != null && partie.IdJoueur2 != null)
                {
                    attenteJoueur2Timer.Stop();

                    MessageBox.Show("Un joueur a rejoint la partie ! Le jeu commence.");
                    FormGame game = new FormGame(joueurConnecte, partie);
                    this.Hide();
                    game.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btn_homeGo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_joinGame.Text.Trim(), out int idPartie))
            {
                MessageBox.Show("Veuillez entrer un ID de partie valide.");
                return;
            }

            using (NimGameEnzoYanisContext db = new NimGameEnzoYanisContext())
            {
                var partie = db.Parties.FirstOrDefault(p => p.IdPartie == idPartie);

                if (partie == null)
                {
                    MessageBox.Show("Aucune partie trouvée avec cet ID.");
                    return;
                }

                if (partie.IdJoueur2 != null)
                {
                    MessageBox.Show("Cette partie est déjà complète.");
                    return;
                }

                if (partie.IdJoueur1 == joueur_id)
                {
                    MessageBox.Show("Vous êtes déjà le créateur de cette partie.");
                    return;
                }

                // Ajout du joueur 2
                partie.IdJoueur2 = joueur_id;
                db.SaveChanges();

                MessageBox.Show($"Vous avez rejoint la partie {idPartie} !");

                // Lancer le jeu
                FormGame jeu = new FormGame(joueurConnecte, partie);
                this.Hide();
                jeu.ShowDialog();
                this.Close();
            }
        }


    }
}
