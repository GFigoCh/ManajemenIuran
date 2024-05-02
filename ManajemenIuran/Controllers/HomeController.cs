using Microsoft.AspNetCore.Mvc;

namespace ManajemenIuran.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
