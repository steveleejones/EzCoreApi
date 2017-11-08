public class AccessControlStatusLog
{
    public long id { get; set; }
    public long acdev { get; set; }
    public DateTime evdate { get; set; }
    public byte evtyp { get; set; }
    public long? reas { get; set; }
    public long? userid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
