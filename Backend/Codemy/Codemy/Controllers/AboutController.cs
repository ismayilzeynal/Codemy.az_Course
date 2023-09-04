using Microsoft.AspNetCore.Mvc;

namespace Codemy.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CssFileName = "about";

            return View();
        }
    }
}
