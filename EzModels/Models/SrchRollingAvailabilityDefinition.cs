public class SrchRollingAvailabilityDefinition
{
    public long id { get; set; }
    public long? site { get; set; }
    public string site_desc { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public short repday { get; set; }
    public bool glob { get; set; }
    public long? app { get; set; }
    public int? app_fgcol { get; set; }
    public int? app_bgcol { get; set; }
    public int? app_bdcol { get; set; }
    public bool template { get; set; }
}
