using LetsRaid.Models.ServerModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LetsRaid.DAL.Maps
{
    public class ServerMap : EntityTypeConfiguration<Server>
    {
        public ServerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.Guilds).WithRequired(x => x.Server).HasForeignKey(x => x.ServerId);
        }
    }
}