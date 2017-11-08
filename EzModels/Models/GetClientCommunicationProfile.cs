public class GetClientCommunicationProfile
{
    public long id { get; set; }
    public long persid { get; set; }
    public long comprf { get; set; }
    public bool contsnl { get; set; }
    public bool conteml { get; set; }
    public bool contsms { get; set; }
    public bool contmm { get; set; }
    public bool contpho { get; set; }
    public bool contoth { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
