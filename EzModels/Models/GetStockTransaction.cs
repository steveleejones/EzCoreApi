public class GetStockTransaction
{
    public long id { get; set; }
    public long sisid { get; set; }
    public DateTime trdate { get; set; }
    public int quant { get; set; }
    public byte trtyp { get; set; }
    public string note { get; set; }
    public long? sttran { get; set; }
    public long? posch { get; set; }
    public long? stkrec { get; set; }
    public long? userid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
