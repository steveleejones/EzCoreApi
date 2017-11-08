public class PosItemTaxRates
{
    public long id { get; set; }
    public long positemid { get; set; }
    public long taxrateid { get; set; }
    public byte vchtaxtyp { get; set; }
    public short seq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
