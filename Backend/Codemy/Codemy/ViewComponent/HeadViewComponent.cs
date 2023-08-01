using Codemy.DAL;
using Codemy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Codemy.ViewComponents
{
    public class HeadViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string cssFileName)
        {
            ViewBag.CssFileName = cssFileName;
            return View();
        }
    }

}

