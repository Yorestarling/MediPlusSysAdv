using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysMediPlusWeb.Controllers;
using DataAccess;
using SysMediPlusWeb.Models;

namespace SysMediPlusWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult Verify(LoginViewModel acc)
        {
            using (MediPlusSysContext test = new MediPlusSysContext())
            {

                var query = from o in test.Usuarios
                            where o.NombreDeUsuario == acc.Usuario && o.Contraseña == acc.Contraseña
                            select o;
                if (query.SingleOrDefault() != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            
            }


            using var db = new MediPlusSysContext();

            var user = db.Usuarios.ToList();

           

            return View();
        }
    }
}
