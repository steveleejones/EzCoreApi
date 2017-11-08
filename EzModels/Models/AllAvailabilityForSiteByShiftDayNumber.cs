public class AllAvailabilityForSiteByShiftDayNumber
{
    public long id { get; set; }
    public long? site { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public short repday { get; set; }
    public bool glob { get; set; }
    public bool enablerad { get; set; }
    public long? app { get; set; }
    public bool template { get; set; }
    public long? templateID { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
