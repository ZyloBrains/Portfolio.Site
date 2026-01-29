using Microsoft.EntityFrameworkCore;

namespace Portfolio.Site.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{    
    public DbSet<Widget> Widgets { get; set; }
    public DbSet<Section> Sections { get; set; }    
    public DbSet<Site> Sites { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<SiteSection> SiteSections { get; set; }
    public DbSet<SectionWidget> SectionWidgets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Site>()
        .HasMany(e => e.Sections)
        .WithMany()
        .UsingEntity<SiteSection>();

        builder.Entity<Section>()
        .HasMany(e => e.Widgets)
        .WithMany()
        .UsingEntity<SectionWidget>();
    }
}
