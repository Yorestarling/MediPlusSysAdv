using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace SysMediPlusWeb.Controllers
{
    public class DoctoresController : Controller
    {
        private readonly MediPlusSysContext _context;

        public DoctoresController(MediPlusSysContext context)
        {
            _context = context;
        }

        // GET: Doctores
        public async Task<IActionResult> Index(string buscar = null)
        {
            ViewData[nameof(buscar)] = buscar;

            if (string.IsNullOrEmpty(buscar))
            {
                var mediPlusSysContext = _context.Doctores
               .Include(d => d.IdCargoNavigation)
               .Include(d => d.IdEspecialidadNavigation)
               .Include(d => d.IddiaNavigation)
               .Include(d => d.IdusuarioNavigation);
                return View(await mediPlusSysContext.ToListAsync());
            }
            else
            {
                var mediPlusSysContext = _context.Doctores
              .Include(d => d.IdCargoNavigation)
              .Include(d => d.IdEspecialidadNavigation)
              .Include(d => d.IddiaNavigation)
              .Include(d => d.IdusuarioNavigation)
              .Where(a=> a.Nombres.Contains(buscar));
                return View(await mediPlusSysContext.ToListAsync());
            }

        }

        // GET: Doctores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores
                .Include(d => d.IdCargoNavigation)
                .Include(d => d.IdEspecialidadNavigation)
                .Include(d => d.IddiaNavigation)
                .Include(d => d.IdusuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdDoctor == id);
            if (doctore == null)
            {
                return NotFound();
            }

            return View(doctore);
        }

        // GET: Doctores/Create
        public IActionResult Create()
        {
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo");
            ViewData["IdEspecialidad"] = new SelectList(_context.Especialidades, "IdEspecialidad", "NombreEspecialidad");
            ViewData["Iddia"] = new SelectList(_context.Dias, "IdDia", "NombreDia");
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña");
            return View();
        }

        // POST: Doctores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDoctor,Nombres,Apellidos,Sexo,Telefono,Celular,IdEspecialidad,Iddia,Idusuario,IdCargo")] Doctore doctore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", doctore.IdCargoNavigation.NombreCargo);
            ViewData["IdEspecialidad"] = new SelectList(_context.Especialidades, "IdEspecialidad", "NombreEspecialidad", doctore.IdEspecialidadNavigation.NombreEspecialidad);
            ViewData["Iddia"] = new SelectList(_context.Dias, "IdDia", "NombreDia", doctore.IddiaNavigation.NombreDia);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", doctore.IdusuarioNavigation.NombreDeUsuario);
            return View(doctore);
        }

        // GET: Doctores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores.FindAsync(id);
            if (doctore == null)
            {
                return NotFound();
            }
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", doctore.IdCargo);
            ViewData["IdEspecialidad"] = new SelectList(_context.Especialidades, "IdEspecialidad", "NombreEspecialidad", doctore.IdEspecialidad);
            ViewData["Iddia"] = new SelectList(_context.Dias, "IdDia", "NombreDia", doctore.Iddia);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", doctore.Idusuario);
            return View(doctore);
        }

        // POST: Doctores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDoctor,Nombres,Apellidos,Sexo,Telefono,Celular,IdEspecialidad,Iddia,Idusuario,IdCargo")] Doctore doctore)
        {
            if (id != doctore.IdDoctor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctoreExists(doctore.IdDoctor))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", doctore.IdCargo);
            ViewData["IdEspecialidad"] = new SelectList(_context.Especialidades, "IdEspecialidad", "NombreEspecialidad", doctore.IdEspecialidad);
            ViewData["Iddia"] = new SelectList(_context.Dias, "IdDia", "NombreDia", doctore.Iddia);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", doctore.Idusuario);
            return View(doctore);
        }

        // GET: Doctores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores
                .Include(d => d.IdCargoNavigation)
                .Include(d => d.IdEspecialidadNavigation)
                .Include(d => d.IddiaNavigation)
                .Include(d => d.IdusuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdDoctor == id);
            if (doctore == null)
            {
                return NotFound();
            }

            return View(doctore);
        }

        // POST: Doctores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctore = await _context.Doctores.FindAsync(id);
            _context.Doctores.Remove(doctore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctoreExists(int id)
        {
            return _context.Doctores.Any(e => e.IdDoctor == id);
        }
    }
}
