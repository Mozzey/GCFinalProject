using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    /// <summary>
    /// Raid model that is used to create new raids/groups
    /// for users to add players to for a personal group
    /// this has a many to many relationship with DBCharacters
    /// </summary>
    public class Raid
    { 
        /// <summary>
        /// Primary Key for Raid model
        /// </summary>
        [Key]
        public int RaidId { get; set; }
        /// <summary>
        /// A collection of characters that a custom made group contains
        /// </summary>
        public virtual ICollection<DBCharacter> DBCharacters { get; set; }
        /// <summary>
        /// Name of a custom made group created by the user
        /// </summary>
        public string RaidName { get; set; }
        /// <summary>
        /// Server name that is used to allow a user
        /// to see guilds and that guilds' members for the users'
        /// respective realm of choice when creating a group
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Server ID that is used to access and display guilds
        /// that belong the respective server that is chosen
        /// when a user creates a new custom group
        /// </summary>
        public int ServerId { get; set; }
    }
}