using LetsRaid.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class ServersController : Controller
    {
        LetsraidContext _context;

        public ServersController()
        {
            _context = new LetsraidContext();
        }

        // GET: Servers
        public ActionResult Index()
        {
            var servers = _context.Servers;
            return View(servers.ToList());
        }

    }
}