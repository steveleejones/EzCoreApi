public class GetMandatesForPerson
{
    public long id { get; set; }
    public long persid { get; set; }
    public bool active { get; set; }
    public string ref { get; set; }
    public DateTime? dateofsignature { get; set; }
    public long? persnot { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
    public string fn { get; set; }
    public string sn { get; set; }
    public string sn2 { get; set; }
}
