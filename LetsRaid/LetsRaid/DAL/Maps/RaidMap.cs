using LetsRaid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LetsRaid.DAL.Maps
{
    public class RaidMap : EntityTypeConfiguration<Raid>
    {
        public RaidMap()
        {
            HasKey(x => x.RaidId);
            Property(x => x.RaidId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.DBCharacters).WithMany(x => x.Raids);
        }
    }
}