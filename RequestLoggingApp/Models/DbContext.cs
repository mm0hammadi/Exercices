using Microsoft.EntityFrameworkCore;
using RequestLoggingApp.Models;

namespace RequestLoggingApp.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<RequestLog> RequestLogs { get; set; }
}