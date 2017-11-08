public class BookableEntityRequirements
{
    public long id { get; set; }
    public long beid { get; set; }
    public long abid { get; set; }
    public bool cres { get; set; }
    public bool adjres { get; set; }
    public bool mand { get; set; }
    public short reqpr { get; set; }
    public bool disp { get; set; }
    public short minreq { get; set; }
    public short maxreq { get; set; }
    public short usureq { get; set; }
    public short beseq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
