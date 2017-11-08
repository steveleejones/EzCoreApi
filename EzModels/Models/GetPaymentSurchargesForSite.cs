public class GetPaymentSurchargesForSite
{
    public long ID { get; set; }
    public string Description { get; set; }
    public string Message { get; set; }
    public long positem { get; set; }
    public bool IsPercentage { get; set; }
    public decimal Amount { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
