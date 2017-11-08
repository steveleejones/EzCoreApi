public class Transaction
{
    public long transactionID { get; set; }
    public long? receipt { get; set; }
    public string recno { get; set; }
    public DateTime date { get; set; }
    public long? till { get; set; }
    public long? currprd { get; set; }
    public long? site { get; set; }
    public decimal? amnt { get; set; }
    public string sdesc { get; set; }
    public long? MemberID { get; set; }
    public long? sysus { get; set; }
    public byte? typ { get; set; }
    public string signature { get; set; }
    public string taxinvnumber { get; set; }
    public DateTime? invDate { get; set; }
    public decimal? invamnt { get; set; }
    public string tblno { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
