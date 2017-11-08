public class GetAvailableTableDetailsForRoom
{
    public string description { get; set; }
    public long TableId { get; set; }
    public short capacity { get; set; }
    public bool requriesbooking { get; set; }
    public DateTime? stdate { get; set; }
    public long? rvid { get; set; }
    public DateTime? endate { get; set; }
    public string note { get; set; }
    public short? bookatt { get; set; }
    public long? raid { get; set; }
    public long? persid { get; set; }
    public int maxcourse { get; set; }
}
