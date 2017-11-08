public class PromotionCodeByCode
{
    public long id { get; set; }
    public string code { get; set; }
    public string desc { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public long? memsrc { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
