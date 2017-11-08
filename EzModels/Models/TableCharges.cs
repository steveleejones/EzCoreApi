public class TableCharges
{
    public long id { get; set; }
    public long? table { get; set; }
    public long chargeid { get; set; }
    public long? resid { get; set; }
    public DateTime? procdate { get; set; }
    public DateTime? awaydate { get; set; }
    public DateTime? arrivedate { get; set; }
    public byte course { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
