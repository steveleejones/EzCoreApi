public class GetCampaignNotification
{
    public long id { get; set; }
    public long campaignid { get; set; }
    public string campaignname { get; set; }
    public long campinstid { get; set; }
    public DateTime dateocc { get; set; }
    public byte nottype { get; set; }
    public long persid { get; set; }
    public string messagename { get; set; }
    public string listname { get; set; }
    public string ClickUrl { get; set; }
    public DateTime? EventDate { get; set; }
    public DateTime? InstanceStartDate { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
    public string ClientOs { get; set; }
    public string ClientDeviceType { get; set; }
    public string ClientName { get; set; }
    public string ClientType { get; set; }
    public string ClientUserAgent { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
