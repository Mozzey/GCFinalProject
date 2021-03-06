﻿using LetsRaid.Domain.MVCModels;
using LetsRaid.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsRaid.Domain.Models
{
    public class Guild
    {
        /// <summary>
        /// Guild Model for api boss request with JsonProperty for guild "members" list
        /// and "realm" to get server name
        /// </summary>
        [JsonProperty("members")]
        public List<GuildMember> Members { get; set; }
        public int GuildId { get; set; }
        public string Name { get; set; }
        //public virtual Server Server { get; set; }
        public int ServerId { get; set; }
        [JsonProperty("realm")]
        public string ServerName { get; set; }
        public virtual Server Server { get; set; }
        public int RaidId { get; set; }

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
    }
}
