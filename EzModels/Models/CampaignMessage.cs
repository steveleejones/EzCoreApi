public class CampaignMessage
{
    public long id { get; set; }
    public string Description { get; set; }
    public string campaignMessage { get; set; }
    public byte messagetype { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
