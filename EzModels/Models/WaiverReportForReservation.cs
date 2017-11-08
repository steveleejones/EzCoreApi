public class WaiverReportForReservation
{
    public string Attendee { get; set; }
    public string WaiverAcceptedBy { get; set; }
    public DateTime? WaiverExpiry { get; set; }
    public DateTime? dob { get; set; }
    public long ReservationAttendeeId { get; set; }
    public long? PersonId { get; set; }
    public long? AcceptancePersonId { get; set; }
    public long? PersonWaiverId { get; set; }
    public string remnum { get; set; }
    public string acceptanceremnum { get; set; }
}
