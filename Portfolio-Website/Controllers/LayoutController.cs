using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    public class LayoutController : Controller
    {
        // GET: LayoutController
        public ActionResult Index()
        {
            return View();
        }

    }
}
