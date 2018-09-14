using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class DBCharacter
    {
        public DBCharacter()
        {
            Raids = new List<Raid>();
        }
        public int DBCharacterID { get; set; }
        public string CharacterName { get; set; }
        public string ServerName { get; set; }
        public int RaidId { get; set; }
        public int GuildId { get; set; }
        public virtual ICollection<Raid> Raids { get; set; }
    }
}