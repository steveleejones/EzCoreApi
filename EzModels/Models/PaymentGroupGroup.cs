public class PaymentGroupGroup
{
    public long paymentGroupGroupID { get; set; }
    public int showOrder { get; set; }
    public long parentGroup { get; set; }
    public long childGroup { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
