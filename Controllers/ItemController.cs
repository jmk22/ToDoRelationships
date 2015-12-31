using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using System.Linq;
using ToDoRelationships.Models;

namespace ToDoRelationships.Controllers
{
    public class ItemController : Controller
    {
        private ToDoDbContext db = new ToDoDbContext();
        public IActionResult Index()
        {
            return View(db.Items.Include(x => x.Category).ToList());
        }
        public IActionResult Details(int id)
        {
            Item item = db.Items.FirstOrDefault(x => x.ItemId == id);
            return View(item);
        }
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Item item = db.Items.FirstOrDefault(d => d.ItemId == id);
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Item item = db.Items.FirstOrDefault(d => d.ItemId == id);
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.FirstOrDefault(d => d.ItemId == id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
