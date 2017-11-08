public class GetCampaignCommunicationItem
{
    public long id { get; set; }
    public string text { get; set; }
    public long? CampaignMessage { get; set; }
    public byte messagetype { get; set; }
    public long? actionreference { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
