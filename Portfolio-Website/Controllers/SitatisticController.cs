using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

namespace Portfolio_Website.Controllers
{
    public class SitatisticController : Controller
    {
        // GET: StatisticController
        private readonly PortfolioWebsiteContext _context;

        public SitatisticController(PortfolioWebsiteContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            ViewBag.v1 = _context.Experiences.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = _context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }

    }
}
