public class ARUDDLogLine
{
    public long ID { get; set; }
    public long? AruddLog { get; set; }
    public long? debitLog { get; set; }
    public long? CreditID { get; set; }
    public long? chgid { get; set; }
    public long? tranid { get; set; }
    public decimal amt { get; set; }
    public byte type { get; set; }
    public DateTime? date { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
