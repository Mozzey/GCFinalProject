using LetsRaid.Domain.Models;
using LetsRaid.Domain.MVCModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LetsRaid.Data
{
    public class LetsraidInitializer : DropCreateDatabaseIfModelChanges<LetsraidContext>
    {
        protected override void Seed(LetsraidContext context)
        {
            var dalaran = new Server()
            {
                ServerId = 1,
                Name = "Dalaran"
            };
            context.Servers.Add(dalaran);
            var illidan = new Server()
            {
                ServerId = 2,
                Name = "Illidan"
            };
            context.Servers.Add(illidan);
            var sargeras = new Server()
            {
                ServerId = 3,
                Name = "Sargeras"
            };
            context.Servers.Add(sargeras);
            var stormrage = new Server()
            {
                ServerId = 4,
                Name = "Stormrage"
            };
            context.Servers.Add(stormrage);
            var tichondrius = new Server()
            {
                ServerId = 5,
                Name = "Tichondrius"
            };
            context.Servers.Add(tichondrius);
            context.SaveChanges();



            // DALARAN GUILDS
            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 1,
                Name = "RUINOUS"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 2,
                ServerId = 1,
                Name = "OMNI DRIVE"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 3,
                ServerId = 1,
                Name = "Pensive"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 4,
                ServerId = 1,
                Name = "Shameless"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 5,
                ServerId = 1,
                Name = "The Secret Guild"
            });

            // Illidan GUILDS
            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 2,
                Name = "Best Friend Forever"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 2,
                ServerId = 2,
                Name = "Currently Offline"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 3,
                ServerId = 2,
                Name = "All In"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 4,
                ServerId = 2,
                Name = "Forstwolves"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 5,
                ServerId = 2,
                Name = "Warriors from Above"
            });

            // SARGERAS GUILDS
            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 3,
                Name = "SOULLES"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 2,
                ServerId = 3,
                Name = "Stevens Champs"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 3,
                ServerId = 3,
                Name = "The Last Page"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 4,
                ServerId = 3,
                Name = "Psychoactive"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 5,
                ServerId = 3,
                Name = "Pwnd"
            });

            // STORMRAGE GUILDS
            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 4,
                Name = "No Dice"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 2,
                ServerId = 4,
                Name = "Acerbity"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 3,
                ServerId = 4,
                Name = "Progression"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 4,
                ServerId = 4,
                Name = "Busy"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 5,
                ServerId = 4,
                Name = "MERCENARIES FOR AZEROTH"
            });

            // TICHONDRIUS GUILDS
            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 5,
                Name = "hey youre cute"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 2,
                ServerId = 5,
                Name = "The Horde Empire"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 3,
                ServerId = 5,
                Name = "Abolition"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 4,
                ServerId = 5,
                Name = "Ruin Gaming"
            });
            context.Guilds.Add(new Guild()
            {
                GuildId = 5,
                ServerId = 5,
                Name = "Booty Patrol"
            });
            context.SaveChanges();


            base.Seed(context);
        }
    }
}