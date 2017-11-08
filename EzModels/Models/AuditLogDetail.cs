public class AuditLogDetail
{
    public long id { get; set; }
    public long audlog { get; set; }
    public string chfld { get; set; }
    public string preval { get; set; }
    public string newval { get; set; }
    public string prevalex { get; set; }
    public string newvalex { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
