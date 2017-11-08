public class GetAccountCreditsForPerson
{
    public long id { get; set; }
    public long chargeid { get; set; }
    public long persid { get; set; }
    public DateTime date { get; set; }
    public decimal Amount { get; set; }
    public decimal Allocated { get; set; }
    public byte Type { get; set; }
    public string CreditDesc { get; set; }
}
