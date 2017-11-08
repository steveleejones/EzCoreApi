public class ResourceGroup
{
    public long id { get; set; }
    public long site { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public short seqno { get; set; }
    public bool showm { get; set; }
    public short disslt { get; set; }
    public short slthei { get; set; }
    public short colwid { get; set; }
    public byte suppres { get; set; }
    public byte supptim { get; set; }
    public byte starthour { get; set; }
    public long? appear { get; set; }
    public long? rokqu { get; set; }
    public long? intprof { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
