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

namespace Jeu_de_nim
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
          
            string login = txt_LoginConnexion.Text.Trim();
            string motDePasse = txt_PasswordConnexion.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            using (var db = new NimGameEnzoYanisContext())
            {
                var utilisateur = db.Joueurs
                    .FirstOrDefault(j => j.Login == login && j.MotDePasse == motDePasse);

                if (utilisateur == null)
                {
                    MessageBox.Show("Identifiants incorrects.");
                    return;
                }

                MessageBox.Show($"Bienvenue {utilisateur.Prenom} !");
                this.Hide();
                FromHome home = new FromHome(utilisateur); // On transmet l’utilisateur
                home.ShowDialog();
                this.Close();
            }
        }

    }
}

