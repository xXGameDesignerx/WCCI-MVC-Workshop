using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basketball_MVC.Controllers
{
    public class PlayerController : Controller
    {
        public BasketballContext db;
        public PlayerController(BasketballContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Players.ToList());
        }
        public IActionResult Delete(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
