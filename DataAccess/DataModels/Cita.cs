using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }

      // [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public int IdDoctor { get; set; }

     //   [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public DateTime FechaCita { get; set; }
     //  [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Tanda { get; set; }
       [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string HoraInicio { get; set; }
      [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string HoraFin { get; set; }
       
        public string Comentario { get; set; }
       // [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO, FAVOR LLENARLO")]
        public string Motivo { get; set; }
        public int? IdEstado { get; set; }

        public virtual Doctore IdDoctorNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
