using Codemy.DAL;
using Codemy.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Codemy.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ViewBag.CssFileName = "style";
            HomeVM homeVM = new();
            homeVM.Sliders = _appDbContext.Sliders.ToList();

            return View(homeVM);
        }
    }
}
