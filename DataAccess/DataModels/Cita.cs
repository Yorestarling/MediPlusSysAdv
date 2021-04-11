using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Cita
    {
        public int IdCita { get; set; }

        [Required(ErrorMessage = "Requiere el Pacientes")]
        public int IdPaciente { get; set; }
        [Required(ErrorMessage = "Requiere el Doctor")]
        public int IdDoctor { get; set; }
        [Required(ErrorMessage = "Requiere el Fecha Cita")]
        public DateTime FechaCita { get; set; }
        [Required(ErrorMessage = "Requiere el Fecha Solicitud")]
        public DateTime? FechaSolicitud { get; set; }
        public string Tanda { get; set; }
        public string Comentario { get; set; }
        public string Motivo { get; set; }
        public int? IdEstado { get; set; }


       
        public virtual Doctore IdDoctorNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
