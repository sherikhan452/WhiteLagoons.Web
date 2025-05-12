using Microsoft.AspNetCore.Mvc;
using WhiteLagoons.Domain.Entities;
using WhiteLagoons.Infastructure.Data;

namespace WhiteLagoons.Web.Controllers
{
    public class VillaController : Controller
    {

        private readonly ApplicationContext _db;

        public VillaController(ApplicationContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {

            var abc = _db.Villas.ToList();

            return View(abc);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj)
        {

            if (ModelState.IsValid)
            {
                _db.Villas.Add(obj);
                _db.SaveChanges();
                ViewBag.success = "Data is Inserted";
                return RedirectToAction("Index");
            }

            return View();
        }
                                           
        public IActionResult Update(int VillaID)
        {

            var vp = _db.Villas.FirstOrDefault(a=>a.Id == VillaID);
            if (vp is null)
            {
                return NotFound();
            }
            return View(vp);
        }

     

        [HttpPost]
        public IActionResult Update(Villa obj)
        {

            if (ModelState.IsValid)
            {
                _db.Villas.Update(obj);
                _db.SaveChanges();
                ViewBag.success = "Data is Updated";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int VillaID)
        {
            var dl = _db.Villas.FirstOrDefault(a => a.Id == VillaID);

            if (dl is not null)
            {
                _db.Villas.Remove(dl);
                _db.SaveChanges();
                ViewBag.success = "Data is Remove";
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}
