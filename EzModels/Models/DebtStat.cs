public class DebtStat
{
    public long personid { get; set; }
    public long? headmem { get; set; }
    public decimal? balance { get; set; }
    public decimal? total { get; set; }
    public decimal? mybalance { get; set; }
    public decimal? totalbalance { get; set; }
    public decimal? credits { get; set; }
    public DateTime? mindate { get; set; }
    public long? debtid { get; set; }
    public DateTime? debtdate { get; set; }
    public bool? corporate { get; set; }
    public string debtdesc { get; set; }
}
