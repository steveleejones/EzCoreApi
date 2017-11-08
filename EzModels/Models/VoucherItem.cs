public class VoucherItem
{
    public long VoucherItemID { get; set; }
    public long? PosItemID { get; set; }
    public decimal? amnt { get; set; }
    public long VoucherID { get; set; }
    public long? packid { get; set; }
    public DateTime DateSold { get; set; }
    public DateTime? RedeemedDate { get; set; }
    public long? TilRedeemed { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
