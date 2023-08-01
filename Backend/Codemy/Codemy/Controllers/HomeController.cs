using Microsoft.AspNetCore.Mvc;

namespace Codemy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CssFileName = "style";
            return View();
        }
    }
}
