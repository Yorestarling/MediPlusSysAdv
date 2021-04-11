using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Paciente
    {
        public Paciente()
        {
            Cita = new HashSet<Cita>();
            Facturas = new HashSet<Factura>();
        }

        public int IdPaciente { get; set; }
     [Required(ErrorMessage = "Requiere el Nombre")]
        public string Nombres { get; set; }
      [Required(ErrorMessage = "Requiere el Apellido")]
        public string Apellidos { get; set; }
     // [Required(ErrorMessage = "Requiere la Cedula")]
        public string Cedula { get; set; }
      // [Required(ErrorMessage = "Requiere la Fecha de Nacimiento")]
        public DateTime? FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
       // [Required(ErrorMessage = "Requiere el Correo Electronico")]
        public string CorreoElectronico { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Sector { get; set; }
        public string Calle { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
