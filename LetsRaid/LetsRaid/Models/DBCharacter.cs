using LetsRaid.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    /// <summary>
    /// This is the Character model that is inserted into the database when
    /// you add a character to a raid/group
    /// This model has the same properties as Character but Character
    /// is the domain model for making the api request
    /// </summary>
    public class DBCharacter
    {
        /// <summary>
        /// Constructor to create a new list of raids everytime a
        /// new DBCharacter is created so every character can have
        /// many raids they can be in and associated with
        /// </summary>
        public DBCharacter()
        {
            Raids = new List<Raid>();
        }
        /// <summary>
        /// Primary DBCharacter Key
        /// </summary>
        public int DBCharacterID { get; set; }
        /// <summary>
        /// This is the name of the character that you are adding
        /// to a group/raid
        /// </summary>
        public string CharacterName { get; set; }
        /// <summary>
        /// Player class such as "Warrior" for character you are 
        /// adding to a group
        /// </summary>
        public string PlayerClass { get; set; }
        /// <summary>
        /// Player spec such as "TANK" of the player added
        /// to a group
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// Player level of a player added to a group
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Player thumbail/picture of a player added to a group
        /// </summary>
        public string Thumbnail { get; set; }
        /// <summary>
        /// Server name that the player resides on 
        /// of a player added to a group
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// GuildId of the player that is added to a group
        /// </summary>
        public int GuildId { get; set; }
        /// <summary>
        /// A collection of raids that the character/player
        /// can belong to. This is a many to many relationship
        /// with Raids and DBCharacters
        /// </summary>
        public virtual ICollection<Raid> Raids { get; set; }
        /// <summary>
        /// This method takes the character Class such as "Warrior" which comes in
        /// from the response as a string number such as "1" and converts it to
        /// its respective class for a player added to a group
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
        /// to its respecive faction name for a player added to a group
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