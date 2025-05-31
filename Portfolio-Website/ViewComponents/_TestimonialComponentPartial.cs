using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.ViewComponents;

public class _TestimonialComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
