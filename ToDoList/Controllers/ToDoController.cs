using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
	public class ToDoController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{	
			var degerler = c.ToDo.ToList();
			return View(degerler);
		}
		[HttpGet]
		public IActionResult ToDoAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ToDoAdd(ToDoViewModel t)
		{
			c.ToDo.Add(t);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
