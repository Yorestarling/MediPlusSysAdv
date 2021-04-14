using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysMediPlusWeb.Models
{
    public class CrearFacturasViewModel
    {
        private List<FacturaDetalleDTO> detalle;

        public FacturasDTO factura { get; set; }
        public FacturaDetalleDTO newdetail { get; set; }
        public List<FacturaDetalleDTO> Details { get; set; }

        public string command { get; set; }


    }
    public class FacturasDTO
    {
        
        public int IdFactura { get; set; }
        //[Required(ErrorMessage = "Este Campo es Requerido")]
        public DateTime Fecha { get; set; }
       // [Required(ErrorMessage = "Este Campo es Requerido")]
        public int IdPaciente { get; set; }
      ///  [Required(ErrorMessage = "Este Campo es Requerido")]
        public int IdEstado { get; set; }


    }

    public class FacturaIndexItemDTO
    {
        [Key]
        public int idFactura { get; set; }
        public int Idpaciente { get; set; }
        public decimal Total { get; set; }
    }



    public class FacturaDetalleDTO
    {

        public int IdFactura { get; set; }
       // [Required(ErrorMessage = "Este Campo es Requerido")]
        public int IdDoctor { get; set; }
       // [Required(ErrorMessage = "Este Campo es Requerido")]
        public decimal? Precio { get; set; }
        public string Comentario { get; set; }

       
    }
}
