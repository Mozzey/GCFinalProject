using LetsRaid.Models.GuildModels;
using System.Collections.Generic;

namespace LetsRaid.Models.ServerModels
{
    /// <summary>
    /// Server model that is used to access
    /// the guilds and its members that are on 
    /// the respective server the user chooses when
    /// creating a new group
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Primary key of the server chosen by the user
        /// </summary>
        public int ServerId { get; set; }
        /// <summary>
        /// Name of the server that user has chosen
        /// upon creation of a new group
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A collection of guilds that belong to the respective server
        /// </summary>
        public virtual ICollection<Guild> Guilds { get; set; }
    }
}