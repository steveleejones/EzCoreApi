public class AccessControlPartyGuestSwipesForReservation
{
    public long? personid { get; set; }
    public long? siteid { get; set; }
    public long resid { get; set; }
    public long ReservationAttendeeId { get; set; }
    public long? PlannedAdultsAttending { get; set; }
    public long? PlannedChildrenAttending { get; set; }
    public DateTime PlannedIn { get; set; }
    public DateTime PlannedOut { get; set; }
    public int? AdultsIN { get; set; }
    public int? AdultsOUT { get; set; }
    public int? KidsIN { get; set; }
    public int? KidsOUT { get; set; }
}
