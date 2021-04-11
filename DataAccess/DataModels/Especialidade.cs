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
        [Required(ErrorMessage = "Requiere el Nombre")]
        public string NombreEspecialidad { get; set; }

        public virtual ICollection<Doctore> Doctores { get; set; }
    }
}
