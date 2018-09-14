namespace LetsRaid.DAL
{
    using LetsRaid.DAL.Maps;
    using LetsRaid.Models;
    using LetsRaid.Models.GuildModels;
    using LetsRaid.Models.ServerModels;
    using System.Data.Entity;

    public class LetsraidContext : DbContext
    {
        public LetsraidContext() : base("Letsraid")
        {
            Database.SetInitializer(new LetsraidInitializer());
        }


        public DbSet<Server> Servers { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<DBCharacter> DBCharacters { get; set; }
        public DbSet<Raid> Raids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raid>()
                .HasMany(x => x.DBCharacters)
                .WithMany(x => x.Raids)
                .Map(x =>
                {
                    x.MapLeftKey("RaidId")
                    .MapRightKey("DBCharacterId")
                    .ToTable("RaidCharacters");
                });

            modelBuilder.Configurations.Add(new ServerMap());
            modelBuilder.Configurations.Add(new GuildMap());
            modelBuilder.Configurations.Add(new CharacterMap());
            modelBuilder.Configurations.Add(new DBCharacterMap());
            modelBuilder.Configurations.Add(new RaidMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}