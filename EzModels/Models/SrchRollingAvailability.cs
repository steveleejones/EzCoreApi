public class SrchRollingAvailability
{
    public long id { get; set; }
    public long availid { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public short stday { get; set; }
    public long roldef { get; set; }
    public string roldef_mnem { get; set; }
    public string roldef_desc { get; set; }
}
