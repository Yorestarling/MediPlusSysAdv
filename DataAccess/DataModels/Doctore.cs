using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Doctore
    {
        public Doctore()
        {
            Cita = new HashSet<Cita>();
        }

        public int IdDoctor { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
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
    }
}
