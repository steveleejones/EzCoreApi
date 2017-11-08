public class TransactionSessionConfiguration
{
    public long id { get; set; }
    public string description { get; set; }
    public string mnem { get; set; }
    public int strtnum { get; set; }
    public int current { get; set; }
    public long? site { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
