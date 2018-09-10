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

        public ActionResult DBView()
        {
            var servers = db.Servers;
            return View(servers.ToList());
        }

        public ActionResult GuildView()
        {
            var guilds = db.Guilds;
            return View(guilds.ToList().OrderBy(x => x.ServerId));
        }

        public ActionResult Details()
        {
            List<Guild> guildList = db.Guilds.ToList();
            List<ServerVM> guildVmList = guildList.Select(x => new ServerVM
            {
                ServerName = x.Server.Name,
                GuildName = x.Name
            }).ToList();
            //var guilds = db.Guilds.Include("Guilds").SingleOrDefault(x => x.ServerId == serverId);
                return View();
        }

        public ActionResult Dalaran(int? serverId)
        {
            var guilds = db.Guilds.Where(x => x.ServerId == 1);
                //Include("Guilds").SingleOrDefault(x => x.ServerId == serverId);
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