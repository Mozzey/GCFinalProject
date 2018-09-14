using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.ViewModels;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class GuildsController : Controller
    {
        private readonly CharacterClient _client;
        LetsraidContext _context;

        public GuildsController()
        {
            _client = new CharacterClient();
            _context = new LetsraidContext();
        }
        // GET: Guilds
        public ActionResult Index(int? Id)
        {
            ViewBag.Server = _context.Servers.Find(Id).Name;
            var guilds = _context.Guilds.Where(x => x.ServerId == Id);
            return View(guilds);
        }

        public ActionResult AddToCharacterDB(string characterName)
        {
            var character = new DBCharacter()
            {
                CharacterName = characterName
            };
            _context.DBCharacters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index", "Raids");
        }

        public async Task<ActionResult> GetMembers(int? serverId, int? guildId)
        {
            var server = _context.Servers.Find(serverId);
            var guild = _context.Guilds.Find(guildId);

            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            var members = await _client.GetMembers(server.Name, guild.Name);
            return View(members);
        }
    }
}