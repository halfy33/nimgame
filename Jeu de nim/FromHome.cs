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

namespace Jeu_de_nim
{


    public partial class FromHome : Form
    {
        private Joueur joueurConnecte;  
        private int joueur_id;
        


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

                MessageBox.Show($"Partie {nouvellePartie.IdPartie} créée. En attente d'un joueur 2 !");
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
