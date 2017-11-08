public class TableReservation
{
    public long id { get; set; }
    public long? reservation { get; set; }
    public DateTime arrivedate { get; set; }
    public byte course { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
