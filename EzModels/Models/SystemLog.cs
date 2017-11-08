public class SystemLog
{
    public long id { get; set; }
    public DateTime date { get; set; }
    public string Message { get; set; }
    public string Tag { get; set; }
    public byte LogType { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
