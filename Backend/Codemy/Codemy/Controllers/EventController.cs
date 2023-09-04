using Codemy.DAL;
using Codemy.Helpers;
using Codemy.Models;
using Codemy.ViewModels.EventDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Codemy.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public EventController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index(int page = 1, int take = 9)
        {
            ViewBag.CssFileName = "events";

            var query = _appDbContext.Events
            .Include(e => e.Comments);

            var teachers = query.Skip((page - 1) * take)
            .Take(take)
            .ToList();


            int pageCount = CalculatePageCount(query, take);
            PaginationVM<Event> pagination = new(teachers, pageCount, page);
            return View(pagination);
        }

        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.CssFileName = "event-detail";
            if (id < 1 || id == null) return NotFound();
            EventDetailVM eventDetailVM=new();

            eventDetailVM.Event = await _appDbContext.Events
                .Include(e => e.Comments)
                .FirstOrDefaultAsync(e => e.Id == id);
               
            if(eventDetailVM.Event==null)
                return NotFound();
            eventDetailVM.OfferedEventsList = _appDbContext.Events
                .Where(e => e.Id != id)
                .Take(2)
                .ToList();
            return View(eventDetailVM);
        }


        private int CalculatePageCount(IIncludableQueryable<Event, List<Comment>> query, int take)
        {
            return (int)Math.Ceiling((decimal)(query.Count()) / take);
        }
    }
}
