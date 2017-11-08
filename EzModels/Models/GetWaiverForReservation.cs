public class GetWaiverForReservation
{
    public long id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public short ValidityDays { get; set; }
    public short MinimumAcceptanceAge { get; set; }
    public string Content { get; set; }
    public long? intprof { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
