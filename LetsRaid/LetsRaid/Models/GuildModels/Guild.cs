using LetsRaid.Models.ServerModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LetsRaid.Models.GuildModels
{
    public class Guild
    {
        [JsonProperty("members")]
        public List<GuildMember> Members { get; set; }
        public int GuildId { get; set; }
        public string Name { get; set; }
        public virtual Server Server { get; set; }
        public int ServerId { get; set; }
        [JsonProperty("realm")]
        public string ServerName { get; set; }
        
    }
}