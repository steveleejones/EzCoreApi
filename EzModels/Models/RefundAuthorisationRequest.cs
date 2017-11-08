public class RefundAuthorisationRequest
{
    public long id { get; set; }
    public long chg { get; set; }
    public long? newchg { get; set; }
    public decimal? refamnt { get; set; }
    public long arg { get; set; }
    public long sureq { get; set; }
    public long? suauth { get; set; }
    public byte stat { get; set; }
    public long? refrsn { get; set; }
    public string refdesc { get; set; }
    public long? ppi { get; set; }
    public DateTime? RequestDate { get; set; }
    public decimal totalprice { get; set; }
    public int quantity { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
