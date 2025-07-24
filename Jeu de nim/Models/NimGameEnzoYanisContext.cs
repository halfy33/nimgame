using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Jeu_de_nim.Models;

public partial class NimGameEnzoYanisContext : DbContext
{
    public NimGameEnzoYanisContext()
    {
    }

    public NimGameEnzoYanisContext(DbContextOptions<NimGameEnzoYanisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Partie> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=2a03:5840:111:1024:143:e6a5:7dbe:31b3;Database=NimGameEnzoYanis;User ID=sa;Password=erty64%;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Joueur>(entity =>
        {
            entity.HasKey(e => e.IdJoueur).HasName("PK__Joueur__64E2661B05DF458E");

            entity.ToTable("Joueur");

            entity.Property(e => e.IdJoueur).HasColumnName("idJoueur");
            entity.Property(e => e.Defaites)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defaites");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("motDePasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Victoires).HasColumnName("victoires");
        });

        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.IdPartie).HasName("PK__Partie__EE3714C56CF0AA6C");

            entity.ToTable("Partie");

            entity.Property(e => e.IdPartie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idPartie");
            entity.Property(e => e.BatonsRestants).HasColumnName("batonsRestants");
            entity.Property(e => e.DateCreation)
                .HasColumnType("datetime")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DateFin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dateFin");
            entity.Property(e => e.Disponible).HasColumnName("disponible");
            entity.Property(e => e.DureePartie).HasColumnName("dureePartie");
            entity.Property(e => e.IdJoueur1).HasColumnName("idJoueur1");
            entity.Property(e => e.IdJoueur2).HasColumnName("idJoueur2");
            entity.Property(e => e.IdJoueurGagnant).HasColumnName("idJoueurGagnant");
            entity.Property(e => e.IdJoueurPerdant).HasColumnName("idJoueurPerdant");

            entity.HasOne(d => d.IdJoueur1Navigation).WithMany(p => p.PartieIdJoueur1Navigations)
                .HasForeignKey(d => d.IdJoueur1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__idJoueur__286302EC");

            entity.HasOne(d => d.IdJoueur2Navigation).WithMany(p => p.PartieIdJoueur2Navigations)
                .HasForeignKey(d => d.IdJoueur2)
                .HasConstraintName("FK__Partie__idJoueur__29572725");

            entity.HasOne(d => d.IdJoueurGagnantNavigation).WithMany(p => p.PartieIdJoueurGagnantNavigations)
                .HasForeignKey(d => d.IdJoueurGagnant)
                .HasConstraintName("FK__Partie__idJoueur__276EDEB3");

            entity.HasOne(d => d.IdJoueurPerdantNavigation).WithMany(p => p.PartieIdJoueurPerdantNavigations)
                .HasForeignKey(d => d.IdJoueurPerdant)
                .HasConstraintName("FK__Partie__idJoueur__267ABA7A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
