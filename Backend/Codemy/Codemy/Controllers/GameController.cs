using Microsoft.AspNetCore.Mvc;

namespace Codemy.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
