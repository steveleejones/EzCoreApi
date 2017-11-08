public class Case
{
    public long id { get; set; }
    public long grp { get; set; }
    public string ident { get; set; }
    public string desc { get; set; }
    public DateTime? dateopen { get; set; }
    public DateTime? dateclosed { get; set; }
    public long openby { get; set; }
    public long? respers { get; set; }
    public DateTime? expclose { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
