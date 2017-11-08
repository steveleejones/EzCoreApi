public class GetPrepaymentitemsHistory
{
    public long id { get; set; }
    public long? ppid { get; set; }
    public long? sysid { get; set; }
    public short? statfrom { get; set; }
    public short? statto { get; set; }
    public DateTime? expfrom { get; set; }
    public DateTime? expto { get; set; }
    public string rsn { get; set; }
    public long ReasonID { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
