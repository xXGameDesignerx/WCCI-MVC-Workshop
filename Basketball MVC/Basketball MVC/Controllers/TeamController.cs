using Microsoft.AspNetCore.Mvc;
using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Basketball_MVC.Controllers
{
    public class TeamController : Controller
    {
        public BasketballContext db { get; set; }
        public TeamController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Teams.ToList());
        }
        public IActionResult Details(int id)
        {
            return View(db.Teams.ToList().Where(t => t.Id == id).FirstOrDefault());
        }
        public IActionResult Create()
        {
            List<Coach> coaches = new List<Coach>();
            foreach(Coach c in db.Coaches.ToList())
            {
                Team temp = db.Teams.FirstOrDefault(t => t.CoachId == c.Id);
                if(temp != null)
                {
                    coaches.Add(c);
                }
            }
            //one liner
            //List<Coach> Coaches = db.Coaches.Where(c => db.Teams.FirstOrDefault(t => t.CoachId == c.Id)== null).ToList();

            ViewBag.Coaches = new SelectList(db.Coaches.ToList(), "Id", "Name");
            return View(new Team());
        }
        [HttpPost]
        public IActionResult Create(Team model)
        {
            db.Teams.Add(model);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = model.Id.ToString()});
        }
    }
}
