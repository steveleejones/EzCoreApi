public class GetBEReservationsBookedBetweenDates
{
    public string PaidStatus { get; set; }
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public string bedesc { get; set; }
    public long id { get; set; }
    public long beid { get; set; }
    public byte resstat { get; set; }
    public byte paidstat { get; set; }
    public long site { get; set; }
    public long? tran { get; set; }
    public long? pack { get; set; }
}
