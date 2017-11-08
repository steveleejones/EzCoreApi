public class GetMembershipOfferingGroup
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public short MinAge { get; set; }
    public short MaxAge { get; set; }
    public long? visquery { get; set; }
    public bool webgrp { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
