public class Checkin_ReservationAttendeesForReservation
{
    public long ReservationId { get; set; }
    public long ReservationAttendeeId { get; set; }
    public long PersonId { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public DateTime? DOB { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? TurnedUp { get; set; }
    public long? WaiverId { get; set; }
    public long? PersonWaiverId { get; set; }
    public int? WaiverAppearanceFg { get; set; }
    public int? WaiverAppearanceBg { get; set; }
}
