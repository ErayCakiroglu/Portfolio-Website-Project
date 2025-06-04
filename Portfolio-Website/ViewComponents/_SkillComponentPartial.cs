using System;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.ViewComponents;

public class _SkillComponentPartial : ViewComponent
{
    
    private readonly PortfolioWebsiteContext _context;
    public _SkillComponentPartial(PortfolioWebsiteContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var skills = _context.Skills.ToList();
        return View(skills);
    }
}
