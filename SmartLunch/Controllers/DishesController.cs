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
    public class DishesController : Controller
    {
        private readonly SmartLunchContext _context;

        public DishesController(SmartLunchContext context)
        {
            _context = context;
        }

        // GET: Dishes
        public async Task<IActionResult> Index()
        {
            var smartLunchContext = _context.Dishes.Include(d => d.Types);
            return View(await smartLunchContext.ToListAsync());
        }

        // GET: Dishes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishes = await _context.Dishes
                .Include(d => d.Types)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dishes == null)
            {
                return NotFound();
            }

            return View(dishes);
        }

        // GET: Dishes/Create
        public IActionResult Create()
        {
            ViewData["TypesID"] = new SelectList(_context.Types, "ID", "ID");
            return View();
        }

        // POST: Dishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name_dish,TypesID,description")] Dishes dishes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dishes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypesID"] = new SelectList(_context.Types, "ID", "ID", dishes.TypesID);
            return View(dishes);
        }

        // GET: Dishes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishes = await _context.Dishes.FindAsync(id);
            if (dishes == null)
            {
                return NotFound();
            }
            ViewData["TypesID"] = new SelectList(_context.Types, "ID", "ID", dishes.TypesID);
            return View(dishes);
        }

        // POST: Dishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name_dish,TypesID,description")] Dishes dishes)
        {
            if (id != dishes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dishes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DishesExists(dishes.ID))
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
            ViewData["TypesID"] = new SelectList(_context.Types, "ID", "ID", dishes.TypesID);
            return View(dishes);
        }

        // GET: Dishes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishes = await _context.Dishes
                .Include(d => d.Types)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dishes == null)
            {
                return NotFound();
            }

            return View(dishes);
        }

        // POST: Dishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dishes = await _context.Dishes.FindAsync(id);
            _context.Dishes.Remove(dishes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DishesExists(int id)
        {
            return _context.Dishes.Any(e => e.ID == id);
        }
    }
}
