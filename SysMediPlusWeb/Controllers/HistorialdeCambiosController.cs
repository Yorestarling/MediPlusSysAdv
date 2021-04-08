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
    public class HistorialdeCambiosController : Controller
    {
        private readonly MediPlusSysContext _context;

        public HistorialdeCambiosController(MediPlusSysContext context)
        {
            _context = context;
        }

        // GET: HistorialdeCambios
        public async Task<IActionResult> Index()
        {
            var mediPlusSysContext = _context.HistorialdeCambios.Include(h => h.IdModificadoNavigation);
            return View(await mediPlusSysContext.ToListAsync());
        }

        // GET: HistorialdeCambios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialdeCambio = await _context.HistorialdeCambios
                .Include(h => h.IdModificadoNavigation)
                .FirstOrDefaultAsync(m => m.IdHistorial == id);
            if (historialdeCambio == null)
            {
                return NotFound();
            }

            return View(historialdeCambio);
        }

        // GET: HistorialdeCambios/Create
        public IActionResult Create()
        {
            ViewData["IdModificado"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña");
            return View();
        }

        // POST: HistorialdeCambios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHistorial,NombreTabla,RegistroId,Campo,EstadoAnterior,EstadoActual,IdModificado,FechaCambio")] HistorialdeCambio historialdeCambio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historialdeCambio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdModificado"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", historialdeCambio.IdModificado);
            return View(historialdeCambio);
        }

        // GET: HistorialdeCambios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialdeCambio = await _context.HistorialdeCambios.FindAsync(id);
            if (historialdeCambio == null)
            {
                return NotFound();
            }
            ViewData["IdModificado"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", historialdeCambio.IdModificado);
            return View(historialdeCambio);
        }

        // POST: HistorialdeCambios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHistorial,NombreTabla,RegistroId,Campo,EstadoAnterior,EstadoActual,IdModificado,FechaCambio")] HistorialdeCambio historialdeCambio)
        {
            if (id != historialdeCambio.IdHistorial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historialdeCambio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistorialdeCambioExists(historialdeCambio.IdHistorial))
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
            ViewData["IdModificado"] = new SelectList(_context.Usuarios, "IdUsuario", "Contraseña", historialdeCambio.IdModificado);
            return View(historialdeCambio);
        }

        // GET: HistorialdeCambios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialdeCambio = await _context.HistorialdeCambios
                .Include(h => h.IdModificadoNavigation)
                .FirstOrDefaultAsync(m => m.IdHistorial == id);
            if (historialdeCambio == null)
            {
                return NotFound();
            }

            return View(historialdeCambio);
        }

        // POST: HistorialdeCambios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historialdeCambio = await _context.HistorialdeCambios.FindAsync(id);
            _context.HistorialdeCambios.Remove(historialdeCambio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistorialdeCambioExists(int id)
        {
            return _context.HistorialdeCambios.Any(e => e.IdHistorial == id);
        }
    }
}
