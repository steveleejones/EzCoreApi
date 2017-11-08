public class BACSLog
{
    public long ID { get; set; }
    public long debitLog { get; set; }
    public long? transId { get; set; }
    public long? chgID { get; set; }
    public long? subId { get; set; }
    public string ddrcolcod { get; set; }
    public string ddid { get; set; }
    public string accountname { get; set; }
    public string accountnumber { get; set; }
    public string sortcode { get; set; }
    public decimal amount { get; set; }
    public bool payment { get; set; }
    public long? CreditID { get; set; }
    public string uniqueinstid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
