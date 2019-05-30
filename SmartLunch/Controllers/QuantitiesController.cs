using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartLunch.Data;
using SmartLunch.Models;

namespace SmartLunch.Controllers
{
    public class QuantitiesController : Controller
    {
        private readonly SmartLunchContext _context;

        public QuantitiesController(SmartLunchContext context)
        {
            _context = context;
        }

        // GET: Quantities
        public async Task<IActionResult> Index()
        {
            var smartLunchContext = _context.Quantities.Include(q => q.Dishes);
            return View(await smartLunchContext.ToListAsync());
        }

        // GET: Quantities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantities = await _context.Quantities
                .Include(q => q.Dishes)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quantities == null)
            {
                return NotFound();
            }

            return View(quantities);
        }

        // GET: Quantities/Create
        public IActionResult Create()
        {
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID");
            return View();
        }

        // POST: Quantities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DishesID,Q_time,Quantity")] Quantities quantities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quantities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", quantities.DishesID);
            return View(quantities);
        }

        // GET: Quantities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantities = await _context.Quantities.FindAsync(id);
            if (quantities == null)
            {
                return NotFound();
            }
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", quantities.DishesID);
            return View(quantities);
        }

        // POST: Quantities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DishesID,Q_time,Quantity")] Quantities quantities)
        {
            if (id != quantities.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quantities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuantitiesExists(quantities.ID))
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
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", quantities.DishesID);
            return View(quantities);
        }

        // GET: Quantities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantities = await _context.Quantities
                .Include(q => q.Dishes)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quantities == null)
            {
                return NotFound();
            }

            return View(quantities);
        }

        // POST: Quantities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quantities = await _context.Quantities.FindAsync(id);
            _context.Quantities.Remove(quantities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuantitiesExists(int id)
        {
            return _context.Quantities.Any(e => e.ID == id);
        }
    }
}
