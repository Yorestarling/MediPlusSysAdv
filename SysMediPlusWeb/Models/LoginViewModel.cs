using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SysMediPlusWeb.Models
{
    public class LoginViewModel
    {

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public  class InputModel
        {
            [Required]
            public string Usuario { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Contraseña { get; set; }
        }
        

    }
}
