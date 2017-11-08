public class CCEOccurrenceList
{
    public long occid { get; set; }
    public long cceid { get; set; }
    public string ccedesc { get; set; }
    public string occdesc { get; set; }
    public string catdesc { get; set; }
    public string grpdesc { get; set; }
    public byte ccetype { get; set; }
    public int? numsub { get; set; }
    public int minatt { get; set; }
    public int maxatt { get; set; }
    public int maxwait { get; set; }
    public string abdesc { get; set; }
    public string resdesc { get; set; }
    public short dayno { get; set; }
    public int stime { get; set; }
    public int etime { get; set; }
    public int? numwait { get; set; }
    public long? site { get; set; }
    public DateTime? datestart { get; set; }
    public int? numsess { get; set; }
    public int? remsess { get; set; }
}
