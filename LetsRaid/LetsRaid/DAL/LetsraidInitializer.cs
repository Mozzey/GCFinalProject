using LetsRaid.Models.GuildModels;
using LetsRaid.Models.ServerModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LetsRaid.DAL
{
    public class LetsraidInitializer : DropCreateDatabaseAlways<LetsraidContext>
    {
        protected override void Seed(LetsraidContext context)
        {
            //var dalaran = new Server()
            //{
            //    Id = 1,
            //    Name = "Dalaran"
            //};
            //context.Servers.Add(dalaran);
            //var illidan = new Server()
            //{
            //    Id = 2,
            //    Name = "Illidan"
            //};
            //context.Servers.Add(illidan);
            //var sargeras = new Server()
            //{
            //    Id = 3,
            //    Name = "Sargeras"
            //};
            //context.Servers.Add(sargeras);
            //var stormrage = new Server()
            //{
            //    Id = 4,
            //    Name = "Stormrage"
            //};
            //context.Servers.Add(stormrage);
            //var tichondrius = new Server()
            //{
            //    Id = 5,
            //    Name = "Tichondrius"
            //};
            context.Servers.Add(new Server()
            {
                ServerId = 1,
                Name = "Dalaran"
            });
            context.SaveChanges();

            context.Guilds.Add(new Guild()
            {
                GuildId = 1,
                ServerId = 1,
                Name = "RUINOUS"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}