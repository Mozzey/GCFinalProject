using LetsRaid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LetsRaid.DAL.Maps
{
    public class CharacterMap : EntityTypeConfiguration<Character>
    {
        public CharacterMap()
        {
            HasKey(x => x.CharacterId);
            Property(x => x.CharacterId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}