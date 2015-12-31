using System.Linq;
using Microsoft.AspNet.Mvc;
using ToDoRelationships.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoRelationships.Controllers
{
    public class CategoryController : Controller
    {
        private ToDoDbContext db = new ToDoDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        public IActionResult Details(int id)
        {
            Category category = db.Categories.FirstOrDefault(d => d.CategoryId == id);
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Category category = db.Categories.FirstOrDefault(d => d.CategoryId == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Category category = db.Categories.FirstOrDefault(d => d.CategoryId == id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.FirstOrDefault(d => d.CategoryId == id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
