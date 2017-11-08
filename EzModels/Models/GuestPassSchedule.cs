public class GuestPassSchedule
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public short initquantity { get; set; }
    public short periodicquantity { get; set; }
    public short? periodicmonths { get; set; }
    public short? validformonths { get; set; }
    public bool active { get; set; }
    public DateTime? lastchecked { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
