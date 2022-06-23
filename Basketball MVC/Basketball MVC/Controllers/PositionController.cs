using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq; // looking for an obj in particular/ 'querying' or searching

namespace Basketball_MVC.Controllers
{
    public class PositionController : Controller
    {
        public BasketballContext db;
        public PositionController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Positions.ToList());
        }
        public IActionResult Create()
        {
            return View(new Position());
        }

        [HttpPost]
        public IActionResult Create(Position model)
        {
            List<Position> pos = db.Positions.ToList();
            for (int i = 0; i < pos.Count; i++)
            {
                if (pos[i].Name == model.Name)
                {
                    ViewBag.Warning = "That coach already exists!";
                    return View(model);
                }
            }
            db.Positions.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(db.Positions.ToList().Where(p => p.Id == id).FirstOrDefault());
        }
    }
}
