public class MembershipProfile
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public long? intprf { get; set; }
    public bool suppress { get; set; }
    public bool fpmainscr { get; set; }
    public long? mandcli { get; set; }
    public long? viscli { get; set; }
    public long? defbr { get; set; }
    public long? defmemstat { get; set; }
    public string userdef1 { get; set; }
    public string userdef2 { get; set; }
    public string userdef3 { get; set; }
    public string userdef4 { get; set; }
    public long? autoarnew { get; set; }
    public short seqno { get; set; }
    public long? mandem { get; set; }
    public long? visem { get; set; }
    public bool oversubstat { get; set; }
    public long? mandCheckIn { get; set; }
    public long? visCheckIn { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
