using Codemy.DAL;
using Codemy.Helpers;
using Codemy.Models;
using Codemy.ViewModels.Home;
using Codemy.ViewModels.ShortLesson;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Reflection.Metadata;

namespace Codemy.Controllers
{
    public class ShortLessonController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ShortLessonController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index(int page = 1, int take = 4)
        {
            ViewBag.CssFileName = "shorts";


            var query = _appDbContext.ShortLessons
                .Include(s => s.AppUser);

            var shorts = query.Skip((page - 1) * take)
              .Take(take)
              .ToList();

            int pageCount = CalculatePageCount(query, take);
            PaginationVM<ShortLesson> pagination = new(shorts, pageCount, page);
            return View(pagination);
        }


        private int CalculatePageCount(IIncludableQueryable<ShortLesson, AppUser> query, int take)
        {
            return (int)Math.Ceiling((decimal)(query.Count()) / take);
        }
    }
}
