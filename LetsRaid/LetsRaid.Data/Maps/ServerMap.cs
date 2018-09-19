using LetsRaid.Domain.MVCModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LetsRaid.Data.Maps
{
    public class ServerMap : EntityTypeConfiguration<Server>
    {
        public ServerMap()
        {
            HasKey(x => x.ServerId);
            Property(x => x.ServerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.Guilds).WithRequired(x => x.Server).HasForeignKey(x => x.ServerId);
        }
    }
}