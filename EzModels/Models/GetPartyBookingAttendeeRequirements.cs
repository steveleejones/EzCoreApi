public class GetPartyBookingAttendeeRequirements
{
    public long id { get; set; }
    public long pbaid { get; set; }
    public long abid { get; set; }
    public short req { get; set; }
    public short pbarseq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
