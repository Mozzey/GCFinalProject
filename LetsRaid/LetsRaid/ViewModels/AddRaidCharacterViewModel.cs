using LetsRaid.Models;
using Newtonsoft.Json;

namespace LetsRaid.ViewModels
{
    public class AddRaidCharacterViewModel
    {
        public int RaidId { get; set; }
        public int GuildId { get; set; }
        public string ServerName { get; set; }
        public int ServerId { get; set; }
        public string CharacterName { get; set; }
        public string PlayerClass { get; set; }
        //public GuildMemberSpec Spec { get; set; }
        public string Spec { get; set; }
        public int Level { get; set; }
        public string Thumbnail { get; set; }

    }
}