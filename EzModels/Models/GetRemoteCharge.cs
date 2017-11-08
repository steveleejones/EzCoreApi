public class GetRemoteCharge
{
    public long id { get; set; }
    public long remtrans { get; set; }
    public string desc { get; set; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
