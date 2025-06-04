using System;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
    private readonly PortfolioWebsiteContext _context;
    public _ExperienceComponentPartial(PortfolioWebsiteContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var experience = _context.Experiences.ToList();
        return View(experience);
    }
}
