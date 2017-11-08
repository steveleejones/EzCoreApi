public class TransactionReason
{
    public long id { get; set; }
    public long tran { get; set; }
    public long rsn { get; set; }
    public string rsntxt { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
