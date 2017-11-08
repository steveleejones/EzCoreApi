public class KeyDetails
{
    public long id { get; set; }
    public string key { get; set; }
    public DateTime startdate { get; set; }
    public DateTime? enddate { get; set; }
    public byte usage { get; set; }
    public byte type { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
