using LetsRaid.Data.Maps;
using LetsRaid.Domain.Models;
using LetsRaid.Domain.MVCModels;
using System.Data.Entity;

namespace LetsRaid.Data
{
    public class LetsraidContext : DbContext
    {
        public LetsraidContext() : base("Letsraid")
        {
            Database.SetInitializer(new LetsraidInitializer());
        }

        public DbSet<Server> Servers { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Raid> Raids { get; set; }
        public DbSet<Boss> Bosses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                    .HasMany<Raid>(x => x.Raids)
                    .WithMany(x => x.Characters)
                    .Map(x =>
                    {
                        x.MapLeftKey("CharacterID");
                        x.MapRightKey("RaidId");
                        x.ToTable("RaidCharacters");
                    });

            modelBuilder.Configurations.Add(new ServerMap());
            modelBuilder.Configurations.Add(new GuildMap());
            modelBuilder.Configurations.Add(new CharacterMap());
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
