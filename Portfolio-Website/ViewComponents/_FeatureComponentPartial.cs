using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
