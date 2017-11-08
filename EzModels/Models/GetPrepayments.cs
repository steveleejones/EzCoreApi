public class GetPrepayments
{
    public long ID { get; set; }
    public long memID { get; set; }
    public DateTime dateSold { get; set; }
    public decimal amnt { get; set; }
    public long? LinkedPrepayment { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public byte? Type { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
