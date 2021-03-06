﻿//using LetsRaid.Enums;
using LetsRaid.Domain.MVCModels;
using LetsRaid.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Domain.Models
{
    public class Character
    {
        /// <summary>
        /// Constructor to create a new list of raids everytime a
        /// new DBCharacter is created so every character can have
        /// many raids they can be in and associated with
        /// </summary>
        public Character()
        {
            Raids = new List<Raid>();
        }
        [Key]
        public int CharacterID { get; set; }
        public virtual ICollection<Raid> Raids { get; set; }
        /// <summary>
        /// Individual Character name request
        /// </summary>
        [JsonProperty("name")]
        public string CharacterName { get; set; }
        /// <summary>
        /// Realm that the individual character resides on
        /// </summary>
        [JsonProperty("realm")]
        public string Realm { get; set; }
        /// <summary>
        /// Thumbail image for individual character
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Character class for individual player - i.e. "Warrior" "Mage" etc.
        /// </summary>
        [JsonProperty("class")]
        public string Class { get; set; }
        /// <summary>
        /// Character faction such as "Horde" or "Alliance"
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; set; }
        /// <summary>
        /// This property is to access the items array at the item endpoint for
        /// an individual character -- comes from CharacterGear class
        /// </summary>
        //[JsonProperty("items")]
        //public CharacterGear Gear { get; set; }
        //public int RaidId { get; set; }
        public string Spec { get; set; }
        /// <summary>
        /// Player level of a player added to a group
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Server name that the player resides on 
        /// of a player added to a group
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// GuildId of the player that is added to a group
        /// </summary>
        public int GuildId { get; set; }

//}
/// <summary>
/// This method takes the Character Class such as "Warrior" which comes in
/// from the response as a string number such as "1" and converts it to
/// its respective class
/// </summary>
/// <param name="characterClass"></param>
/// <returns>Character Class enum converted from string number such as "1" to "Warrior"</returns>
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
        /// <summary>
        /// This method converts the individual Character faction from "0" or "1"
        /// to its respecive faction name
        /// </summary>
        /// <param name="memberFaction"></param>
        /// <returns>"0" becomes Alliance and "1" becomes "Horde"</returns>
        public string GetMemberFaction(string memberFaction)
        {
            switch (memberFaction)
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