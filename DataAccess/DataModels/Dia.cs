using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Dia
    {
        public int IdDia { get; set; }
        public string NombreDia { get; set; }
        public int? IdHorario { get; set; }

        public virtual Horario IdHorarioNavigation { get; set; }
    }
}
