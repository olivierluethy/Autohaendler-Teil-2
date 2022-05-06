using Autohaendler.Data;
using Autohaendler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autohaendler.Controllers
{
    public class HerstellerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HerstellerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Hersteller> objHerstellerList = _db.Hersteller;
            return View(objHerstellerList);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hersteller obj)
        {
            _db.Hersteller.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var herstellerFromDb = _db.Hersteller.Find(id);

            if (herstellerFromDb == null)
            {
                return NotFound();
            }

            return View(herstellerFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Hersteller obj)
        {
            if (ModelState.IsValid)
            {
                _db.Hersteller.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var herstellerFromDb = _db.Hersteller.Find(id);

            if (herstellerFromDb == null)
            {
                return NotFound();
            }
            return View(herstellerFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Hersteller obj)
        {
            if (ModelState.IsValid)
            {
                _db.Hersteller.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
