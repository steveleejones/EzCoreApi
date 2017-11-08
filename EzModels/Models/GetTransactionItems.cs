public class GetTransactionItems
{
    public string TransactionType { get; set; }
    public decimal? TransactionAmount { get; set; }
    public long? ReservationId { get; set; }
    public long ReservationAttendeeId { get; set; }
    public int? Status { get; set; }
}
