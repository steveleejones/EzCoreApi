public class GetStockTransfers
{
    public long id { get; set; }
    public long fromsite { get; set; }
    public string fromsitename { get; set; }
    public long tosite { get; set; }
    public string tositename { get; set; }
    public DateTime? dateraised { get; set; }
    public string desc { get; set; }
    public byte state { get; set; }
    public int? items { get; set; }
}
