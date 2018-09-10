using LetsRaid.Models.GuildModels;
using System.Collections.Generic;

namespace LetsRaid.Models.ServerModels
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Guild> Guilds { get; set; }
    }
}