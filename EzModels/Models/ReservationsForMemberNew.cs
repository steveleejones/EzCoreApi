public class ReservationsForMemberNew
{
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public long rvid { get; set; }
    public string cocdesc { get; set; }
    public string bedesc { get; set; }
    public string ccedesc { get; set; }
    public int? crdesc { get; set; }
    public byte paidstat { get; set; }
    public byte stat { get; set; }
    public long? tran { get; set; }
    public long raid { get; set; }
    public string resline { get; set; }
    public long? cncdet { get; set; }
    public long? cdet { get; set; }
    public string username { get; set; }
    public string fnsn { get; set; }
}
