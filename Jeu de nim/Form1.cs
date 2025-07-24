using Jeu_de_nim.Models;

namespace Jeu_de_nim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        
           
        {
            string nom = txt_nameRegister.Text.Trim();
            string prenom = txt_SurnameRegister.Text.Trim();
            string login = txt_LoginRegister.Text.Trim();
            string mail = txt_MailRegister.Text.Trim();
            string motDePasse = txt_PassRegister.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mail) ||
                string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            using (NimGameEnzoYanisContext db = new NimGameEnzoYanisContext())
            {
                // Vérifie si le login existe déjà
                if (db.Joueurs.Any(j => j.Login == login))
                {
                    MessageBox.Show("Ce login est déjà utilisé.");
                    return;
                }

                Joueur nouveauJoueur = new Joueur
                {
                    Nom = nom,
                    Prenom = prenom,
                    Login = login,
                    Mail = mail,
                    MotDePasse = motDePasse,
                   
                };

                db.Joueurs.Add(nouveauJoueur);
                db.SaveChanges();
            }

            MessageBox.Show("Inscription réussie !");
            this.Hide();
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.ShowDialog();
            this.Close();
        }

    }
}

