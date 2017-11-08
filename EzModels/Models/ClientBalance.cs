public class ClientBalance
{
    public decimal? Balance { get; set; }
    public decimal? Outstanding { get; set; }
    public decimal? NotYetDue { get; set; }
    public long? debtstat { get; set; }
    public string debtdesc { get; set; }
    public decimal? credit { get; set; }
    public decimal? PrePayment { get; set; }
}
