﻿using Microsoft.AspNetCore.Mvc;

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

