using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class Auction
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("ownerRealm")]
        public string OwnerRealm { get; set; }
    }
}