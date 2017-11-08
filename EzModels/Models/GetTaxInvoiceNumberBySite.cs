public class GetTaxInvoiceNumberBySite
{
    public long id { get; set; }
    public string desc { get; set; }
    public string mnem { get; set; }
    public DateTime stDate { get; set; }
    public DateTime resDate { get; set; }
    public long stnum { get; set; }
    public long cnum { get; set; }
    public string invfrm { get; set; }
    public string recfrm { get; set; }
    public string taxreg { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
