public class GetTransactionAllocationPayments
{
    public long chargeid { get; set; }
    public string recno { get; set; }
    public string description { get; set; }
    public DateTime date { get; set; }
    public decimal? amnt { get; set; }
    public decimal? Alloc { get; set; }
    public decimal? bal { get; set; }
    public decimal Quantity { get; set; }
    public decimal unitprice { get; set; }
}
