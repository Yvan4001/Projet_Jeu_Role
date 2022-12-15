using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Data;
using Projet_Jeu_Role.Models;

namespace Projet_Jeu_Role.Controllers
{
    public class SituationsController : Controller
    {
        private readonly ProjetMVCContext _context;

        public SituationsController(ProjetMVCContext context)
        {
            _context = context;
        }

        // GET: Situations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Situations.ToListAsync());
        }

        // GET: Situations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Situations == null)
            {
                return NotFound();
            }

            var situation = await _context.Situations
                .Include(s => s.AnswerEnter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (situation == null)
            {
                return NotFound();
            }

            return View(situation);
        }

        // GET: Situations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Situations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SituationName,SituationDescription")] Situation situation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(situation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(situation);
        }

        // GET: Situations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Situations == null)
            {
                return NotFound();
            }

            var situation = await _context.Situations.FindAsync(id);
            if (situation == null)
            {
                return NotFound();
            }
            return View(situation);
        }

        // POST: Situations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SituationName,SituationDescription")] Situation situation)
        {
            if (id != situation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(situation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SituationExists(situation.Id))
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
            return View(situation);
        }

        // GET: Situations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Situations == null)
            {
                return NotFound();
            }

            var situation = await _context.Situations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (situation == null)
            {
                return NotFound();
            }

            return View(situation);
        }

        // POST: Situations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Situations == null)
            {
                return Problem("Entity set 'ProjetMVCContext.Situation'  is null.");
            }
            var situation = await _context.Situations.FindAsync(id);
            if (situation != null)
            {
                _context.Situations.Remove(situation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SituationExists(int id)
        {
            return _context.Situations.Any(e => e.Id == id);
        }
    }
}
