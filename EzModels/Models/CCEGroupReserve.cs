public class CCEGroupReserve
{
    public long ccegid { get; set; }
    public long cceid { get; set; }
    public long cceoccid { get; set; }
    public long resid { get; set; }
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public string ccegdesc { get; set; }
    public string ccedesc { get; set; }
    public string cceoccdesc { get; set; }
    public int? numatt { get; set; }
    public int? numwait { get; set; }
    public int minatt { get; set; }
    public int? usemax { get; set; }
    public string note { get; set; }
    public long? catid { get; set; }
    public long? catapp { get; set; }
    public long ccegapp { get; set; }
    public long? cceapp { get; set; }
    public long? emptygroup { get; set; }
    public long? fullgroup { get; set; }
    public long? emptycce { get; set; }
    public long? fullcce { get; set; }
    public string catmnem { get; set; }
    public string catdesc { get; set; }
    public string grpmnem { get; set; }
    public byte resstat { get; set; }
    public int? numsess { get; set; }
    public int? cursess { get; set; }
}
