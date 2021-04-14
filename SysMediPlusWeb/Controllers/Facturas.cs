using Microsoft.AspNetCore.Mvc;
using SysMediPlusWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;

namespace SysMediPlusWeb.Controllers
{
    public class Facturas : Controller
    {
        private readonly MediPlusSysContext _context;

        public Facturas(MediPlusSysContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            var order = _context.Facturas.Include(a => a.FacturasDetalles).Select(a => new FacturaIndexItemDTO
            {

                idFactura = a.IdFactura,
                Idpaciente = a.IdPaciente,


            });
            return View();
        }

        public IActionResult Create()
        {
            return View(new CrearFacturasViewModel()
            {
                Details = new List<FacturaDetalleDTO>
                {
                    //new OrderDetailsDTO{ OrderId=1, ProductId = 2, UnitPrice =15, Quantity =17, Discount= 2},
                    //new OrderDetailsDTO{ OrderId=2, ProductId = 5, UnitPrice =14, Quantity =18, Discount= 85},
                    //new OrderDetailsDTO{ OrderId=3, ProductId = 6, UnitPrice =12, Quantity =19, Discount= 75},
                    //new OrderDetailsDTO{ OrderId=4, ProductId = 7, UnitPrice =11, Quantity =13, Discount= 65},
                    //new OrderDetailsDTO{ OrderId=5, ProductId = 8, UnitPrice =10, Quantity =16, Discount= 55}
                }

            });
        }


       [HttpPost]
        public IActionResult Create(CrearFacturasViewModel model)
        {

            if (model.command == "ADD")
            {
                if (model.Details == null)
                {
                    model.Details = new List<FacturaDetalleDTO>();
                }


                bool addItem = true;
                if (string.IsNullOrEmpty(Convert.ToString(model.newdetail.IdDoctor)))
                {
                    addItem = false;
                    ModelState.AddModelError("newdetail.IdDoctor", "Type product Code.");
                }
                if (model.newdetail.Precio < 1)
                {
                    addItem = false;
                    ModelState.AddModelError("newdetail.Precio", "Type Quantity < 1.");
                }
                


                if (addItem)
                {
                    model.Details.Add(model.newdetail);
                    model.newdetail = new FacturaDetalleDTO();
                }
            }
            if (model.command == "Save" && ModelState.IsValid)
            {
                Factura Fact = new Factura();
                Fact.IdPaciente = model.factura.IdPaciente;
                Fact.Fecha = model.factura.Fecha;              
                Fact.IdEstado = model.factura.IdEstado;

         

                Fact.FacturasDetalles = new List<FacturasDetalle>();

                foreach (var item in model.Details)
                {
                    Fact.FacturasDetalles.Add(new FacturasDetalle { IdDoctor = item.IdDoctor, Precio = item.Precio, Comentario = item.Comentario });
                }

                _context.Facturas.Add(Fact);
                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            ViewData["IdDoctor"] = new SelectList(_context.Facturas, "IdDoctor", "Nombres");

            return View(model);
        }

    }
}
