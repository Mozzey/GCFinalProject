using LetsRaid.Models.GuildModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LetsRaid.DAL.Maps
{
    public class GuildMap : EntityTypeConfiguration<Guild>
    {
        public GuildMap()
        {
            HasKey(x => x.GuildId);
            Property(x => x.GuildId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}