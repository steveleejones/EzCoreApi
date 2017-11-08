public class DailyResourceNote
{
    public long id { get; set; }
    public long resourceid { get; set; }
    public DateTime ondate { get; set; }
    public string note { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
