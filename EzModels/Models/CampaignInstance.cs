public class CampaignInstance
{
    public long id { get; set; }
    public long camp { get; set; }
    public DateTime ondate { get; set; }
    public byte stat { get; set; }
    public bool flwtskcmp { get; set; }
    public int? NumRecipients { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
