public class GetAccessRightsGroup
{
    public long id { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public long? statapp { get; set; }
    public long? taskapp { get; set; }
    public byte acclev { get; set; }
    public byte memoffsl { get; set; }
    public bool allnl { get; set; }
    public long? viscli { get; set; }
    public long? rocli { get; set; }
    public byte tabone { get; set; }
    public byte tabtwo { get; set; }
    public byte tabthree { get; set; }
    public byte tabfour { get; set; }
    public byte tabfive { get; set; }
    public string starttab { get; set; }
    public string allowtab { get; set; }
    public long? subed { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
