namespace Portfolio.Site.Data;
public class Section
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Content { get; set; }

    public List<Widget>? Widgets { get; set; }
}
