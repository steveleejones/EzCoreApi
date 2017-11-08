public class BookableEntityStockRequirements
{
    public long id { get; set; }
    public long beid { get; set; }
    public long stk { get; set; }
    public decimal? reqses { get; set; }
    public decimal? reqhr { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
