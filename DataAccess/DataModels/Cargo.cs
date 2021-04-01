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
        }

        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
