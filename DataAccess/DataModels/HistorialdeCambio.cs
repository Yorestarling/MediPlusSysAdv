using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class HistorialdeCambio
    {
        public int IdHistorial { get; set; }
        public string NombreTabla { get; set; }
        public int? RegistroId { get; set; }
        public string Campo { get; set; }
        public string EstadoAnterior { get; set; }
        public string EstadoActual { get; set; }
        public int? IdModificado { get; set; }
        public DateTime? FechaCambio { get; set; }

        public virtual Usuario IdModificadoNavigation { get; set; }
    }
}
