using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    /// <summary>
    /// Boss Model for api boss request with JsonProperty to define endpoints
    /// </summary>
    public class Boss
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("health")]
        public int Health { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
    }
}