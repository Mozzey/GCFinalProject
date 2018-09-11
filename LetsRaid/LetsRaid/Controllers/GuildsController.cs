using LetsRaid.Clients;
using LetsRaid.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class GuildsController : Controller
    {
        private readonly CharacterClient _client;
        LetsraidContext _context;

        public GuildsController()
        {
            _context = new LetsraidContext();
            _client = new CharacterClient();
        }
        // GET: Guilds
        public ActionResult Index(int? Id)
        {
            //ViewBag.Title = _context.Servers.Find(Id).Name.ToString();
            var guilds = _context.Guilds.Where(x => x.ServerId == Id);
            return View(guilds);
        }

        public async Task<ActionResult> GetMembers()
        {
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            var members = await _client.GetMembers();
            return View(members);
        }
    }
}