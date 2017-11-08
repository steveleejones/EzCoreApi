public class GetServiceSubscriptionChargeDetails
{
    public long id { get; set; }
    public long persid { get; set; }
    public long? headmem { get; set; }
    public long? accPers { get; set; }
    public long? positem { get; set; }
    public decimal? cashamt { get; set; }
    public decimal? colamt { get; set; }
    public bool? chargeprim { get; set; }
    public long primaryperson { get; set; }
    public string nlcode { get; set; }
    public string productcode { get; set; }
}
