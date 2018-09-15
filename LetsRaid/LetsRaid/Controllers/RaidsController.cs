﻿using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.ViewModels;
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
            var bosses = await _bossClient.GetBosses();
            return View(bosses);
        }

        // GET: Raids/Details/5
        public ActionResult Details(int? id)
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
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            var members = _context.DBCharacters.Include(i => i.Raids).Where(x => x.RaidId == id).ToList();
            return View(members);
        }

        public async Task<ActionResult> AddBossesToDB(AddBossToDbViewModel model)
        {
            var bosses = await _bossClient.GetBosses();
            if (ModelState.IsValid)
            {
                for (int i = 0; i < bosses.Bosses.Count; i++)
                {
                    var boss = new BossViewModel()
                    {
                        Name = bosses.Bosses[i].Name,
                        Health = bosses.Bosses[i].Health,
                        Level = bosses.Bosses[i].Level,
                        Description = bosses.Bosses[i].Description
                    };
                    _context.Bosses.Add(boss);
                }

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Raids");
        }



        // GET: Raids/Create
        public ActionResult Create()
        {
            var vm = new CreateRaidViewModel()
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
                var raid = new Raid()
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
