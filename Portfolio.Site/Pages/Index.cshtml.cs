using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portfolio.Site.Data;

namespace Portfolio.Site.Pages;

public class IndexModel(ApplicationDbContext _db) : PageModel
{
    readonly ApplicationDbContext db = _db;

    public List<Widget> Widgets { get; set; } = [];

    public async Task OnGet()
    {
        Widgets = await db.Widgets.ToListAsync();
    }
}
