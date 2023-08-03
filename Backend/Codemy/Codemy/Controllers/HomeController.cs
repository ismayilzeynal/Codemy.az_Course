using Codemy.DAL;
using Codemy.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            homeVM.Courses = _appDbContext.Courses
                .Include(c => c.Instructor).ToList();
            homeVM.Instructors = _appDbContext.Instructors.ToList();

            return View(homeVM);
        }
    }
}
