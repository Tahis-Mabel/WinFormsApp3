using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsApp3.Models;

namespace WinFormsApp3.Context;

public partial class FinalContext : DbContext
{
    public FinalContext()
    {
    }

    public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Jugadore> Jugadores { get; set; }

    public virtual DbSet<Posicione> Posiciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LT-EMANOSALVAS\\SQLEXPRESS; Initial Catalog=FINAL; User ID=sa; Password=Representaciones.2024; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.IdEquipo).HasName("PK__EQUIPOS__CD77B57FF5D0A002");

            entity.ToTable("EQUIPOS");

            entity.Property(e => e.IdEquipo).HasColumnName("ID_EQUIPO");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IdJugador).HasColumnName("ID_JUGADOR");
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_EQUIPO");

            entity.HasOne(d => d.IdJugadorNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdJugador)
                .HasConstraintName("FK__EQUIPOS__ID_JUGA__3C69FB99");
        });

        modelBuilder.Entity<Jugadore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JUGADORE__3214EC27A54D2FE9");

            entity.ToTable("JUGADORES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Posicione>(entity =>
        {
            entity.HasKey(e => e.IdPosicion).HasName("PK__POSICION__BD519F312F5C20E4");

            entity.ToTable("POSICIONES");

            entity.Property(e => e.IdPosicion).HasColumnName("ID_POSICION");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IdJugador).HasColumnName("ID_JUGADOR");
            entity.Property(e => e.NombrePosicion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_POSICION");

            entity.HasOne(d => d.IdJugadorNavigation).WithMany(p => p.Posiciones)
                .HasForeignKey(d => d.IdJugador)
                .HasConstraintName("FK__POSICIONE__ID_JU__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
