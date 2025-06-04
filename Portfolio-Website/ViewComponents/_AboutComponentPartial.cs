using System;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    private readonly PortfolioWebsiteContext _context;
    public _AboutComponentPartial(PortfolioWebsiteContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var abouts = _context.Abouts.ToList();
        ViewBag.abouttitle = _context.Abouts.Select(x => x.Title).FirstOrDefault();
        ViewBag.aboutSubDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
        ViewBag.aboutDetails = _context.Abouts.Select(x => x.Details).FirstOrDefault();
        return View(abouts);
    }
}
