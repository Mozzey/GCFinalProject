using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsRaid.Domain.Models
{
    public class GuildMemberSpec
    {
        /// <summary>
        /// "role" domain model that allows GuildMemberInfo
        /// to access the spec of a guild member such as
        /// "TANK" or "DPS" or "HEALER"
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
