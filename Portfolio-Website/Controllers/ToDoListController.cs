using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.DAL_Data_Access_Layer_.Context;
using Portfolio_Website.DAL_Data_Access_Layer_.Entities;

namespace Portfolio_Website.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoListController
        private readonly PortfolioWebsiteContext _context;

        public ToDoListController(PortfolioWebsiteContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var values = _context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateToDo()
        {
            return View();
        }

        [HttpPut]
        public ActionResult CreateToDo(ToDoList toDoList)
        {
            toDoList.Status = false;
            _context.ToDoLists.Add(toDoList);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public ActionResult DeleteToDo(int id)
        {
            var values = _context.ToDoLists.Find(id);
            _context.ToDoLists.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateToDo(int id)
        {
            var values = _context.ToDoLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateToDo(ToDoList toDoList)
        {
            _context.ToDoLists.Update(toDoList);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ChangeToDoListStatusTrue(int id)
        {
            var value = _context.ToDoLists.Find(id);
            value.Status = true;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ChangeToDoListStatusFalse(int id)
        {
            var value = _context.ToDoLists.Find(id);
            value.Status = false;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
