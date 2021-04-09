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

        [Required(ErrorMessage = "Requiere el nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Requiere el Apellido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Requiere el Sexo")]
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "Requiere La Especialidad")]
        public int? IdEspecialidad { get; set; }
        [Required(ErrorMessage = "Requiere el dia de trabajo")]
        public int? Iddia { get; set; }

        public int? Idusuario { get; set; }
        [Required(ErrorMessage = "Requiere el Tipo de Usuario")]
        public int IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Especialidade IdEspecialidadNavigation { get; set; }
        public virtual Dia IddiaNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
