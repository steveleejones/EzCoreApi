public class MembershipOffering
{
    public long id { get; set; }
    public long grp { get; set; }
    public long offgrp { get; set; }
    public string desc { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public long? memprf { get; set; }
    public bool lockprf { get; set; }
    public long? intprof { get; set; }
    public byte seclev { get; set; }
    public long? reqatg { get; set; }
    public bool active { get; set; }
    public bool weboff { get; set; }
    public bool reqpromo { get; set; }
    public bool IgnoreClient { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
