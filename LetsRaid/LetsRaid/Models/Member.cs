using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [JsonProperty("character")]
        public Character Character { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}