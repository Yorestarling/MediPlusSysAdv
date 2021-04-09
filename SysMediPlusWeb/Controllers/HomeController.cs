using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SysMediPlusWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace SysMediPlusWeb.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Administracion()
        {
            return View();
        }
  

       public IActionResult Login()
        {
            return View();

        }
       

       [HttpPost]
        public ActionResult Login(LoginViewModel mod)
        {
            MediPlusSysContext db = new MediPlusSysContext();

            var output = db.Usuarios.FirstOrDefault(m => m.NombreDeUsuario == mod.Usuario && m.Contraseña == mod.Contraseña);


            if(mod.command == "Iniciar")
            {
                if (output != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                }
            }

            return View();
        }

    }
}
