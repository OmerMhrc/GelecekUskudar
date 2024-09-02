using Microsoft.AspNetCore.Mvc;

namespace GelecekUskudar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}
