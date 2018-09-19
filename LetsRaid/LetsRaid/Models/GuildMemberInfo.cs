﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Models
{
    /// <summary>
    /// Doman model for requesting data for
    /// an individual guild member
    /// </summary>
    public class GuildMemberInfo
    {
        /// <summary>
        /// Primary Key for GuildMemberInfo
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// "name" endpoint for all members of a guild
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// "realm" endpoint for all members of a guild and
        /// their respective realm/server
        /// </summary>
        public string Realm { get; set; }
        /// <summary>
        /// "thumbnail" endpoint for all members of a guild
        /// that displays their thumbnail headshot
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// "class" endpoint for all members of a guild
        /// that returns a guild members' respective class
        /// such as "Warrior" or "Mage"
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// "level" endpoint that display the actual level
        /// of a character
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// "spec" endpoint that displays the member of a guilds
        /// spec/role such as "TANK" OR "HEALER" OR "DPS"
        /// </summary>
        public GuildMemberSpec Spec { get; set; }
    }
}