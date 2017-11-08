public class UserMessage
{
    public long id { get; set; }
    public long from { get; set; }
    public bool sticky { get; set; }
    public DateTime? datsent { get; set; }
    public DateTime? ststart { get; set; }
    public DateTime? stend { get; set; }
    public string subj { get; set; }
    public string mess { get; set; }
    public byte? fntsiz { get; set; }
    public byte impo { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
