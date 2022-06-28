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
        public IActionResult Details(int id)
        {
            return View(db.Players.Find(id));
        }
        public IActionResult Delete(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        public IActionResult Create()
        {
            return View(new Player());
        }

        public IActionResult Create(TempPlayer model)
        {
            Player player = new Player() { IsRetired = model.IsRetired, Name = model.Name, TeamId = model.TeamId, PPG = model.PPG};
            db.Players.Add(player);
            if (model.PointGuard)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = player.Id, PositionId = 1 };
            }
            if (model.PowerForward)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = player.Id, PositionId = 1 };
            }
            if (model.ShootingGuard)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = player.Id, PositionId = 1 };
            }
            if (model.SmallForward)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = player.Id, PositionId = 1 };
            }
            if (model.Center)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = player.Id, PositionId = 1 };
            }
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
