using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;

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
