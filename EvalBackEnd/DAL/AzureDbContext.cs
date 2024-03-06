using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AzureDbContext : DbContext
{

    public AzureDbContext(DbContextOptions<AzureDbContext> option) : base(option)
    {
        
    }

    public DbSet<Event> Events { get; set; }
}
