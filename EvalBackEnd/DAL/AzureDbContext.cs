using Entities;
using Microsoft.EntityFrameworkCore;


namespace DAL;

public class AzureDbContext : DbContext
{

    public AzureDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Event> Events { get; set; }
}
