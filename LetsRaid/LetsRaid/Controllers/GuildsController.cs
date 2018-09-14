using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
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

        public ActionResult AddToCharacterDB(string characterName, string guildName, string server, int raidId)
        {
            //STEP 1a: lookup dbcharacter by server, guild, name to see if already exists
            //STEP 1b: If exists: Get charager
            //Step 1c: If not exists: create dbcharacter
            //Step 2: Get Raid by RaidID
            //Step 3: Add DB Character to Raid (or add raid to dbcharacter).
            //Step 4: Save Changes.

            var character = new DBCharacter()
            {
                
                CharacterName = characterName
            };
            
            var raid = _context.Raids.Find(raidId);
            character.Raids.Add(raid);
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