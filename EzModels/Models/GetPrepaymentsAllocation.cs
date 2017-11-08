public class GetPrepaymentsAllocation
{
    public long ID { get; set; }
    public long prechg { get; set; }
    public long prealloc { get; set; }
    public DateTime datalloc { get; set; }
    public decimal amnt { get; set; }
    public byte stat { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
