using LetsRaid.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsRaid.ViewModels
{
    public class MemberListViewModel
    {
        
        public string CharacterName { get; set; }
        public string Realm { get; set; }
        public string Class { get; set; }
        public string Thumbnail { get; set; }
        public string Faction { get; set; }
        public CharacterGear Gear { get; set; }
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
            switch (memberFaction)
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