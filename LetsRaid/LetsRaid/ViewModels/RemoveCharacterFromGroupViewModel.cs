using LetsRaid.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.ViewModels
{
    public class RemoveCharacterFromGroupViewModel
    {
        public int Id { get; set; }
        public int RaidId { get; set; }
        public int GuildId { get; set; }
        public string ServerName { get; set; }
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public GuildMemberSpec Role { get; set; }
        public int Level { get; set; }
        public string Thumbnail { get; set; }
    }
}