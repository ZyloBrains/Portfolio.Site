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
        var site = await db.Sites.Where(x => x.Name == "ZyloBrains")
                            .Include(y => y.Sections)
                            .ThenInclude(z => z.Widgets)
                            .FirstOrDefaultAsync();

        SiteSections = site?.Sections ?? [];
    }
}
