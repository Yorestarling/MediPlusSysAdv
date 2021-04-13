using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Doctores = new HashSet<Doctore>();
        }

        public int IdEspecialidad { get; set; }
        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string NombreEspecialidad { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
