public class TransactionPaymentRatio
{
    public long id { get; set; }
    public long transid { get; set; }
    public decimal? rat { get; set; }
    public long payid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
