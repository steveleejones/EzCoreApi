public class GetConfirmationDataForReservationTransaction
{
    public long ReservationTransactionId { get; set; }
    public DateTime ReservationCreationDate { get; set; }
    public long? LeadPersonId { get; set; }
    public long? LeadPackageId { get; set; }
}
