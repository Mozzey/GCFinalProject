using Newtonsoft.Json;

namespace LetsRaid.Models
{
    public class Character
    {
        [JsonProperty("name")]
        public string CharacterName { get; set; }
        //[JsonProperty("averageItemLevel")]
        //public int ItemLevel { get; set; }
    }
}