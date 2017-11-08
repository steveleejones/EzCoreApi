public class GetRefundableItems
{
    public long chargeid { get; set; }
    public decimal? totalprice { get; set; }
    public long? positemid { get; set; }
    public byte? refundtype { get; set; }
    public int? refqty { get; set; }
    public int? awaitingqty { get; set; }
    public int? prepaid { get; set; }
    public decimal credit { get; set; }
}
