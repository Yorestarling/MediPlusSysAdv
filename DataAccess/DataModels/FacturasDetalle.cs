using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class FacturasDetalle
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public decimal? Precio { get; set; }
        public string Comentario { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
    }
}
