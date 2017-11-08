public class TaxRates
{
    public long id { get; set; }
    public string desc { get; set; }
    public string rectxt { get; set; }
    public byte recseq { get; set; }
    public decimal rate { get; set; }
    public byte TaxType { get; set; }
    public byte calctyp { get; set; }
    public string remdesc { get; set; }
    public string remcode { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
