public class GetCurrencyRates
{
    public long id { get; set; }
    public long? cprd { get; set; }
    public long cfrom { get; set; }
    public long cto { get; set; }
    public decimal rate { get; set; }
    public byte stat { get; set; }
    public DateTime date { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
