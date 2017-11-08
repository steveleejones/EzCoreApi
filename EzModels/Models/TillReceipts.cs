public class TillReceipts
{
    public long id { get; set; }
    public long till { get; set; }
    public int seq { get; set; }
    public bool prv { get; set; }
    public long pntr { get; set; }
    public long rkrec { get; set; }
    public long? trannum { get; set; }
    public byte typ { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
