﻿using Basketball_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basketball_MVC.Controllers
{
    public class CoachController : Controller
    {
        public BasketballContext db { get; set; }
        public CoachController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Coaches.ToList());
        }
        public IActionResult Create()
        {
            return View(new Coach());
        }

        [HttpPost]
        public IActionResult Create(Coach model)
        {
            List<Coach> coaches = db.Coaches.ToList();
            for(int i = 0; i < coaches.Count; i++)
            {
                if(coaches[i].Name == model.Name)
                {
                    ViewBag.Warning = "That coach already exists!";
                    return View(model);
                }
            }
            db.Coaches.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}