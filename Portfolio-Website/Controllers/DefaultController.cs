using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

    }
}
