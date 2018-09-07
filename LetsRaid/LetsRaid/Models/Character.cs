using Newtonsoft.Json;
using System.Collections.Generic;

namespace LetsRaid.Models
{
    public class Character
    {
        [JsonProperty("name")]
        public string CharacterName { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
        //[JsonProperty("faction")]
        //public string Faction { get; set; }

        [JsonProperty("items")]
        public CharacterGear Gear { get; set; }
    }
}