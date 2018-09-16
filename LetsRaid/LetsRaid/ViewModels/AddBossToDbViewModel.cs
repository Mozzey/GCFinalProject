using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsRaid.ViewModels
{
    public class AddBossToDbViewModel
    {
        [Key]
        public int BossId { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
    }
}