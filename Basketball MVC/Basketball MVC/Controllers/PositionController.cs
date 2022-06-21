﻿using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View(db.Position.ToList());
        }
    }
}
