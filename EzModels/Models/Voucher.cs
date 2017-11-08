public class Voucher
{
    public long voucherID { get; set; }
    public string desc { get; set; }
    public string serialNumber { get; set; }
    public string serialOld { get; set; }
    public string pin { get; set; }
    public DateTime? validFrom { get; set; }
    public DateTime? expiryDate { get; set; }
    public DateTime dateSold { get; set; }
    public long? memID { get; set; }
    public long? ToID { get; set; }
    public string msg { get; set; }
    public DateTime? redeemed { get; set; }
    public decimal amount { get; set; }
    public long? Vendor { get; set; }
    public byte VoucherType { get; set; }
    public byte? stat { get; set; }
    public DateTime? evoucherSent { get; set; }
    public long? deliToId { get; set; }
    public long? deliMethPosItemId { get; set; }
    public long? sessionid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
