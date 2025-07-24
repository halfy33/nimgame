using System;
using System.Collections.Generic;

namespace Jeu_de_nim.Models;

public partial class Partie
{
    public string IdPartie { get; set; } = null!;

    public int BatonsRestants { get; set; }

    public bool Disponible { get; set; }

    public DateTime DateCreation { get; set; }

    public string? DateFin { get; set; }

    public int? DureePartie { get; set; }

    public int? IdJoueurPerdant { get; set; }

    public int? IdJoueurGagnant { get; set; }

    public int IdJoueur1 { get; set; }

    public int? IdJoueur2 { get; set; }

    public virtual Joueur IdJoueur1Navigation { get; set; } = null!;

    public virtual Joueur? IdJoueur2Navigation { get; set; }

    public virtual Joueur? IdJoueurGagnantNavigation { get; set; }

    public virtual Joueur? IdJoueurPerdantNavigation { get; set; }
}
