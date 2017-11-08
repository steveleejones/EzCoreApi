public class GetReservationsBetweenDates
{
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public long id { get; set; }
    public string occdesc { get; set; }
    public long? occid { get; set; }
    public string bedesc { get; set; }
    public long? beid { get; set; }
    public long? cceid { get; set; }
    public string ccedesc { get; set; }
    public long? ccegroup { get; set; }
    public long? crid { get; set; }
    public string crdesc { get; set; }
    public byte paidstat { get; set; }
    public byte resstat { get; set; }
    public long? ccecat { get; set; }
    public long site { get; set; }
    public long? tran { get; set; }
    public long? pack { get; set; }
}
