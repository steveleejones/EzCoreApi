public class CancellationReasons
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public byte whocnc { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
