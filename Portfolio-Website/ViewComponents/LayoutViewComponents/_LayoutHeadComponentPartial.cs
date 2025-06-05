using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.LayoutViewComponents;

public class _LayoutHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
