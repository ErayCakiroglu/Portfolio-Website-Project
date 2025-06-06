using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;
using Portfolio_Website.DAL_Data_Access_Layer_.Entities;

namespace Portfolio_Website.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: ExperienceController
        private readonly PortfolioWebsiteContext _context;

        public ExperienceController(PortfolioWebsiteContext context)
        {
            _context = context;
        }
        public IActionResult ExperienceList()
        {
            var experience = _context.Experiences.ToList();
            return View(experience);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                return RedirectToAction("ExperienceList");
            }
            return View(experience);
        }

    }
}
