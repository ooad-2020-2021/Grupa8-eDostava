using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eDostava.Data;
using eDostava.Models;

namespace eDostava.Controllers
{
    public class ProizvodiController : Controller
    {
        static List<Proizvod> proizvodi = new List<Proizvod>()
        {
            new Proizvod(1, "OOAD", 6.0),
            new Proizvod(2, "af", 3.0),
            new Proizvod(3, "ba", 4.0),
            new Proizvod(4, "sa", 5.0)
        };

        public ProizvodiController(eDostavaContext context)
        {
            
        }

        // GET: Proizvodi
        public IActionResult Index()
        {
            return View(proizvodi);
        }

        // GET: Proizvodi/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = proizvodi.Find(m => m.ID == id);
            if (proizvod == null)
            {
                return NotFound();
            }

            return View(proizvod);
        }

        // GET: Proizvodi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proizvodi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Naziv,ECTS")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                proizvodi.Add(proizvod);
                return RedirectToAction(nameof(Index));
            }
            return View(proizvod);
        }

        // GET: Proizvodi/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = proizvodi.Find(p => p.ID == id);
            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        // POST: Proizvodi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Naziv,ECTS")] Proizvod proizvod)
        {
            if (id != proizvod.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Proizvod p = proizvodi.Find(pr => pr.ID == proizvod.ID);
                    proizvodi.Remove(p);
                    proizvodi.Add(proizvod);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProizvodExists(proizvod.ID))
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
            return View(proizvod);
        }

        // GET: Proizvodi/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = proizvodi.Find(m => m.ID == id);
            if (proizvod == null)
            {
                return NotFound();
            }

            return View(proizvod);
        }

        // POST: Proizvodi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var proizvod = proizvodi.Find(p => p.ID == id);
            proizvodi.Remove(proizvod);
            
            return RedirectToAction(nameof(Index));
        }

        private bool ProizvodExists(int id)
        {
            return proizvodi.Any(e => e.ID == id);
        }
    }
}
