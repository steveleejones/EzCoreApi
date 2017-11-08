public class GetVoucherItemRedeemedBreakdown
{
    public DateTime date { get; set; }
    public string fn { get; set; }
    public string productCode { get; set; }
    public decimal quantity { get; set; }
    public string Description { get; set; }
    public decimal? total { get; set; }
    public long? user { get; set; }
    public long? transaction { get; set; }
}
