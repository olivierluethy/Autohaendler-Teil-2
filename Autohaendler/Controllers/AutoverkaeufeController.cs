using Autohaendler.Data;
using Autohaendler.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autohaendler.Controllers
{
    public class AutoverkaeufeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AutoverkaeufeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Autoverkaeufe> objAutoverkaeufeList = _db.Autoverkaeufe;
            return View(objAutoverkaeufeList);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Autoverkaeufe obj)
        {
            _db.Autoverkaeufe.Add(obj);
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
            var autoverkaeufeFromDb = _db.Autoverkaeufe.Find(id);

            if (autoverkaeufeFromDb == null)
            {
                return NotFound();
            }

            return View(autoverkaeufeFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Autoverkaeufe obj)
        {
            if (ModelState.IsValid)
            {
                _db.Autoverkaeufe.Update(obj);
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
            var tackpadFromDb = _db.Autoverkaeufe.Find(id);

            if (tackpadFromDb == null)
            {
                return NotFound();
            }
            return View(tackpadFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Autoverkaeufe obj)
        {
            if (ModelState.IsValid)
            {
                _db.Autoverkaeufe.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
