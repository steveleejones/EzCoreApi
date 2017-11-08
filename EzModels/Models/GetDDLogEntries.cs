public class GetDDLogEntries
{
    public long id { get; set; }
    public string description { get; set; }
    public string ref { get; set; }
    public string username { get; set; }
    public DateTime rundate { get; set; }
    public string outputfile { get; set; }
    public byte? action { get; set; }
    public byte? status { get; set; }
    public DateTime? ChargeDate { get; set; }
}
