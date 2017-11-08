public class Table
{
    public long id { get; set; }
    public string description { get; set; }
    public long room { get; set; }
    public short capacity { get; set; }
    public bool requriesbooking { get; set; }
    public byte tabletype { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
