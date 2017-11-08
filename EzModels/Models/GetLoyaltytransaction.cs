public class GetLoyaltytransaction
{
    public long loyaltyTransactionID { get; set; }
    public decimal points { get; set; }
    public long headmem { get; set; }
    public long memberID { get; set; }
    public long? positem { get; set; }
    public long? LoyaltyCode { get; set; }
    public string Description { get; set; }
    public DateTime transactionDate { get; set; }
    public DateTime? expdate { get; set; }
    public byte? stat { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
