using Microsoft.AspNetCore.Mvc;
using WhiteLagoons.Domain.Entities;
using WhiteLagoons.Infastructure.Data;

namespace WhiteLagoons.Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly ApplicationContext _db;

        public VillaNumberController(ApplicationContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var abc = _db.VillaNumbers.ToList();

            return View(abc);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(VillaNumber obj)
        {
            ModelState.Remove("Villa");

            if (ModelState.IsValid)
            {
                _db.VillaNumbers.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Data is Inserted";
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Update(int VillaID)
        {
            var vp = _db.VillaNumbers.FirstOrDefault(a => a.VillaNum == VillaID);
            
            if (vp is null)
            {
               return NotFound();
          
            }
            return View(vp);

            
        }
    }
}
