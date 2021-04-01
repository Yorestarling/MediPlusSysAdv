using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Doctore
    {
        public Doctore()
        {
            Cita = new HashSet<Cita>();
            EspecialidadesDoctores = new HashSet<EspecialidadesDoctore>();
        }

        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int? IdEspecialidad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string NombredeUsuario { get; set; }
        public string Contraseña { get; set; }
        public int? IdHorario { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Especialidade IdEspecialidadNavigation { get; set; }
        public virtual Horario IdHorarioNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<EspecialidadesDoctore> EspecialidadesDoctores { get; set; }
    }
}
