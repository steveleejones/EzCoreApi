public class GetStockTransferList
{
    public long id { get; set; }
    public long fromsite { get; set; }
    public long tosite { get; set; }
    public DateTime? dateraised { get; set; }
    public DateTime? datesent { get; set; }
    public DateTime? datereceived { get; set; }
    public long? raisedby { get; set; }
    public long? sentby { get; set; }
    public long? receivedby { get; set; }
    public byte state { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
