public class GetSessionQuota
{
    public long id { get; set; }
    public long sessionid { get; set; }
    public DateTime startdate { get; set; }
    public DateTime? enddate { get; set; }
    public int? quota { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
