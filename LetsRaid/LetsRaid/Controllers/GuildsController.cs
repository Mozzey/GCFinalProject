using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.Models.GuildModels;
using LetsRaid.Models.ServerModels;
using LetsRaid.ViewModels;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace LetsRaid.Controllers
{
    public class GuildsController : Controller
    {
        private readonly CharacterClient _client;
        private readonly BossClient _bossClient;
        LetsraidContext _context;

        public GuildsController()
        {
            _client = new CharacterClient();
            _bossClient = new BossClient();
            _context = new LetsraidContext();
        }
        // GET: Guilds
        public ActionResult Index(int? Id, int? raidId)
        {
            ViewBag.Server = _context.Servers.Find(Id).Name;
            IQueryable<Guild> guilds = _context.Guilds.Where(x => x.ServerId == Id);
            return View(guilds);
        }

        public ActionResult AddCharacterToDB(AddRaidCharacterViewModel model, int guildId, int? raidId)
        {
            Raid raid = _context.Raids.Find(raidId);
            DBCharacter member = _context.DBCharacters
                .Where(x => x.CharacterName == model.CharacterName
                    && x.GuildId == model.GuildId
                    && x.ServerName == model.ServerName)
                .FirstOrDefault();
            if (member == null)
            {
                DBCharacter character = new DBCharacter()
                {
                    CharacterName = model.CharacterName,
                    ServerName = model.ServerName,
                    GuildId = guildId,
                    //RaidId = model.RaidId,
                    PlayerClass = model.PlayerClass,
                    Level = model.Level,
                    //Role = model.Role,
                    Thumbnail = model.Thumbnail,
                };
                character.Raids.Add(raid);
                _context.DBCharacters.Add(character);
            }
            else
            {
                member.Raids.Add(raid);
            }
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            _context.SaveChanges();
            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd.Add("serverId", string.Format("{0}", model.ServerId));
            rvd.Add("guildId", string.Format("{0}", model.GuildId));
            rvd.Add("raidId", string.Format("{0}", model.RaidId));
            return RedirectToAction("GetMembers", rvd);
        }
        public async Task<ActionResult> GetMembers(int? serverId, int? guildId)
        {
            Server server = _context.Servers.Find(serverId);
            Guild guild = _context.Guilds.Find(guildId);

            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            Guild members = await _client.GetMembers(server.Name, guild.Name);
            return View(members);
        }
    }
}