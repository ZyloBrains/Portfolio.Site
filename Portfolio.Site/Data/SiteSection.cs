namespace Portfolio.Site.Data;

public class SiteSection
{
    public string SiteId { get; set; } = string.Empty;
    public int SectionId { get; set; }
    public int Order { get; set; }
    public bool Enabled { get; set; } = true;
}
