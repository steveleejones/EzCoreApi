public class SearchReasonsByType
{
    public long id { get; set; }
    public string Description { get; set; }
    public short? seq { get; set; }
    public bool fnot { get; set; }
    public byte rType { get; set; }
    public bool active { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
