using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Usuario
    {
        public Usuario()
        {
            Doctores = new HashSet<Doctore>();
            HistorialdeCambios = new HashSet<HistorialdeCambio>();
            Secretaria = new HashSet<Secretaria>();
        }

        public int IdUsuario { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual ICollection<Doctore> Doctores { get; set; }
        public virtual ICollection<HistorialdeCambio> HistorialdeCambios { get; set; }
        public virtual ICollection<Secretaria> Secretaria { get; set; }
    }
}
