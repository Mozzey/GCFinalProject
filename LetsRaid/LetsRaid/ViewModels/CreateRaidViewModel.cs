using LetsRaid.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.ViewModels
{
    public class CreateRaidViewModel
    {
        public int SelectedServerId { get; set; }
        public IEnumerable<SelectListItem> Servers { get; set; }
        public string Name { get; set; }
    }
}