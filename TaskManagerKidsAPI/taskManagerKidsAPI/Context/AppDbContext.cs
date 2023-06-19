using Microsoft.EntityFrameworkCore;
using taskManagerKidsAPI.Models;
using Task = taskManagerKidsAPI.Models.Task;

namespace taskManagerKidsAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    
    }

    public DbSet<Kid>? Kids { get; set; }
    public DbSet<Parent>? Parents { get; set; }
    public DbSet<Task>? Tasks { get; set; }
    public DbSet<Reward>? Rewards { get; set; }
}
