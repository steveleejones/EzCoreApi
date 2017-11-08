public class GetStockOrder
{
    public long id { get; set; }
    public long site { get; set; }
    public long supid { get; set; }
    public DateTime datcre { get; set; }
    public byte stat { get; set; }
    public DateTime? sentdat { get; set; }
    public DateTime? expdat { get; set; }
    public DateTime? chdat { get; set; }
    public DateTime? datrec { get; set; }
    public string note { get; set; }
    public string receivenote { get; set; }
    public string extref { get; set; }
    public byte ordertype { get; set; }
    public bool emailed { get; set; }
    public bool printed { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
