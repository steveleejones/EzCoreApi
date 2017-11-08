public class GetCurrency
{
    public long id { get; set; }
    public string desc { get; set; }
    public string mnem { get; set; }
    public string symb { get; set; }
    public bool recdisp { get; set; }
    public bool home { get; set; }
    public string format { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
