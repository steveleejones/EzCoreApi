public class TransactionDetail
{
    public long id { get; set; }
    public long? chgid { get; set; }
    public long? prevchg { get; set; }
    public int? qty { get; set; }
    public byte? RefundType { get; set; }
    public long? refrsn { get; set; }
    public string refdesc { get; set; }
    public long? DiscountType { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
