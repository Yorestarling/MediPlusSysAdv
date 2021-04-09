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
    public class SecretariasController : Controller
    {
        private readonly MediPlusSysContext _context;

        public SecretariasController(MediPlusSysContext context)
        {
            _context = context;
        }

        // GET: Secretarias
        public async Task<IActionResult> Index(string buscar = null)
        {
            ViewData[nameof(buscar)] = buscar;

            if (string.IsNullOrEmpty(buscar))
            {
                var mediPlusSysContext = _context.Secretarias
                    .Include(s => s.IdCargoNavigation)
                    .Include(s => s.IdusuarioNavigation);
                return View(await mediPlusSysContext.ToListAsync());
            }
            else
            {

                var mediPlusSysContext = _context.Secretarias
                    .Include(s => s.IdCargoNavigation)
                    .Include(s => s.IdusuarioNavigation)
                    .Where(a=>a.Nombres.Contains(buscar));
                return View(await mediPlusSysContext.ToListAsync());
            }
            
        }

        // GET: Secretarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secretaria = await _context.Secretarias
                .Include(s => s.IdCargoNavigation)
                .Include(s => s.IdusuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdSecretaria == id);
            if (secretaria == null)
            {
                return NotFound();
            }

            return View(secretaria);
        }

        // GET: Secretarias/Create
        public IActionResult Create()
        {
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo");
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña");
            return View();
        }

        // POST: Secretarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSecretaria,Nombres,Apellidos,Sexo,Telefono,Celular,Idusuario,IdCargo")] Secretaria secretaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(secretaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", secretaria.IdCargo);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", secretaria.Idusuario);
            return View(secretaria);
        }

        // GET: Secretarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secretaria = await _context.Secretarias.FindAsync(id);
            if (secretaria == null)
            {
                return NotFound();
            }
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", secretaria.IdCargo);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", secretaria.Idusuario);
            return View(secretaria);
        }

        // POST: Secretarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSecretaria,Nombres,Apellidos,Sexo,Telefono,Celular,Idusuario,IdCargo")] Secretaria secretaria)
        {
            if (id != secretaria.IdSecretaria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(secretaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecretariaExists(secretaria.IdSecretaria))
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
            ViewData["IdCargo"] = new SelectList(_context.Cargos, "IdCargo", "NombreCargo", secretaria.IdCargo);
            ViewData["Idusuario"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", secretaria.Idusuario);
            return View(secretaria);
        }

        // GET: Secretarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var secretaria = await _context.Secretarias
                .Include(s => s.IdCargoNavigation)
                .Include(s => s.IdusuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdSecretaria == id);
            if (secretaria == null)
            {
                return NotFound();
            }

            return View(secretaria);
        }

        // POST: Secretarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var secretaria = await _context.Secretarias.FindAsync(id);
            _context.Secretarias.Remove(secretaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecretariaExists(int id)
        {
            return _context.Secretarias.Any(e => e.IdSecretaria == id);
        }
    }
}
