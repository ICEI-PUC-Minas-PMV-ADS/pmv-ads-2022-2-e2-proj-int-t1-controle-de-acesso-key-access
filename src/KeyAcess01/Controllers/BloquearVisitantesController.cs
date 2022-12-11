using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeyAcess01.Models;

namespace KeyAcess01.Controllers
{
    public class BloquearVisitantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BloquearVisitantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BloquearVisitantes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BloquearVisitante.Include(b => b.Apartamento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BloquearVisitantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloquearVisitante = await _context.BloquearVisitante
                .Include(b => b.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bloquearVisitante == null)
            {
                return NotFound();
            }

            return View(bloquearVisitante);
        }

        // GET: BloquearVisitantes/Create
        public IActionResult Create()
        {
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento");
            return View();
        }

        // POST: BloquearVisitantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ApartamentoId,Nome,Cpf")] BloquearVisitante bloquearVisitante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloquearVisitante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", bloquearVisitante.ApartamentoId);
            return View(bloquearVisitante);
        }

        // GET: BloquearVisitantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloquearVisitante = await _context.BloquearVisitante.FindAsync(id);
            if (bloquearVisitante == null)
            {
                return NotFound();
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", bloquearVisitante.ApartamentoId);
            return View(bloquearVisitante);
        }

        // POST: BloquearVisitantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ApartamentoId,Nome,Cpf")] BloquearVisitante bloquearVisitante)
        {
            if (id != bloquearVisitante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloquearVisitante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloquearVisitanteExists(bloquearVisitante.Id))
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
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", bloquearVisitante.ApartamentoId);
            return View(bloquearVisitante);
        }

        // GET: BloquearVisitantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloquearVisitante = await _context.BloquearVisitante
                .Include(b => b.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bloquearVisitante == null)
            {
                return NotFound();
            }

            return View(bloquearVisitante);
        }

        // POST: BloquearVisitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloquearVisitante = await _context.BloquearVisitante.FindAsync(id);
            _context.BloquearVisitante.Remove(bloquearVisitante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloquearVisitanteExists(int id)
        {
            return _context.BloquearVisitante.Any(e => e.Id == id);
        }
    }
}
