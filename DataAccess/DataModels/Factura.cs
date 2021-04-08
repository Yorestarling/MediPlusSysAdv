using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Factura
    {
        public Factura()
        {
            FacturasDetalles = new HashSet<FacturasDetalle>();
        }

        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPaciente { get; set; }
        public int IdEstado { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual ICollection<FacturasDetalle> FacturasDetalles { get; set; }
    }
}
