public class ChargeLayInLog
{
    public long ID { get; set; }
    public long debitLog { get; set; }
    public long? chargeId { get; set; }
    public long subId { get; set; }
    public DateTime? prevdate { get; set; }
    public DateTime? nxdate { get; set; }
    public DateTime? findate { get; set; }
    public decimal? ovrdam { get; set; }
    public decimal? ovrdnx { get; set; }
    public long? packtrans { get; set; }
    public long? prepayment { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
