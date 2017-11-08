public class GetStockOrderItem
{
    public long id { get; set; }
    public long stord { get; set; }
    public long sisid { get; set; }
    public long sisup { get; set; }
    public int orderqu { get; set; }
    public string note { get; set; }
    public byte istat { get; set; }
    public int? recqu { get; set; }
    public DateTime? datrec { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
