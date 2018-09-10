namespace LetsRaid.DAL
{
    using LetsRaid.DAL.Maps;
    using LetsRaid.Models.GuildModels;
    using LetsRaid.Models.ServerModels;
    using System.Data.Entity;

    public class LetsraidContext : DbContext
    {
        // Your context has been configured to use a 'Letsraid' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LetsRaid.DAL.Letsraid' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Letsraid' 
        // connection string in the application configuration file.
        public LetsraidContext()
            : base("name=Letsraid")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Server> Servers { get; set; }
        public DbSet<Guild> Guilds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServerMap());
            modelBuilder.Configurations.Add(new GuildMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}