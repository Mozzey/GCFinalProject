using LetsRaid.Models;

namespace LetsRaid.ViewModels
{
    public class AddRaidCharacterViewModel
    {
        public int RaidId { get; set; }
        public int GuildId { get; set; }
        public string ServerName { get; set; }
        public string CharacterName { get; set; }

    }
}