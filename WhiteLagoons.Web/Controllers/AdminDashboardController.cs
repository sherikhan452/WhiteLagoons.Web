using Microsoft.AspNetCore.Mvc;

namespace WhiteLagoons.Web.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
