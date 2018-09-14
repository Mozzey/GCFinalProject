using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class DBCharacter
    {
        public int DBCharacterID { get; set; }
        public string CharacterName { get; set; }
        public virtual ICollection<Raid> Raids { get; set; }
    }
}