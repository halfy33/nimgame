using System;
using System.Collections.Generic;

namespace Jeu_de_nim.Models;

public partial class Coup
{
    public int Id { get; set; }

    public int PartieId { get; set; }

    public int JoueurId { get; set; }

    public int NbRetire { get; set; }

    public DateTime Date { get; set; }
}
