public class GetInvoicerunlog
{
    public long ID { get; set; }
    public long debitLog { get; set; }
    public long? chargeId { get; set; }
    public long? transactionId { get; set; }
    public long subId { get; set; }
    public long persid { get; set; }
    public string paytaxinv { get; set; }
    public DateTime? invdate { get; set; }
    public long? debtid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
