public class TransactionTransfer
{
    public long id { get; set; }
    public long prevtran { get; set; }
    public long newtran { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
