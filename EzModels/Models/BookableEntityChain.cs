public class BookableEntityChain
{
    public long id { get; set; }
    public long grp { get; set; }
    public long? primebe { get; set; }
    public long? seconbe { get; set; }
    public bool ismanual { get; set; }
    public byte gaprelto { get; set; }
    public int stndgap { get; set; }
    public int mingap { get; set; }
    public int maxgap { get; set; }
    public int gapincrmnts { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
