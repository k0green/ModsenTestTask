using Microsoft.EntityFrameworkCore;
using ModsenTestTask.Data.Entities;

namespace ModsenTestTask.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Event> Events { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}