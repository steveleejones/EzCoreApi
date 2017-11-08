public class GetCampaignMessageImage
{
    public long id { get; set; }
    public string Name { get; set; }
    public long CampaignMessage { get; set; }
    public byte[] imagedata { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
