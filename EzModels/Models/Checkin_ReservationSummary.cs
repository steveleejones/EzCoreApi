public class Checkin_ReservationSummary
{
    public long ReservationId { get; set; }
    public long PersonId { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ReservationDescription { get; set; }
    public string Note { get; set; }
    public string SiteMnem { get; set; }
    public decimal? Arrears { get; set; }
    public int? WristbandAppearanceFg { get; set; }
    public int? WristbandAppearanceBg { get; set; }
    public string WristbandDescription { get; set; }
}
