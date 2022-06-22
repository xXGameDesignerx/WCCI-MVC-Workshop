using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Details(int id)
        {
            return View(db.Positions.ToList().Where(p => p.Id == id).FirstOrDefault());
        }
    }
}
