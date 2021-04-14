using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Doctores = new HashSet<Doctore>();
        }

        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
