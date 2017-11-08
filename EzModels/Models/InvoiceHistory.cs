public class InvoiceHistory
{
    public int type { get; set; }
    public long id { get; set; }
    public long? primarysub { get; set; }
    public long chargeid { get; set; }
    public decimal? totalPrice { get; set; }
    public long? persid { get; set; }
    public string acnm { get; set; }
    public long? acnt { get; set; }
    public string acnum { get; set; }
    public long siteId { get; set; }
    public string siteDesc { get; set; }
    public string payer { get; set; }
    public string payer2 { get; set; }
    public string applies { get; set; }
    public string applies2 { get; set; }
    public string accDesc { get; set; }
    public string remnum { get; set; }
    public string acsc { get; set; }
    public string ddrcolcod { get; set; }
    public string ddid { get; set; }
    public long sdId { get; set; }
    public string sdDesc { get; set; }
    public long? payitem { get; set; }
    public long? itemid { get; set; }
    public long? curr { get; set; }
    public decimal? loycred { get; set; }
    public string description { get; set; }
}
