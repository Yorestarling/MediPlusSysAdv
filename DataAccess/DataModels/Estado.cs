using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Estado
    {
        public Estado()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdEstados { get; set; }
        public string NombreEstado { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
