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
    public partial class FromHome : Form
    {
        private Joueur utilisateur;

        public FromHome()
        {
            InitializeComponent();
        }

        public FromHome(Joueur utilisateur)
        {
            this.utilisateur = utilisateur;
        }
    }
}
