using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Domain.Models
{
    public class CharacterGear
    {
        /// <summary>
        /// This is the next layer in the api endpoint Character allowing
        /// you to access average item level
        /// </summary>
        public int averageItemLevel { get; set; }
    }
}