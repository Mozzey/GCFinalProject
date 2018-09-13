using LetsRaid.Clients;
using LetsRaid.DAL;
using LetsRaid.Models;
using LetsRaid.ViewModels;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterClient _characterClient;
        LetsraidContext _context;
        Raid raid = new Raid();
        public CharacterController()
        {
            _characterClient = new CharacterClient();
            _context = new LetsraidContext();
        }
        // GET: Character
        public async Task<ActionResult> GetCharacter()
        {
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            var player = await _characterClient.GetCharacter();
            return View(player);
        }

        // GET: Character/Details/5
        public async Task<ActionResult> Details(string serverName, string characterName)
        {
            
            ViewBag.Thumbnail = ConfigurationManager.AppSettings["ThumbnailEndpoint"];
            var character = await _characterClient.Details(serverName, characterName);
            var vm = new CharacterViewModel()
            {
                CharacterName = character.CharacterName,
                Realm = character.Realm,
                Class = character.Class,
                Thumbnail = character.Thumbnail,
                Gear = character.Gear,
                Faction = character.Faction
            };
            return View(character);
        }



        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
