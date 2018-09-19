using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class GuildMemberSpec
    {
        /// <summary>
        /// "role" domain model that allows GuildMemberInfo
        /// to access the spec of a guild member such as
        /// "TANK" or "DPS" or "HEALER"
        /// </summary>
        public string role { get; set; }
    }
}