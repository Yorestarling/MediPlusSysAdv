using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Tanda { get; set; }
        public string Motivo { get; set; }
        public int? IdEstado { get; set; }

        public virtual Doctore IdDoctorNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
