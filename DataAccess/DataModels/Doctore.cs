using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Doctore
    {
        public Doctore()
        {
            Cita = new HashSet<Cita>();
            FacturasDetalles = new HashSet<FacturasDetalle>();
        }

        public int IdDoctor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int? IdEspecialidad { get; set; }
        public int? Iddia { get; set; }
        public int? Idusuario { get; set; }
        public int IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Especialidade IdEspecialidadNavigation { get; set; }
        public virtual Dia IddiaNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<FacturasDetalle> FacturasDetalles { get; set; }
    }
}
