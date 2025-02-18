using Microsoft.AspNetCore.Mvc;

namespace pract.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
