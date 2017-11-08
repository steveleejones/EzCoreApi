public class WristbandScheduleInterval
{
    public long id { get; set; }
    public long WristbandScheduleId { get; set; }
    public int? StartTime { get; set; }
    public int? EndTime { get; set; }
    public long? Appearance { get; set; }
    public string description { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
