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
    public class PricesController : Controller
    {
        private readonly SmartLunchContext _context;

        public PricesController(SmartLunchContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Index()
        {
            var smartLunchContext = _context.Prices.Include(p => p.Dishes);
            return View(await smartLunchContext.ToListAsync());
        }

        // GET: Prices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Prices
                .Include(p => p.Dishes)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // GET: Prices/Create
        public IActionResult Create()
        {
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID");
            return View();
        }

        // POST: Prices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Price,DishesID,P_time")] Prices prices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", prices.DishesID);
            return View(prices);
        }

        // GET: Prices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Prices.FindAsync(id);
            if (prices == null)
            {
                return NotFound();
            }
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", prices.DishesID);
            return View(prices);
        }

        // POST: Prices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Price,DishesID,P_time")] Prices prices)
        {
            if (id != prices.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PricesExists(prices.ID))
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
            ViewData["DishesID"] = new SelectList(_context.Dishes, "ID", "ID", prices.DishesID);
            return View(prices);
        }

        // GET: Prices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Prices
                .Include(p => p.Dishes)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // POST: Prices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prices = await _context.Prices.FindAsync(id);
            _context.Prices.Remove(prices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PricesExists(int id)
        {
            return _context.Prices.Any(e => e.ID == id);
        }
    }
}
