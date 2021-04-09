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
    public class CitasController : Controller
    {
        private readonly MediPlusSysContext _context;

        public CitasController(MediPlusSysContext context)
        {
            _context = context;
        }

        // GET: Citas
        public async Task<IActionResult> Index()
        {
            var mediPlusSysContext = _context.Citas.Include(c => c.IdDoctorNavigation).Include(c => c.IdEstadoNavigation).Include(c => c.IdPacienteNavigation);
            return View(await mediPlusSysContext.ToListAsync());
        }

        // GET: Citas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Citas
                .Include(c => c.IdDoctorNavigation)
                .Include(c => c.IdEstadoNavigation)
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.IdCita == id);
            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            ViewData["IdDoctor"] = new SelectList(_context.Doctores, "IdDoctor", "Nombres");
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstados", "NombreEstado");
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "IdPaciente", "Nombres");
            return View();
        }

        // POST: Citas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCita,IdPaciente,IdDoctor,FechaCita,FechaSolicitud,Tanda,Comentario,Motivo,IdEstado")] Cita cita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoctor"] = new SelectList(_context.Doctores, "IdDoctor", "Apellidos", cita.IdDoctor);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstados", "NombreEstado", cita.IdEstado);
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "IdPaciente", "IdPaciente", cita.IdPaciente);
            return View(cita);
        }

        // GET: Citas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Citas.FindAsync(id);
            if (cita == null)
            {
                return NotFound();
            }
            ViewData["IdDoctor"] = new SelectList(_context.Doctores, "IdDoctor", "Nombres", cita.IdDoctor);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstados", "NombreEstado", cita.IdEstado);
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "IdPaciente", "Nombres", cita.IdPaciente);
            return View(cita);
        }

        // POST: Citas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCita,IdPaciente,IdDoctor,FechaCita,FechaSolicitud,Tanda,Comentario,Motivo,IdEstado")] Cita cita)
        {
            if (id != cita.IdCita)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitaExists(cita.IdCita))
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
            ViewData["IdDoctor"] = new SelectList(_context.Doctores, "IdDoctor", "Apellidos", cita.IdDoctor);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstados", "NombreEstado", cita.IdEstado);
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "IdPaciente", "IdPaciente", cita.IdPaciente);
            return View(cita);
        }

        // GET: Citas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cita = await _context.Citas
                .Include(c => c.IdDoctorNavigation)
                .Include(c => c.IdEstadoNavigation)
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.IdCita == id);
            if (cita == null)
            {
                return NotFound();
            }

            return View(cita);
        }

        // POST: Citas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cita = await _context.Citas.FindAsync(id);
            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CitaExists(int id)
        {
            return _context.Citas.Any(e => e.IdCita == id);
        }

       
    }
}
