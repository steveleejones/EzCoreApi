public class GetGuestPassesForPerson
{
    public long id { get; set; }
    public DateTime crdate { get; set; }
    public DateTime validfrom { get; set; }
    public DateTime? validto { get; set; }
    public DateTime? allocon { get; set; }
    public long? allocto { get; set; }
    public string fn { get; set; }
    public string sn { get; set; }
}
