public class PrePaymentItems
{
    public long ID { get; set; }
    public string Desc { get; set; }
    public long MemID { get; set; }
    public long? PosItem { get; set; }
    public long? PaidID { get; set; }
    public long? packid { get; set; }
    public decimal Amnt { get; set; }
    public decimal? calcamnt { get; set; }
    public long? AttendeeID { get; set; }
    public long? SubsID { get; set; }
    public DateTime? dtBooking { get; set; }
    public DateTime? dtRedeemed { get; set; }
    public DateTime? stdat { get; set; }
    public DateTime? exp { get; set; }
    public long? tillPeriod { get; set; }
    public byte typ { get; set; }
    public byte src { get; set; }
    public byte stat { get; set; }
    public string RemoteID { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
