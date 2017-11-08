public class CommunicationToken
{
    public long id { get; set; }
    public int ForeignId { get; set; }
    public byte ForeignTable { get; set; }
    public string AccessToken { get; set; }
    public DateTime ExpiryDate { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
