using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class EspecialidadesDoctore
    {
        public int IdEspecialidadesDoctores { get; set; }
        public int? IdEspecialidad { get; set; }
        public int? IdDoctor { get; set; }

        public virtual Doctore IdDoctorNavigation { get; set; }
        public virtual Especialidade IdEspecialidadNavigation { get; set; }
    }
}
