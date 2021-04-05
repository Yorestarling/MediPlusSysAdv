using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Dia
    {
        public Dia()
        {
            Doctores = new HashSet<Doctore>();
        }

        public int IdDia { get; set; }
        public string NombreDia { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
