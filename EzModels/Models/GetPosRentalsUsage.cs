public class GetPosRentalsUsage
{
    public long ID { get; set; }
    public long POSRentalsID { get; set; }
    public long chgid { get; set; }
    public long Site { get; set; }
    public DateTime rentaldate { get; set; }
    public DateTime? returndate { get; set; }
    public byte stat { get; set; }
    public short? index { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
