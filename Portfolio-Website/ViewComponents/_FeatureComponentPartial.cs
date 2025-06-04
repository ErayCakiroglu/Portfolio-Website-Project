using System;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.Controllers;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
    private readonly PortfolioWebsiteContext _context;
    public _FeatureComponentPartial(PortfolioWebsiteContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var features = _context.Features.ToList();
        return View(features);
    }
}
