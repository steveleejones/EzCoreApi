public class GetPosPackage
{
    public long packageID { get; set; }
    public string packageDesc { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? numavail { get; set; }
    public decimal RedemptionValue { get; set; }
    public decimal? PosValue { get; set; }
    public long? ebpack { get; set; }
    public bool useservdef { get; set; }
    public int? expiryDays { get; set; }
    public long? rokpackdet { get; set; }
    public string barCodeNo { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
