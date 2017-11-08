public class PackageGroup
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string webdesc { get; set; }
    public bool enablepg { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
