public class GetCommunicationProfile
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public bool allsnl { get; set; }
    public bool alleml { get; set; }
    public bool allsms { get; set; }
    public bool allmm { get; set; }
    public bool allpho { get; set; }
    public bool alloth { get; set; }
    public short seq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
