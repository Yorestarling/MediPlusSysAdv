using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Cargo
    {
        public Cargo()
        {
            Doctores = new HashSet<Doctore>();
            Pacientes = new HashSet<Paciente>();
            Secretaria = new HashSet<Secretaria>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Secretaria> Secretaria { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
