public class DirectDebitLog
{
    public long ID { get; set; }
    public long SystemUser { get; set; }
    public DateTime RunDate { get; set; }
    public long debitGroup { get; set; }
    public string OutputFile { get; set; }
    public byte? Action { get; set; }
    public byte? Status { get; set; }
    public string ref { get; set; }
    public string fileref { get; set; }
    public DateTime? ChargeDate { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
