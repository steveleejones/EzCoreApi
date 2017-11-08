public class CampaignDelivery
{
    public long id { get; set; }
    public long campaignid { get; set; }
    public string campaignname { get; set; }
    public long campinstid { get; set; }
    public DateTime datestarted { get; set; }
    public DateTime dateended { get; set; }
    public int? mesagessent { get; set; }
    public string messagename { get; set; }
    public string commname { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
