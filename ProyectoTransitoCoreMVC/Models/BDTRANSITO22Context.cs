using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyectoTransitoCoreMVC.Models
{
    public partial class BDTRANSITO22Context : DbContext
    {
        public BDTRANSITO22Context()
        {
        }

        public BDTRANSITO22Context(DbContextOptions<BDTRANSITO22Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Infraccione> Infracciones { get; set; }
        public virtual DbSet<Papeleta> Papeletas { get; set; }
        public virtual DbSet<Policia> Policias { get; set; }
        public virtual DbSet<Propietario> Propietarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-F7728BN\\SQLEXPRESS; Database=BDTRANSITO22; Trusted_Connection=SSPI; Encrypt=false;\n TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            modelBuilder.Entity<Infraccione>(entity =>
            {
                entity.HasKey(e => e.Codinf)
                    .HasName("PKINFRACCIONES");

                entity.ToTable("INFRACCIONES");

                entity.Property(e => e.Codinf)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODINF")
                    .IsFixedLength(true);

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIP");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Grado).HasColumnName("GRADO");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("IMPORTE");
            });

            modelBuilder.Entity<Papeleta>(entity =>
            {
                entity.HasKey(e => e.Nropap)
                    .HasName("PKPAPELETAS");

                entity.ToTable("PAPELETAS");

                entity.Property(e => e.Nropap)
                    .ValueGeneratedNever()
                    .HasColumnName("NROPAP");

                entity.Property(e => e.Codinf)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODINF")
                    .IsFixedLength(true);

                entity.Property(e => e.Codpol)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODPOL")
                    .IsFixedLength(true);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fechapago)
                    .HasColumnType("date")
                    .HasColumnName("FECHAPAGO");

                entity.Property(e => e.Fechapap)
                    .HasColumnType("date")
                    .HasColumnName("FECHAPAP")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nropla)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NROPLA")
                    .IsFixedLength(true);

                entity.Property(e => e.Pagado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PAGADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodinfNavigation)
                    .WithMany(p => p.Papeleta)
                    .HasForeignKey(d => d.Codinf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPELETAS__CODIN__32E0915F");

                entity.HasOne(d => d.CodpolNavigation)
                    .WithMany(p => p.Papeleta)
                    .HasForeignKey(d => d.Codpol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPELETAS__CODPO__33D4B598");

                entity.HasOne(d => d.NroplaNavigation)
                    .WithMany(p => p.Papeleta)
                    .HasForeignKey(d => d.Nropla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPELETAS__NROPL__31EC6D26");
            });

            modelBuilder.Entity<Policia>(entity =>
            {
                entity.HasKey(e => e.Codpol)
                    .HasName("PKPOLICIAS");

                entity.ToTable("POLICIAS");

                entity.Property(e => e.Codpol)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODPOL")
                    .IsFixedLength(true);

                entity.Property(e => e.Dirpol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRPOL");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Nompol)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOMPOL");

                entity.Property(e => e.Patrullero)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PATRULLERO")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Propietario>(entity =>
            {
                entity.HasKey(e => e.Dnipro)
                    .HasName("PKPROPIETARIOS");

                entity.ToTable("PROPIETARIOS");

                entity.Property(e => e.Dnipro)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNIPRO")
                    .IsFixedLength(true);

                entity.Property(e => e.Dirpro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DIRPRO")
                    .HasDefaultValueSql("('Sin Direccion')");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Nompro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMPRO");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.Nropla)
                    .HasName("PKVEHICULOS");

                entity.ToTable("VEHICULOS");

                entity.Property(e => e.Nropla)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NROPLA")
                    .IsFixedLength(true);

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Color)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Dnipro)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNIPRO")
                    .IsFixedLength(true);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ELIMINADO")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MODELO");

                entity.HasOne(d => d.DniproNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.Dnipro)
                    .HasConstraintName("FK__VEHICULOS__DNIPR__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
