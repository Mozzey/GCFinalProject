using LetsRaid.Models.ServerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.ViewModels
{
    public class CreateRaidViewModel
    {
        public IEnumerable<SelectListItem> Servers { get; set; }
        public int SelectedServerId { get; set; }
        public string Name { get; set; }
    }
}