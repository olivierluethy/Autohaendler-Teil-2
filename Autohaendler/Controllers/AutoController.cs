using Autohaendler.Data;
using Autohaendler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autohaendler.Controllers
{
    public class AutoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AutoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(string? modelName)
        {
            List<Auto> autos = _db.Auto.ToList();

            if (!String.IsNullOrEmpty(modelName))
            {
                autos = autos.Where(a => a.Modell.Contains(modelName)).ToList();
            }

            return View(autos);
        }
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Auto obj)
        {
            _db.Auto.Add(obj);
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
            var autoFromDb = _db.Auto.Find(id);

            if (autoFromDb == null)
            {
                return NotFound();
            }

            return View(autoFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Auto obj)
        {
            if (ModelState.IsValid)
            {
                _db.Auto.Update(obj);
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
            var autoFromDb = _db.Auto.Find(id);

            if (autoFromDb == null)
            {
                return NotFound();
            }
            return View(autoFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Auto obj)
        {
            if (ModelState.IsValid)
            {
                _db.Auto.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
