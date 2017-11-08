public class TransactionAllocation
{
    public long id { get; set; }
    public long chgid { get; set; }
    public long chgalloc { get; set; }
    public DateTime datalloc { get; set; }
    public long sysid { get; set; }
    public decimal amnt { get; set; }
    public byte typ { get; set; }
    public byte stat { get; set; }
    public int groupline { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
