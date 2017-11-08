public class GetExternalServicesUsage
{
    public long Id { get; set; }
    public byte ServiceType { get; set; }
    public string Parameters { get; set; }
    public long? SystemUser { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
