using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [JsonProperty("name")]
        public string CharacterName { get; set; }
        [JsonProperty("realm")]
        public string Realm { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("faction")]
        public string Faction { get; set; }


        [JsonProperty("items")]
        public CharacterGear Gear { get; set; }

        //[JsonProperty("auctions")]
        //public Auction AuctionOwner { get; set; }

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

        public string GetMemberFaction(string memberFaction)
        {
            switch(memberFaction)
            {
                case "0":
                    return "Alliance";
                    break;
                case "1":
                    return "Horde";
                    break;
            }
            return memberFaction;
        }

    }
}