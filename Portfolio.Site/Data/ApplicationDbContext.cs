using Microsoft.EntityFrameworkCore;

namespace Portfolio.Site.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{    
    public DbSet<Widget> Widgets { get; set; }
    public DbSet<Tag> Tags { get; set; }    
}
