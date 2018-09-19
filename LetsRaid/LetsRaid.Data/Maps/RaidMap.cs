using LetsRaid.Domain.MVCModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LetsRaid.Data.Maps
{
    public class RaidMap : EntityTypeConfiguration<Raid>
    {
        public RaidMap()
        {
            HasKey(x => x.RaidId);
            Property(x => x.RaidId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.Characters).WithMany(x => x.Raids);
        }
    }
}