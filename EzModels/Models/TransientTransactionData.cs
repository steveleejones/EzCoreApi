public class TransientTransactionData
{
    public long id { get; set; }
    public int transactionId { get; set; }
    public int personId { get; set; }
    public byte status { get; set; }
    public DateTime? lockedTime { get; set; }
    public string errorReason { get; set; }
    public string objectType { get; set; }
    public string objectData { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
