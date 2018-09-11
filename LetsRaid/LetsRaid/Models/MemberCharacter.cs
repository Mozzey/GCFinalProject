using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class MemberCharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}