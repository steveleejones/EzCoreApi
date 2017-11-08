public class GetPersonToken
{
    public long id { get; set; }
    public long PersonId { get; set; }
    public string PAN { get; set; }
    public string cardExpiry { get; set; }
    public string token { get; set; }
    public DateTime tokenExpiration { get; set; }
    public bool optIn { get; set; }
    public DateTime datcre { get; set; }
    public string publicKey { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
