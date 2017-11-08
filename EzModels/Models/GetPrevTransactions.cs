public class GetPrevTransactions
{
    public long transactionid { get; set; }
    public string recno { get; set; }
    public DateTime date { get; set; }
    public string Member { get; set; }
    public string sdesc { get; set; }
    public string sitename { get; set; }
    public byte? transTyp { get; set; }
    public decimal? Amount { get; set; }
    public int? QuantityOrdered { get; set; }
    public int? hasSubs { get; set; }
    public int? hasSubsPayment { get; set; }
    public int? hasCheques { get; set; }
    public int QuantityRefund { get; set; }
    public int QuantityWaitingRefund { get; set; }
    public int prepaid { get; set; }
    public string invoice { get; set; }
    public int? RentalCount { get; set; }
}
