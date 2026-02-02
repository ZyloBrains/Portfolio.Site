namespace Portfolio.Site.Data;
public class Section
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }
    public int Order { get; set; }
    public bool Enabled { get; set; } = true;

    public string? SiteId { get; set; }
    public Site? Site { get; set; }

    public List<Widget>? Widgets { get; set; }
}
