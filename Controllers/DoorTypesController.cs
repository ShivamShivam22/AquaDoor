using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AquaDoor.Data;
using AquaDoor.Models;

namespace AquaDoor.Controllers
{
    public class DoorTypesController : Controller
    {
        private readonly AquaDoorContext _context;

        public DoorTypesController(AquaDoorContext context)
        {
            _context = context;
        }

        // GET: DoorTypes
        public async Task<IActionResult> Index(string searchString)
        {
    var TheDoors = from m in _context.Doors
                 select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                TheDoors = TheDoors.Where(s => s.ProductName.Contains(searchString));
            }

    return View(await TheDoors.ToListAsync());
}

        // GET: DoorTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doorTypes = await _context.Doors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doorTypes == null)
            {
                return NotFound();
            }

            return View(doorTypes);
        }

        // GET: DoorTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoorTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,Meterial,DoorType,LockType,Size,Price")] DoorTypes doorTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doorTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doorTypes);
        }

        // GET: DoorTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doorTypes = await _context.Doors.FindAsync(id);
            if (doorTypes == null)
            {
                return NotFound();
            }
            return View(doorTypes);
        }

        // POST: DoorTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,Meterial,DoorType,LockType,Size,Price")] DoorTypes doorTypes)
        {
            if (id != doorTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doorTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoorTypesExists(doorTypes.Id))
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
            return View(doorTypes);
        }

        // GET: DoorTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doorTypes = await _context.Doors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doorTypes == null)
            {
                return NotFound();
            }

            return View(doorTypes);
        }

        // POST: DoorTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doorTypes = await _context.Doors.FindAsync(id);
            _context.Doors.Remove(doorTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoorTypesExists(int id)
        {
            return _context.Doors.Any(e => e.Id == id);
        }
    }
}
