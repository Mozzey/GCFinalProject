using LetsRaid.Enums;
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
        public int RaidId { get; set; }
        

        //[JsonProperty("auctions")]
        //public Auction AuctionOwner { get; set; }

        public string GetCharacterClass(string characterClass)
        {
            switch (characterClass)
            {
                case "1":
                    characterClass = CharacterClass.Warrior.ToString();
                    break;

                case "2":
                    characterClass = CharacterClass.Paladin.ToString();
                    break;

                case "3":
                    characterClass = CharacterClass.Hunter.ToString();
                    break;

                case "4":
                    characterClass = CharacterClass.Rogue.ToString();
                    break;

                case "5":
                    characterClass = CharacterClass.Priest.ToString();
                    break;

                case "6":
                    characterClass = CharacterClass.DeathKnight.ToString();
                    break;

                case "7":
                    characterClass = CharacterClass.Shaman.ToString();
                    break;

                case "8":
                    characterClass = CharacterClass.Mage.ToString();
                    break;

                case "9":
                    characterClass = CharacterClass.Warlock.ToString();
                    break;

                case "10":
                    characterClass = CharacterClass.Monk.ToString();
                    break;

                case "11":
                    characterClass = CharacterClass.Druid.ToString();
                    break;

                case "12":
                    characterClass = CharacterClass.DemonHunter.ToString();
                    break;
            }
            return characterClass;
        }

        public string GetMemberFaction(string memberFaction)
        {
            switch(memberFaction)
            {
                case "0":
                    memberFaction = CharacterFaction.Alliance.ToString();
                    break;
                case "1":
                    memberFaction = CharacterFaction.Horde.ToString();
                    break;
            }
            return memberFaction;
        }

    }
}