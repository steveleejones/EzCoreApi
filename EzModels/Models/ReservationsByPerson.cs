public class ReservationsByPerson
{
    public long rvid { get; set; }
    public long? raid { get; set; }
    public decimal? amnt { get; set; }
    public decimal? bal { get; set; }
    public long? personid { get; set; }
    public string surname { get; set; }
    public string forename { get; set; }
    public DateTime stdate { get; set; }
    public byte? paidstat { get; set; }
    public byte resstat { get; set; }
    public string detdesc { get; set; }
}
