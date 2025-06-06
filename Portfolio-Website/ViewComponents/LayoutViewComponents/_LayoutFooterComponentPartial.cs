using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents.LayoutViewComponents;

public class _LayoutFooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
