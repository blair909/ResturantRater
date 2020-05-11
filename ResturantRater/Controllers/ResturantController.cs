﻿using ResturantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResturantRater.Controllers
{
    public class ResturantController : Controller
    {
        private ResturantDbContext _db = new ResturantDbContext();

        // GET: Resturant/Index
        public ActionResult Index()
        {
            return View(_db.Resturants.ToList());
        }
        // GET: Resturant/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resturant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resturant resturant)
        {
            if (ModelState.IsValid)
            {
                _db.Resturants.Add(resturant);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resturant);
        }

        // GET: Resturant/Delete/{id}
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Resturant resturant = _db.Resturants.Find(id);
            if (resturant == null)
            {
                return HttpNotFound();
            }

            return View(resturant);
        }

        // POST: Resturant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Resturant resturant = _db.Resturants.Find(id);
            _db.Resturants.Remove(resturant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}