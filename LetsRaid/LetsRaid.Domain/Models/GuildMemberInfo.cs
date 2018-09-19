using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Domain.Models
{
    /// <summary>
    /// Doman model for requesting data for
    /// an individual guild member
    /// </summary>
    public class GuildMemberInfo
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// "name" endpoint for all members of a guild
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// "realm" endpoint for all members of a guild and
        /// their respective realm/server
        /// </summary>
        [JsonProperty("realm")]
        public string Realm { get; set; }
        /// <summary>
        /// "thumbnail" endpoint for all members of a guild
        /// that displays their thumbnail headshot
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        /// <summary>
        /// "class" endpoint for all members of a guild
        /// that returns a guild members' respective class
        /// such as "Warrior" or "Mage"
        /// </summary>
        [JsonProperty("class")]
        public string Class { get; set; }
        /// <summary>
        /// "level" endpoint that display the actual level
        /// of a character
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }
        /// <summary>
        /// "spec" endpoint that displays the member of a guilds
        /// spec/role such as "TANK" OR "HEALER" OR "DPS"
        /// </summary>
        [JsonProperty("spec")]
        public GuildMemberSpec Spec { get; set; }
    }
}