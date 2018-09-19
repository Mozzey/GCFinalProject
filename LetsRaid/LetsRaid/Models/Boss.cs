﻿using Newtonsoft.Json;
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
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
    }
}