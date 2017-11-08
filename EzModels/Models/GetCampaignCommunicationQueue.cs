public class GetCampaignCommunicationQueue
{
    public long id { get; set; }
    public long? campaign { get; set; }
    public string desc { get; set; }
    public string communicationname { get; set; }
    public short? sendday { get; set; }
    public short? sendtime { get; set; }
    public long? primarycomm { get; set; }
    public long? secondarycomm { get; set; }
    public long? teritarycomm { get; set; }
    public bool sendonsuccess { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
