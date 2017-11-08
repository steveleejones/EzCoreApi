public class GetBookableEntityGroup
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public long? begimage { get; set; }
    public string altdesc { get; set; }
    public long bet { get; set; }
    public bool showmx { get; set; }
    public bool inccase { get; set; }
    public bool provtilpaid { get; set; }
    public long? intprof { get; set; }
    public long? tskresp { get; set; }
    public long? autoarbd { get; set; }
    public string bdoffset { get; set; }
    public long? autoarsd { get; set; }
    public string sdoffset { get; set; }
    public long? autoartu { get; set; }
    public string tuoffset { get; set; }
    public byte exbksty { get; set; }
    public byte promptpc { get; set; }
    public short seqno { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
