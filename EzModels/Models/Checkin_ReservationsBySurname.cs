public class Checkin_ReservationsBySurname
{
    public long ReservationId { get; set; }
    public long? ReservationAttendeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ReservationDescription { get; set; }
    public DateTime CreationDate { get; set; }
    public long PersonId { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public string Postcode { get; set; }
    public int? AttendeeCount { get; set; }
    public string Note { get; set; }
    public string SiteMnem { get; set; }
    public int? AppearanceFg { get; set; }
    public int? AppearanceBg { get; set; }
    public int? WaiverAppearanceFg { get; set; }
    public int? WaiverAppearanceBg { get; set; }
    public int? WristbandAppearanceFg { get; set; }
    public int? WristbandAppearanceBg { get; set; }
}
