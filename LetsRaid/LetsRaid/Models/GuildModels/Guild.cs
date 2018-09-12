using LetsRaid.Models.ServerModels;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LetsRaid.Models.GuildModels
{
    public class Guild
    {
        [JsonProperty("members")]
        public List<GuildMember> Members { get; set; }
        public int GuildId { get; set; }
        public string Name { get; set; }
        public virtual Server Server { get; set; }
        public int ServerId { get; set; }
        [JsonProperty("realm")]
        public string ServerName { get; set; }


        public string GetCharacterClass(string characterClass)
        {
            switch (characterClass)
            {
                case "1":
                    return "Warrior";
                    break;

                case "2":
                    return "Paladin";
                    break;

                case "3":
                    return "Hunter";
                    break;

                case "4":
                    return "Rogue";
                    break;

                case "5":
                    return "Priest";
                    break;

                case "6":
                    return "Death Knight";
                    break;

                case "7":
                    return "Shaman";
                    break;

                case "8":
                    return "Mage";
                    break;

                case "9":
                    return "Warlock";
                    break;

                case "10":
                    return "Monk";
                    break;

                case "11":
                    return "Druid";
                    break;

                case "12":
                    return "Demon Hunter";
                    break;
            }
            return characterClass;
        }
    }
}