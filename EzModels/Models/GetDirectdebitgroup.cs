public class GetDirectdebitgroup
{
    public long ID { get; set; }
    public string description { get; set; }
    public string archFold { get; set; }
    public string audfile { get; set; }
    public string bacfile { get; set; }
    public string bacrefile { get; set; }
    public bool usemem { get; set; }
    public string mnem { get; set; }
    public string processfold { get; set; }
    public long? nottyp { get; set; }
    public string sun { get; set; }
    public bool payactive { get; set; }
    public long? taskgroup { get; set; }
    public long? bacsfmt { get; set; }
    public long? auddisfmt { get; set; }
    public string bic { get; set; }
    public string iban { get; set; }
    public string creditorident { get; set; }
    public string initptynm { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
