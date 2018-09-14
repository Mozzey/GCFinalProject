using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using LetsRaid.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsRaid.DAL.Maps
{
    public class DBCharacterMap : EntityTypeConfiguration<DBCharacter>
    {
        public DBCharacterMap()
        {
            HasKey(x => x.DBCharacterID);
            Property(x => x.DBCharacterID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.Raids).WithMany(x => x.DBCharacters);
        }
    }
}