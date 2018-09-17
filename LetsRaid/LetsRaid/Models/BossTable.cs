using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class BossTable
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public List<Boss> Bosses { get; set; }
    }
}