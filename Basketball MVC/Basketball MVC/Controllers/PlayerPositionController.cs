using Microsoft.AspNetCore.Mvc;
using Basketball_MVC.Models;
using System.Linq;

namespace Basketball_MVC.Controllers
{
    public class PlayerPositionController : Controller
    {
        public BasketballContext db { get; set; }
        public PlayerPositionController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.PlayerPositions.ToList());
        }

        public IActionResult Delete(int id)
        {
            PlayerPosition temp = db.PlayerPositions.ToList().Where(p => p.Id == id).FirstOrDefault();
            return View(temp);
        }
        //public IActionResult Delete()
        //{
        //    // deletes all objects
        //}
    }
}
