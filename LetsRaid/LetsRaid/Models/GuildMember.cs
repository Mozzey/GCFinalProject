using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class GuildMember
    {
        [Key]
        public int GuildMemberId { get; set; }
        [JsonProperty("character")]
        public MemberCharacter Character { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }

    }
}