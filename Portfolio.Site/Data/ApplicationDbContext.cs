using Microsoft.EntityFrameworkCore;

namespace Portfolio.Site.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{    
    public DbSet<Section> Sections { get; set; }    
    public DbSet<Site> Sites { get; set; }
    public DbSet<SectionItem> SectionItems { get; set; }
}
