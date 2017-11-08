public class SitesForUser
{
    public long id { get; set; }
    public long siteid { get; set; }
    public string desc { get; set; }
    public string mnem { get; set; }
    public string extsit { get; set; }
    public long? grp { get; set; }
    public long? sitevwhen { get; set; }
    public long? mxview { get; set; }
    public bool disabled { get; set; }
    public short prord { get; set; }
}
