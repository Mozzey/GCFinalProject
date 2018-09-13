using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Models
{
    public class GuildMember
    {
        [Key]
        public int GuildMemberId { get; set; }
        [JsonProperty("character")]
        public GuildMemberInfo Character { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }

    }
}