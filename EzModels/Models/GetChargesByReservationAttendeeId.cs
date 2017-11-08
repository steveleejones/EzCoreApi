public class GetChargesByReservationAttendeeId
{
    public decimal? Outstanding { get; set; }
    public decimal? Paid { get; set; }
    public long chargeID { get; set; }
    public long? site { get; set; }
    public long? persid { get; set; }
    public long? apppers { get; set; }
    public long? paidpers { get; set; }
    public string productCode { get; set; }
    public string description { get; set; }
    public string detdesc { get; set; }
    public long? CommID { get; set; }
    public long? curr { get; set; }
    public decimal? inipri { get; set; }
    public decimal unitPrice { get; set; }
    public decimal? packPri { get; set; }
    public decimal? totalPrice { get; set; }
    public long? DiscountID { get; set; }
    public bool? IsDiscountPercentage { get; set; }
    public decimal? Discount { get; set; }
    public int? NumDiscount { get; set; }
    public decimal DiscountTotal { get; set; }
    public long? transaction { get; set; }
    public decimal quantity { get; set; }
    public long? PettyCashReason { get; set; }
    public bool voucherSelect { get; set; }
    public bool refundSelect { get; set; }
    public decimal? vatAmount { get; set; }
    public string nlCode { get; set; }
    public string AuthCode { get; set; }
    public string ccref { get; set; }
    public decimal? loydeb { get; set; }
    public decimal? loycred { get; set; }
    public long? LoyaltyTrans { get; set; }
    public string recieptText { get; set; }
    public long? voucherID { get; set; }
    public long? vitem { get; set; }
    public long? restranmem { get; set; }
    public byte? packinfo { get; set; }
    public long? packtran { get; set; }
    public long? packageID { get; set; }
    public long? itemID { get; set; }
    public long? payItemID { get; set; }
    public string paytaxinv { get; set; }
    public DateTime date { get; set; }
    public DateTime? datapp { get; set; }
    public DateTime? datdue { get; set; }
    public DateTime? datpaid { get; set; }
    public byte stat { get; set; }
    public byte paymeth { get; set; }
    public long? acnt { get; set; }
    public long? tillPeriod { get; set; }
    public long? user { get; set; }
    public long? ppAmountID { get; set; }
    public long? att { get; set; }
    public long? ssub { get; set; }
    public long? subs { get; set; }
    public long? partyatt { get; set; }
    public byte? ChargeItemType { get; set; }
    public long? remtrans { get; set; }
    public long? linkchg { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
    public decimal? QtyRefunded { get; set; }
    public decimal? AmtRefunded { get; set; }
}
