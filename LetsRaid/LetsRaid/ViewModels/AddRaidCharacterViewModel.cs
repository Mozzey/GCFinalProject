using LetsRaid.Models;

namespace LetsRaid.ViewModels
{
    public class AddRaidCharacterViewModel
    {
        public int RaidId { get; set; }
        public GuildMember Member { get; set; }
    }
}