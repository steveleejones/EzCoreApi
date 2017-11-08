public class CCEStockRequirements
{
    public long id { get; set; }
    public long cceid { get; set; }
    public long stk { get; set; }
    public decimal? reqses { get; set; }
    public decimal? reqatt { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
