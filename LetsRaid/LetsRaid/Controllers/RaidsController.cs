﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LetsRaid.DAL;
using LetsRaid.Models;

namespace LetsRaid.Controllers
{
    public class RaidsController : Controller
    {
        private LetsraidContext db = new LetsraidContext();

        // GET: Raids
        public ActionResult Index()
        {
            return View(db.Raids.ToList());
        }

        // GET: Raids/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var raid = db.Raids.Include(x => x.Characters).FirstOrDefault(x => x.RaidId == id);
            if (raid == null)
            {
                return HttpNotFound();
            }
            return View(raid);
        }

        // GET: Raids/Create
        public ActionResult Create()
        {
            return RedirectToAction("Details");
        }

        // POST: Raids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RaidId")] Raid raid)
        {
            if (ModelState.IsValid)
            {
                db.Raids.Add(raid);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = raid.RaidId });
            }

            return RedirectToAction("Details", new { id = raid.RaidId });
        }

        // GET: Raids/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raid raid = db.Raids.Find(id);
            if (raid == null)
            {
                return HttpNotFound();
            }
            return View(raid);
        }

        // POST: Raids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RaidId")] Raid raid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raid);
        }

        // GET: Raids/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raid raid = db.Raids.Find(id);
            if (raid == null)
            {
                return HttpNotFound();
            }
            return View(raid);
        }

        // POST: Raids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Raid raid = db.Raids.Find(id);
            db.Raids.Remove(raid);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}