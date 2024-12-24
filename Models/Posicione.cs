using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Posicione
{
    public int IdPosicion { get; set; }

    public int? IdJugador { get; set; }

    public string? NombrePosicion { get; set; }

    public string? Estado { get; set; }

    public virtual Jugadore? IdJugadorNavigation { get; set; }
}
