using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.LayoutViewComponents;

public class _LayoutNavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
