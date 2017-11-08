public class GetStockItemSupplier
{
    public long id { get; set; }
    public long stit { get; set; }
    public long stsup { get; set; }
    public DateTime? stdate { get; set; }
    public DateTime? endate { get; set; }
    public decimal stkunq { get; set; }
    public decimal cost { get; set; }
    public decimal? cost2 { get; set; }
    public string supref { get; set; }
    public bool enabled { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
