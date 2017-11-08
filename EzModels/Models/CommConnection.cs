public class CommConnection
{
    public long id { get; set; }
    public string desc { get; set; }
    public string port { get; set; }
    public byte? par { get; set; }
    public byte? stop { get; set; }
    public byte? baud { get; set; }
    public byte? dbits { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
