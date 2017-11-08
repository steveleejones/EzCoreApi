public class GetServiceCharges
{
    public long id { get; set; }
    public string description { get; set; }
    public short amnt { get; set; }
    public bool ispercentage { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
