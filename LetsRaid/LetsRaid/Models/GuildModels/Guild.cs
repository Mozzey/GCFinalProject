using LetsRaid.Models.ServerModels;

namespace LetsRaid.Models.GuildModels
{
    public class Guild
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Server Server { get; set; }
        public int ServerId { get; set; }
    }
}