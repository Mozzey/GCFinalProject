using LetsRaid.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult DBView()
        {
            var servers = db.Servers;
            return View(servers.ToList());
        }

        public ActionResult GuildView()
        {
            var guilds = db.Guilds;
            return View(guilds.ToList());
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