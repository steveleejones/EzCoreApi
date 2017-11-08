public class GetPersonGuestPass
{
    public long id { get; set; }
    public long pid { get; set; }
    public DateTime crdate { get; set; }
    public string crreason { get; set; }
    public DateTime validfrom { get; set; }
    public DateTime? validto { get; set; }
    public DateTime? allocon { get; set; }
    public long? allocto { get; set; }
    public DateTime? delon { get; set; }
    public string delreason { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
