using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess
{
    public partial class MediPlusSysContext : DbContext
    {
        public MediPlusSysContext()
        {
        }

        public MediPlusSysContext(DbContextOptions<MediPlusSysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Dia> Dias { get; set; }
        public virtual DbSet<Doctore> Doctores { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturasDetalle> FacturasDetalles { get; set; }
        public virtual DbSet<HistorialdeCambio> HistorialdeCambios { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Secretaria> Secretarias { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=Y-ODESKTOP;Initial Catalog=MediPlusSys;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("Pk_IdCargo");

                entity.Property(e => e.NombreCargo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("Pk_IdCita");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.FechaCita).HasColumnType("date");

                entity.Property(e => e.HoraFin)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.Tanda)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDoctorNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdDoctor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdDoctorCitas");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("Fk_IdEstado");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdPaciente");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.HasKey(e => e.IdDia)
                    .HasName("Pk_idDia");

                entity.Property(e => e.IdDia).HasColumnName("idDia");

                entity.Property(e => e.NombreDia)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("Pk_IdDoctor");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdCargo5");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .HasConstraintName("Fk_IdEspecialidadDoctores");

                entity.HasOne(d => d.IddiaNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.Iddia)
                    .HasConstraintName("Fk_IddiaD");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("Fk_IDUsuarioD");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad)
                    .HasName("Pk_IdEspecialidad");

                entity.Property(e => e.NombreEspecialidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstados)
                    .HasName("Pk_IdEstados");

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.Property(e => e.IdFactura).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdEstado2");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdPaciente2");
            });

            modelBuilder.Entity<FacturasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("FacturasDetalle");

                entity.Property(e => e.IdDetalle).ValueGeneratedNever();

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.FacturasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdFactura2");
            });

            modelBuilder.Entity<HistorialdeCambio>(entity =>
            {
                entity.HasKey(e => e.IdHistorial)
                    .HasName("PK__Historia__9CC7DBB445004729");

                entity.Property(e => e.Campo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActual).IsUnicode(false);

                entity.Property(e => e.EstadoAnterior).IsUnicode(false);

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.IdModificado).HasColumnName("idModificado");

                entity.Property(e => e.NombreTabla)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModificadoNavigation)
                    .WithMany(p => p.HistorialdeCambios)
                    .HasForeignKey(d => d.IdModificado)
                    .HasConstraintName("Fk_idModificado");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("Pk_IdPaciente");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("Fk_IdCargo2");
            });

            modelBuilder.Entity<Secretaria>(entity =>
            {
                entity.HasKey(e => e.IdSecretaria)
                    .HasName("Pk_IdSecretaria");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Secretaria)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_IdCargo3");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Secretaria)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("Fk_IDUsuarioS");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("Pk_IdUsuario");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("Fk_IdCargo4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
