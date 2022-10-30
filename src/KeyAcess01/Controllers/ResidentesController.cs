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
    public class ResidentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResidentesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Residentes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Residentes.Include(r => r.Apartamento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Residentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes
                .Include(r => r.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residente == null)
            {
                return NotFound();
            }

            return View(residente);
        }

        // GET: Residentes/Create
        public IActionResult Create()
        {
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento");
            return View();
        }

        // POST: Residentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ApartamentoId,Nome,Cpf,Telefone")] Residente residente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", residente.ApartamentoId);
            return View(residente);
        }

        // GET: Residentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes.FindAsync(id);
            if (residente == null)
            {
                return NotFound();
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", residente.ApartamentoId);
            return View(residente);
        }

        // POST: Residentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ApartamentoId,Nome,Cpf,Telefone")] Residente residente)
        {
            if (id != residente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidenteExists(residente.Id))
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
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamentos, "Id", "NmrApartamento", residente.ApartamentoId);
            return View(residente);
        }

        // GET: Residentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes
                .Include(r => r.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residente == null)
            {
                return NotFound();
            }

            return View(residente);
        }

        // POST: Residentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var residente = await _context.Residentes.FindAsync(id);
            _context.Residentes.Remove(residente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidenteExists(int id)
        {
            return _context.Residentes.Any(e => e.Id == id);
        }
    }
}
