public class GetAccessControlLog
{
    public long id { get; set; }
    public long? loggrp { get; set; }
    public long? site { get; set; }
    public DateTime dateswipe { get; set; }
    public long? persid { get; set; }
    public long? ondevice { get; set; }
    public byte entstat { get; set; }
    public string dets { get; set; }
    public long? overreason { get; set; }
    public long? overuser { get; set; }
    public string note { get; set; }
    public bool nocard { get; set; }
    public bool inswipe { get; set; }
    public long? rvId { get; set; }
    public byte swipetype { get; set; }
    public string extdetails { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
