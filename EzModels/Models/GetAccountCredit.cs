public class GetAccountCredit
{
    public long ID { get; set; }
    public long chargeID { get; set; }
    public decimal Amount { get; set; }
    public decimal Allocated { get; set; }
    public byte Type { get; set; }
    public long Persid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
