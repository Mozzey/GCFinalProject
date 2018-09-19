using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.Domain.Models
{
    public class BossTable
    {
        /// <summary>
        /// Domain model for calling the "bosses" endpoint to get
        /// the master list of all the bosses in WoW
        /// </summary>
        [Key]
        public int Id { get; set; }
        [JsonProperty("bosses")]
        public List<Boss> Bosses { get; set; }
    }
}