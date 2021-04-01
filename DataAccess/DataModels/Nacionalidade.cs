using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Nacionalidade
    {
        public Nacionalidade()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int IdNacionalidad { get; set; }
        public string NombreNacionalidad { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
