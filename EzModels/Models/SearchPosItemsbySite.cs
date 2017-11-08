public class SearchPosItemsbySite
{
    public long posItemID { get; set; }
    public string productCode { get; set; }
    public string description { get; set; }
    public decimal defaultPrice { get; set; }
    public string barCodeNo { get; set; }
    public string groupName { get; set; }
    public long? site { get; set; }
    public bool active { get; set; }
    public long? package { get; set; }
}
