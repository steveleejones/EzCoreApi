public class StickySiteNote
{
    public long id { get; set; }
    public long site { get; set; }
    public string desc { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public long addby { get; set; }
    public DateTime datadd { get; set; }
    public long app { get; set; }
    public short seqno { get; set; }
    public short relwid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
