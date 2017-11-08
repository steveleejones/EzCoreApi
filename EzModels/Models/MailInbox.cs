public class MailInbox
{
    public long recid { get; set; }
    public long usmes { get; set; }
    public byte stat { get; set; }
    public string statdesc { get; set; }
    public string username { get; set; }
    public bool sticky { get; set; }
    public DateTime? datsent { get; set; }
    public DateTime? ststart { get; set; }
    public DateTime? stend { get; set; }
    public string subj { get; set; }
}
