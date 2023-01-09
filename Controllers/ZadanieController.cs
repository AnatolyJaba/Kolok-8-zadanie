using Microsoft.AspNetCore.Mvc;

namespace zadanie8.Controllers
{
    public class ZadanieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Chess()
        {
            return View();
        }
        public IActionResult Stepeni2()
        {
            return View();
        }
    }
}
