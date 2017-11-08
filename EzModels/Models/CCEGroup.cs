public class CCEGroup
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public string http { get; set; }
    public byte ccetype { get; set; }
    public bool showmat { get; set; }
    public long? emapp { get; set; }
    public long app { get; set; }
    public long? fullapp { get; set; }
    public long? tskresp { get; set; }
    public byte promptpc { get; set; }
    public bool provtilpaid { get; set; }
    public long? actref { get; set; }
    public string waitsmstxt { get; set; }
    public short? wlnotifyoverride { get; set; }
    public short seqno { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
