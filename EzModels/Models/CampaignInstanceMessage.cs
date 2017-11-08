public class CampaignInstanceMessage
{
    public long id { get; set; }
    public long campins { get; set; }
    public long? queue { get; set; }
    public long communication { get; set; }
    public string externalId { get; set; }
    public string externalgroup { get; set; }
    public string sendInfo { get; set; }
    public int? Sent { get; set; }
    public int? Opens { get; set; }
    public int? Clicks { get; set; }
    public int? Bounces { get; set; }
    public int? Forwards { get; set; }
    public int? OptOuts { get; set; }
    public int? SpamReports { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
