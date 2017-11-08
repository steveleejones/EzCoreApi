public class GetMembershipStatus
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public bool allowent { get; set; }
    public short seqno { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
