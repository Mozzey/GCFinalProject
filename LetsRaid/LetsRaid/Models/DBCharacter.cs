using LetsRaid.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.Models
{
    public class DBCharacter
    {
        public DBCharacter()
        {
            Raids = new List<Raid>();
        }
        public int DBCharacterID { get; set; }
        public string CharacterName { get; set; }
        public string PlayerClass { get; set; }
        //public GuildMember Spec { get; set; }
        public string Spec { get; set; }
        public int Level { get; set; }
        public string Thumbnail { get; set; }
        public string ServerName { get; set; }
        //public int RaidId { get; set; }
        public int GuildId { get; set; }
        public virtual ICollection<Raid> Raids { get; set; }

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