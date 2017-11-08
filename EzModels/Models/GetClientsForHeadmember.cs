public class GetClientsForHeadmember
{
    public long *Person { get; set; }
    public long *Definition { get; set; }
    public long *Subscription { get; set; }
    public long? *SiteID { get; set; }
    public string *fgcol { get; set; }
    public string ModifiedFlag/20 { get; set; }
    public string Name/120 { get; set; }
    public string Identifier/70 { get; set; }
    public string Subscription/180 { get; set; }
    public string RefernceNo/100 { get; set; }
    public DateTime? StartDate/75/dd_MMM_yyyy { get; set; }
    public DateTime? EndDate/75/dd_MMM_yyyy { get; set; }
    public DateTime? EarliestEnd/75/dd_MMM_yyyy { get; set; }
    public DateTime? NextDate/75/dd_MMM_yyyy { get; set; }
    public decimal? NextAmount/80/C { get; set; }
    public string Collection/100 { get; set; }
    public string Account/140 { get; set; }
    public int *AddSubscription { get; set; }
    public int *AdvancedPosting { get; set; }
    public int *EditSubscription { get; set; }
    public int *EnrolementManager { get; set; }
    public int *MultiEditSubscription { get; set; }
    public int *TransferSubscription { get; set; }
    public int *ShowClient { get; set; }
}
