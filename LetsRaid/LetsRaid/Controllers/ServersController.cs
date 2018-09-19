using LetsRaid.Clients;
using LetsRaid.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class ServersController : Controller
    {
        LetsraidContext _context;
        CharacterClient _client;

        public ServersController()
        {
            _client = new CharacterClient();
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