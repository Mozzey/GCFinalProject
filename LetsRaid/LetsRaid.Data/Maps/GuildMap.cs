using LetsRaid.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LetsRaid.Data.Maps
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