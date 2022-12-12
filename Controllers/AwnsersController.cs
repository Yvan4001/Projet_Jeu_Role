using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Data;
using Projet_Jeu_Role.Models;

namespace Projet_Jeu_Role.Controllers
{
    public class AwnsersController : Controller
    {
        private readonly ProjetMVCContext _context;

        public AwnsersController(ProjetMVCContext context)
        {
            _context = context;
        }

        // GET: Awnsers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Awnser.ToListAsync());
        }

        // GET: Awnsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Awnser == null)
            {
                return NotFound();
            }

            var awnser = await _context.Awnser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (awnser == null)
            {
                return NotFound();
            }

            return View(awnser);
        }

        // GET: Awnsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Awnsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AwserContent,SituationIdEnter,SituationIdExit")] Awnser awnser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(awnser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(awnser);
        }

        // GET: Awnsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Awnser == null)
            {
                return NotFound();
            }

            var awnser = await _context.Awnser.FindAsync(id);
            if (awnser == null)
            {
                return NotFound();
            }
            return View(awnser);
        }

        // POST: Awnsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AwserContent,SituationIdEnter,SituationIdExit")] Awnser awnser)
        {
            if (id != awnser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(awnser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AwnserExists(awnser.Id))
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
            return View(awnser);
        }

        // GET: Awnsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Awnser == null)
            {
                return NotFound();
            }

            var awnser = await _context.Awnser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (awnser == null)
            {
                return NotFound();
            }

            return View(awnser);
        }

        // POST: Awnsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Awnser == null)
            {
                return Problem("Entity set 'ProjetMVCContext.Awnser'  is null.");
            }
            var awnser = await _context.Awnser.FindAsync(id);
            if (awnser != null)
            {
                _context.Awnser.Remove(awnser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AwnserExists(int id)
        {
          return _context.Awnser.Any(e => e.Id == id);
        }
    }
}
