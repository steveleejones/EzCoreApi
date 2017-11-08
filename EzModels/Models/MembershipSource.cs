public class MembershipSource
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public bool grpwid { get; set; }
    public short seqno { get; set; }
    public bool isactive { get; set; }
    public string remid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
