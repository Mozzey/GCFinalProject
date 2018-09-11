using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.Models.GuildModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class HomeController : Controller
    {
        private readonly LetsraidContext db = new LetsraidContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ServerView()
        {
            var servers = db.Servers;
            return View(servers.ToList());
        }

        public ActionResult GuildView()
        {
            var guilds = db.Guilds;
            return View(guilds.ToList().OrderBy(x => x.ServerId));
        }

        public ActionResult GuildMemberView()
        {

            return View();
        }

        public ActionResult Details(int? serverId)
        {
            var server = db.Servers.Include("Guilds").SingleOrDefault(x => x.ServerId == serverId);
            //var guild = db.Guilds.Include("Servers").SingleOrDefault(x => x.ServerId == serverId);
            return View(server);
        }

        public ActionResult Dalaran(int? Id)
        {
            ViewBag.Title = db.Servers.Find(Id).Name.ToString();
            var guilds = db.Guilds.Where(x => x.ServerId == Id);
            return View(guilds);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}