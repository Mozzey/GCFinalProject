using LetsRaid.Models.ServerModels;
using LetsRaid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class Guild
    {
        [Key]
        public int GuildId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("members")]
        public List<GuildMember> Members { get; set; }
        public virtual Server Server { get; set; }
        public int ServerId { get; set; }
    }
}