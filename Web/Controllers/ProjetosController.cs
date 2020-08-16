using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Business.Models;
using Data.Context;

namespace Web.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly MyDbContext _context;

        public ProjetosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Projetos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projetos.ToListAsync());
        }

        // GET: Projetos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoModel = await _context.Projetos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetoModel == null)
            {
                return NotFound();
            }

            return View(projetoModel);
        }

        // GET: Projetos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projetos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,DataInicio,DataFim,Id")] ProjetoModel projetoModel)
        {
            if (ModelState.IsValid)
            {
                projetoModel.Id = Guid.NewGuid();
                _context.Add(projetoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projetoModel);
        }

        // GET: Projetos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoModel = await _context.Projetos.FindAsync(id);
            if (projetoModel == null)
            {
                return NotFound();
            }
            return View(projetoModel);
        }

        // POST: Projetos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,DataInicio,DataFim,Id")] ProjetoModel projetoModel)
        {
            if (id != projetoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projetoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetoModelExists(projetoModel.Id))
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
            return View(projetoModel);
        }

        // GET: Projetos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoModel = await _context.Projetos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projetoModel == null)
            {
                return NotFound();
            }

            return View(projetoModel);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var projetoModel = await _context.Projetos.FindAsync(id);
            _context.Projetos.Remove(projetoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetoModelExists(Guid id)
        {
            return _context.Projetos.Any(e => e.Id == id);
        }
    }
}
