using System;
using System.Collections.Generic;

namespace Jeu_de_nim.Models;

public partial class Joueur
{
    public int IdJoueur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Login { get; set; } = null!;

    public int? Victoires { get; set; }

    public string? Defaites { get; set; }

    public string Mail { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public virtual ICollection<Partie> PartieIdJoueur1Navigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdJoueur2Navigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdJoueurGagnantNavigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdJoueurPerdantNavigations { get; set; } = new List<Partie>();

    public virtual ICollection<Partie> PartieIdJoueurTourNavigations { get; set; } = new List<Partie>();
}
