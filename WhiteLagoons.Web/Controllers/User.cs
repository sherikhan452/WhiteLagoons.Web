using Microsoft.AspNetCore.Mvc;

namespace WhiteLagoons.Web.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
