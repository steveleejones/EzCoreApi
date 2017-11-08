public class PersonWaiver
{
    public long id { get; set; }
    public long PersonId { get; set; }
    public long WaiverId { get; set; }
    public long? AcceptancePersonId { get; set; }
    public DateTime? AcceptanceDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
