using Codemy.DAL;
using Codemy.Helpers;
using Codemy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Org.BouncyCastle.Utilities;

namespace Codemy.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeacherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index(int page = 1, int take = 9)
        {
            ViewBag.CssFileName = "teachers";

            var query = _appDbContext.Instructors
                .Include(i => i.Courses);

            var teachers = query.Skip((page - 1) * take)
              .Take(take)
              .ToList();


            int pageCount = CalculatePageCount(query, take);
            PaginationVM<Instructor> pagination = new(teachers, pageCount, page);
            return View(pagination);
        }

        public IActionResult Detail(int id)
        {
            return View();
        }




        private int CalculatePageCount(IIncludableQueryable<Instructor, List<Course>> query, int take)
        {
            return (int)Math.Ceiling((decimal)(query.Count()) / take);
        }

    }
}
