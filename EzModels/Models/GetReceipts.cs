public class GetReceipts
{
    public long id { get; set; }
    public string desc { get; set; }
    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
    public long stnum { get; set; }
    public long cnum { get; set; }
    public string recfrm { get; set; }
    public string ReceiptImage { get; set; }
    public string ReceiptHeader { get; set; }
    public string ReceiptFooter { get; set; }
    public string zhdr { get; set; }
    public string zftr { get; set; }
    public byte ShowNextReservation { get; set; }
    public string siginfo { get; set; }
    public bool demodrec { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
