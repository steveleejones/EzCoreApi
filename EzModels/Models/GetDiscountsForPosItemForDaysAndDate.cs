public class GetDiscountsForPosItemForDaysAndDate
{
    public long DiscountID { get; set; }
    public string mnem { get; set; }
    public string Description { get; set; }
    public string discCode { get; set; }
    public string rectext { get; set; }
    public bool IsPercentage { get; set; }
    public bool ReqMem { get; set; }
    public decimal Amount { get; set; }
    public bool adhoc { get; set; }
    public bool requiresreason { get; set; }
    public bool reason { get; set; }
    public DateTime? stdate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public long? tzon { get; set; }
    public long? dtrng { get; set; }
    public int? totNumDiscs { get; set; }
    public int? remNumDiscs { get; set; }
    public int? showOrder { get; set; }
    public bool DiscountAll { get; set; }
    public bool StaffDiscount { get; set; }
    public short? mindays { get; set; }
    public short? maxdays { get; set; }
    public byte DiscountType { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
