public class GetChargeGroupAllocation
{
    public long id { get; set; }
    public long chgid { get; set; }
    public long chggrp { get; set; }
    public decimal? amnt { get; set; }
    public byte stat { get; set; }
    public int groupline { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
