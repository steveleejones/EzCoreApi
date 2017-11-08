public class GetAuditLog
{
    public long id { get; set; }
    public long user { get; set; }
    public long? persid { get; set; }
    public DateTime dat { get; set; }
    public long? mainid { get; set; }
    public string class { get; set; }
    public byte updtyp { get; set; }
    public string dets { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
