using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FIT5032_Pharmacity.Data;
using FIT5032_Pharmacity.Models;

namespace FIT5032_Pharmacity.Controllers
{
    public class PharmacistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PharmacistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pharmacists
        public async Task<IActionResult> Index()
        {
              return View(await _context.Pharmacist.ToListAsync());
        }

        // GET: Pharmacists/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Pharmacist == null)
            {
                return NotFound();
            }

            var pharmacist = await _context.Pharmacist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacist == null)
            {
                return NotFound();
            }

            return View(pharmacist);
        }

        // GET: Pharmacists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pharmacists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailId,Password,MobileNo")] Pharmacist pharmacist)
        {
            if (ModelState.IsValid)
            {
                pharmacist.Id = Guid.NewGuid();
                _context.Add(pharmacist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pharmacist);
        }

        // GET: Pharmacists/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Pharmacist == null)
            {
                return NotFound();
            }

            var pharmacist = await _context.Pharmacist.FindAsync(id);
            if (pharmacist == null)
            {
                return NotFound();
            }
            return View(pharmacist);
        }

        // POST: Pharmacists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailId,Password,MobileNo")] Pharmacist pharmacist)
        {
            if (id != pharmacist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pharmacist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PharmacistExists(pharmacist.Id))
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
            return View(pharmacist);
        }

        // GET: Pharmacists/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Pharmacist == null)
            {
                return NotFound();
            }

            var pharmacist = await _context.Pharmacist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacist == null)
            {
                return NotFound();
            }

            return View(pharmacist);
        }

        // POST: Pharmacists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Pharmacist == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pharmacist'  is null.");
            }
            var pharmacist = await _context.Pharmacist.FindAsync(id);
            if (pharmacist != null)
            {
                _context.Pharmacist.Remove(pharmacist);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PharmacistExists(Guid id)
        {
          return _context.Pharmacist.Any(e => e.Id == id);
        }
    }
}
