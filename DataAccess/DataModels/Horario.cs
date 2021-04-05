using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Horario
    {
        public Horario()
        {
            Doctores = new HashSet<Doctore>();
        }

        public int IdHorario { get; set; }
        public string NombreHorario { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
