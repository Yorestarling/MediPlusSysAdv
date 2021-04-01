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
        public virtual DbSet<EspecialidadesDoctore> EspecialidadesDoctores { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Nacionalidade> Nacionalidades { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }

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
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("Pk_IdCita");

                entity.Property(e => e.FechaCita).HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.HasOne(d => d.IdDoctorNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdDoctor)
                    .HasConstraintName("Fk_IdDoctorCitas");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("Fk_IdEstado");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("Fk_IdPaciente");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.HasKey(e => e.IdDia)
                    .HasName("Pk_idDia");

                entity.ToTable("dias");

                entity.Property(e => e.IdDia).HasColumnName("idDia");

                entity.Property(e => e.NombreDia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.Dia)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("Fk_IdHorarios");
            });

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("Pk_IdDoctor");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombredeUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("Fk_IdCargo3");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .HasConstraintName("Fk_IdEspecialidad");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("Fk_IdHorario");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad)
                    .HasName("Pk_IdEspecialidad");

                entity.Property(e => e.NombreEspecialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspecialidadesDoctore>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidadesDoctores)
                    .HasName("Pk_IdEspecialidadesDoctores");

                entity.HasOne(d => d.IdDoctorNavigation)
                    .WithMany(p => p.EspecialidadesDoctores)
                    .HasForeignKey(d => d.IdDoctor)
                    .HasConstraintName("Fk_IdDoctor");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.EspecialidadesDoctores)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .HasConstraintName("Fk_IdEspecialidadDoctores");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstados)
                    .HasName("Pk_IdEstados");

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("Pk_IdHorarios");

                entity.Property(e => e.NombreHorario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nacionalidade>(entity =>
            {
                entity.HasKey(e => e.IdNacionalidad)
                    .HasName("Pk_IdNacionalidad");

                entity.Property(e => e.NombreNacionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("Pk_IdPaciente");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
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

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombredeUsuario)
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

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .HasConstraintName("Fk_IdNacionalidad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
