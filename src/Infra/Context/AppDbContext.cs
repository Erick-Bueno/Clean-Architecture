using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    
    public  AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
