using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public int? IdJugador { get; set; }

    public string? NombreEquipo { get; set; }

    public string? Estado { get; set; }

    public virtual Jugadore? IdJugadorNavigation { get; set; }
}
