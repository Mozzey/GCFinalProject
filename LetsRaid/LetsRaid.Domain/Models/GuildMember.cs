using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Domain.Models
{
    /// <summary>
    /// This class is the domain model for guild members
    /// </summary>
    public class GuildMember
    {
        [Key]
        public int GuildMemberId { get; set; }
        /// <summary>
        /// GuildMemberInfo is the next layer deep where the individual 
        /// player data actually lives
        /// </summary>
        [JsonProperty("character")]
        public GuildMemberInfo Character { get; set; }
        /// <summary>
        /// API endopint for requesting the guild members'
        /// rank in their respective guild
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

    }
}