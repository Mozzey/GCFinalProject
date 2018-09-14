﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class Raid
    { 
        [Key]
        public int RaidId { get; set; }
        public virtual ICollection<DBCharacter> DBCharacters { get; set; }
        public string RaidName { get; set; }
        public string Server { get; set; }
        public int ServerId { get; set; }
    }
}