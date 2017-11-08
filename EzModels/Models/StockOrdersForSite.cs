public class StockOrdersForSite
{
    public long id { get; set; }
    public DateTime? sentdat { get; set; }
    public DateTime? expdat { get; set; }
    public DateTime? chdat { get; set; }
    public DateTime? datrec { get; set; }
    public byte stat { get; set; }
    public string supdesc { get; set; }
    public string status { get; set; }
    public string emailed { get; set; }
    public string printed { get; set; }
    public DateTime datcre { get; set; }
    public int numitem { get; set; }
    public int numrec { get; set; }
    public string ordertype { get; set; }
}
