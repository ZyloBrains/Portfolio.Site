using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portfolio.Site.Data;

namespace Portfolio.Site.Pages;

public class IndexModel(ApplicationDbContext _db) : PageModel
{
    readonly ApplicationDbContext db = _db;

    public List<Section> SiteSections { get; set; } = [];

    public async Task OnGet()
    {
        SiteSections = await db.Sections
            .Where(x => x.Site != null && x.Site.Name == "ZyloBrains" && x.Enabled)
            .OrderBy(s => s.Order)
            .Include(z => z.Widgets)
            .ToListAsync() ?? [];
    }
}
