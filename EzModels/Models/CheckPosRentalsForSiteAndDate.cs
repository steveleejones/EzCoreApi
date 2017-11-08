public class CheckPosRentalsForSiteAndDate
{
    public long ID { get; set; }
    public long POSRentalsID { get; set; }
    public long Site { get; set; }
    public short NoOfItems { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
    public int? UsedItems { get; set; }
}
