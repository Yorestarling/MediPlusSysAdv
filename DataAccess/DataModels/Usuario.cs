using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
    }
}
