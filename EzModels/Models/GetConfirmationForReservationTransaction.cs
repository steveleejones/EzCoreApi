public class GetConfirmationForReservationTransaction
{
    public long id { get; set; }
    public string description { get; set; }
    public long LetterId { get; set; }
    public bool auto { get; set; }
    public byte conftype { get; set; }
    public long? successnottyp { get; set; }
    public long? failnottyp { get; set; }
    public string bcc { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
