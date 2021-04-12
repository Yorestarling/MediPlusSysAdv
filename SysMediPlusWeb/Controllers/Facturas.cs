using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysMediPlusWeb.Controllers
{
    public class Facturas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearFactura()
        {
            return View();
        }

    }
}
