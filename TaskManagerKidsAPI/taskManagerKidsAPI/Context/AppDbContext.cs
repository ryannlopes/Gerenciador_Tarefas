using Microsoft.EntityFrameworkCore;
using taskManagerKidsAPI.Models;

namespace taskManagerKidsAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    
    }

    public DbSet<Kid>? Kids { get; set; }
    public DbSet<Parent>? Parents { get; set; }
    public DbSet<taskManagerKidsAPI.Models.Task>? Tasks { get; set; }
}
