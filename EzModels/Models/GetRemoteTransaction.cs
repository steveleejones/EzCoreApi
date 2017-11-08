public class GetRemoteTransaction
{
    public long id { get; set; }
    public DateTime trdate { get; set; }
    public string recnum { get; set; }
    public bool rfnd { get; set; }
    public string tillref { get; set; }
    public decimal totalPrice { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
