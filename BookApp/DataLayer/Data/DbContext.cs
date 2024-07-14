namespace BookApp.DataLayer.Data;

public class AppDbContext : DbContext 
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<PriceOffer> PriceOffers { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=.;Database=BookAppDb;User Id=sa;Password=P@ssw0rd";
        optionsBuilder.UseSqlServer(connectionString);
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    
}