using System;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.ViewComponents.LayoutViewComponents;

public class _LayoutNavbarComponentPartial : ViewComponent
{
        private readonly PortfolioWebsiteContext _context;

        public _LayoutNavbarComponentPartial(PortfolioWebsiteContext context)
        {
            _context = context;
        }
    public IViewComponentResult Invoke()
    {
			ViewBag.toDoListCount = _context.ToDoLists.Where(x => x.Status == false).Count();
			var values = _context.ToDoLists.Where(x => x.Status == false).ToList();
        return View();
    }
}
