using Microsoft.EntityFrameworkCore;

namespace RequestLoggingApp.Models;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

    public DbSet<RequestLog> RequestLogs { get; set; }
}