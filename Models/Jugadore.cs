using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Jugadore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Alias { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

    public virtual ICollection<Posicione> Posiciones { get; set; } = new List<Posicione>();
}
