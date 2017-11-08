public class ClientCaseAuthorisation
{
    public long id { get; set; }
    public long clicas { get; set; }
    public string desc { get; set; }
    public DateTime dateopen { get; set; }
    public DateTime? authdate { get; set; }
    public DateTime? decdate { get; set; }
    public string autref { get; set; }
    public long prov { get; set; }
    public long acreby { get; set; }
    public byte castat { get; set; }
    public string notes { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
