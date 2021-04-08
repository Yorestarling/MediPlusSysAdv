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
            Facturas = new HashSet<Factura>();
        }

        public int IdEstados { get; set; }
        public string NombreEstado { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
