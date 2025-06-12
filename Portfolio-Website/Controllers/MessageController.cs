using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;
using Portfolio_Website.DAL_Data_Access_Layer_.Entities;

namespace Portfolio_Website.Controllers
{
    public class MessageController : Controller
    {
        // GET: MessageController
        private readonly PortfolioWebsiteContext _context;

        public MessageController(PortfolioWebsiteContext context)
        {
            _context = context;
        }
        public ActionResult Inbox()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        private IActionResult DoIfMessageExists(int id, Func<Message, IActionResult> action)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                return action(message);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            return DoIfMessageExists(id, message =>
            {
                message.IsRead = true;
                _context.SaveChanges();
                return RedirectToAction("Inbox");
            });
        }


        public IActionResult ChangeIsReadToFalse(int id)
        {
            return DoIfMessageExists(id, message =>
            {
                message.IsRead = false;
                _context.SaveChanges();
                return RedirectToAction("Inbox");
            });
        }


        public IActionResult DeleteMessage(int id)
        {
            return DoIfMessageExists(id, message =>
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
                return RedirectToAction("Inbox");
            });
        }
        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Find(id);
            return View(value);
        }
    }
}
