using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class MemberInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}