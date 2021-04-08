using System;
using System.Collections.Generic;

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
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
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
