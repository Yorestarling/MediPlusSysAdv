using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Secretaria
    {
        public int IdSecretaria { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int? Idusuario { get; set; }
        public int IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
    }
}
