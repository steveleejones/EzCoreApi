public class GetWaitingListLineBe
{
    public long id { get; set; }
    public long wlid { get; set; }
    public long abid { get; set; }
    public short minreq { get; set; }
    public short maxreq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
