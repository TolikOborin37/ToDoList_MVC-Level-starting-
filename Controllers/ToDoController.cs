using Microsoft.AspNetCore.Mvc;
using TODO_List_MVC.Models;

namespace TODO_List_MVC.Controllers
{
    public class ToDoController : Controller
    {
        static List<ToDo> ToList = new List<ToDo>();


        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel(ToList);
            return View(indexViewModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ToDo toDo)
        {
            ToList.Add(toDo);
            return RedirectToAction("Index");
        }
    }
}
