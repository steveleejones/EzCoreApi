public class GetVatlog
{
    public long ID { get; set; }
    public decimal? ticket { get; set; }
    public decimal refNum { get; set; }
    public long? chgid { get; set; }
    public long? transId { get; set; }
    public long? site { get; set; }
    public DateTime transDate { get; set; }
    public string taxType { get; set; }
    public decimal netPrice { get; set; }
    public decimal taxrate { get; set; }
    public decimal vatAmount { get; set; }
    public decimal totPrice { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
