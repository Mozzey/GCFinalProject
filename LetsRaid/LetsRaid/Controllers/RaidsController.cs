﻿using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class RaidsController : Controller
    {
        private LetsraidContext _context;
        private readonly BossClient _bossClient;

        public RaidsController()
        {
            _bossClient = new BossClient();
            _context = new LetsraidContext();
        }

        // GET: Raids
        public ActionResult Index()
        {
            return View(_context.Raids.ToList());
        }

        public async Task<ActionResult> GetBosses()
        {
            BossTable bosses = await _bossClient.GetBosses();
            return View(bosses);
        }

        public ActionResult SuggestBosses(int? id)
        {
            var lowestCharLvl = _context.DBCharacters.Min(x => x.Level);
            var maxLevel = lowestCharLvl + 2;
            var minLevel = lowestCharLvl - 2;
            var bosses = _context.Bosses.Where(x => x.Level <= maxLevel && x.Level >= minLevel);
            var bossList = new List<Boss>();
            foreach (var boss in bosses)
            {
                if (bossList.Count < 6)
                {
                    bossList.Add(boss);
                }
            }
            var characters = _context.DBCharacters;
            var charLvl = new List<int>();
            foreach (var character in characters)
            {
                charLvl.Add(character.Level);
            }
            charLvl.Sort();
            int median = 0;
            if (charLvl.Count == 2 % 1)
            {
                median = charLvl[(charLvl.Count / 2)+(1/2)];
            }
            else
            {
                median = charLvl[((charLvl.Count / 2) + ((charLvl.Count / 2) + 1)) / 2];
            }

            
            foreach (var boss in bosses)
            {
                if(median < boss.Level-5)
                {
                    ViewBag.suggestion = "1 DPS, 2 Tanks, 3 Healers";
                }
                if(median >= boss.Level - 5 && median <= boss.Level + 5)
                {
                    ViewBag.suggestion ="2 DPS, 2 Tanks, 2 Healers";
                }
                if(median > boss.Level + 5)
                {
                    ViewBag.suggestion = "3 DPS, 2 Tanks, 1 Healer";
                }
            }
            
           
            return View(bossList);
        }

        public ActionResult AverageBoss(int? id)
        {
            var avgCharLvl = _context.DBCharacters.Average(x => x.Level);
            var maxLevel = avgCharLvl + 2;
            var minLevel = avgCharLvl - 2;
            var bosses = _context.Bosses.Where(x => x.Level <= maxLevel && x.Level >= minLevel);
            var bossList = new List<Boss>();
            foreach (var boss in bosses)
            {
                if (bossList.Count < 6)
                {
                    bossList.Add(boss);
                }
            }
            var characters = _context.DBCharacters;
            var charLvl = new List<int>();
            foreach (var character in characters)
            {
                charLvl.Add(character.Level);
            }
            charLvl.Sort();
            int median = 0;
            if (charLvl.Count == 2 % 1)
            {
                median = charLvl[(charLvl.Count / 2) + (1 / 2)];
            }
            else
            {
                median = charLvl[((charLvl.Count / 2) + ((charLvl.Count / 2) + 1)) / 2];
            }


            foreach (var boss in bosses)
            {
                if (median < boss.Level - 5)
                {
                    ViewBag.suggestion = "1 DPS, 2 Tanks, 3 Healers";
                }
                if (median >= boss.Level - 5 && median <= boss.Level + 5)
                {
                    ViewBag.suggestion = "2 DPS, 2 Tanks, 2 Healers";
                }
                if (median > boss.Level + 5)
                {
                    ViewBag.suggestion = "3 DPS, 2 Tanks, 1 Healer";
                }
            }
            return View(bossList);
        }

        public ActionResult ChallengeBoss(int? id)
        {
            var maxCharLvl = _context.DBCharacters.Max(x => x.Level);
            var maxLevel = maxCharLvl + 4;
            var minLevel = maxCharLvl;
            var bosses = _context.Bosses.Where(x => x.Level <= maxLevel && x.Level >= minLevel);
            var bossList = new List<Boss>();
            foreach (var boss in bosses)
            {
                if (bossList.Count < 3)
                {
                    bossList.Add(boss);
                }
            }
            var characters = _context.DBCharacters;
            var charLvl = new List<int>();
            foreach (var character in characters)
            {
                charLvl.Add(character.Level);
            }
            charLvl.Sort();
            int median = 0;
            if (charLvl.Count == 2 % 1)
            {
                median = charLvl[(charLvl.Count / 2) + (1 / 2)];
            }
            else
            {
                median = charLvl[((charLvl.Count / 2) + ((charLvl.Count / 2) + 1)) / 2];
            }


            foreach (var boss in bosses)
            {
                if (median < boss.Level - 5)
                {
                    ViewBag.suggestion = "16% DPS, 34% Tanks, 50% Healers";
                }
                if (median >= boss.Level - 5 && median <= boss.Level + 5)
                {
                    ViewBag.suggestion = "33% DPS, 33% Tanks, 33% Healers";
                }
                if (median > boss.Level + 5)
                {
                    ViewBag.suggestion = "50% DPS, 33% Tanks, 16% Healer";
                }
            }
            return View(bossList);
        }

        // GET: Raids/Details/5
        public ActionResult Details(int? id, int? raidId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            Raid raid = _context.Raids
                .Include(i => i.DBCharacters)
                .FirstOrDefault(x => x.RaidId == id);
            return View(raid);
        }

        public ActionResult RemoveCharacterFromGroup(int? id, int? raidId)
        {
            DBCharacter character = _context.DBCharacters.Find(id);
            //Raid raid = _context.Raids.Find(raidId);
            _context.DBCharacters.Remove(character);
            _context.SaveChanges();
            string detailsRedirect = String.Format("Details/{0}", raidId);
            return RedirectToAction(detailsRedirect);
        }

        public async Task<ActionResult> AddBossesToDB(AddBossToDbViewModel model)
        {
            BossTable bosses = await _bossClient.GetBosses();
            if (ModelState.IsValid)
            {
                foreach(var boss in bosses.Bosses)  
                {
                    _context.Bosses.Add(boss);
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Raids");
        }



        // GET: Raids/Create
        public ActionResult Create()
        {
            CreateRaidViewModel vm = new CreateRaidViewModel()
            {
                Servers = new SelectList(_context.Servers.ToList(), "ServerId", "Name")
            };
            return View(vm);
        }

        // POST: Raids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaidViewModel model)
        {
            if (ModelState.IsValid)
            {
                Raid raid = new Raid()
                {
                    RaidName = model.Name,
                    ServerId = model.SelectedServerId
                };
                _context.Raids.Add(raid);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Raids/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raid raid = _context.Raids.Find(id);
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
        public ActionResult Edit([Bind(Include = "RaidId,RaidName,Server")] Raid raid)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(raid).State = EntityState.Modified;
                _context.SaveChanges();
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
            Raid raid = _context.Raids.Find(id);
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
            Raid raid = _context.Raids.Find(id);
            _context.Raids.Remove(raid);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
