public class CCERequirements
{
    public long id { get; set; }
    public long cceid { get; set; }
    public long abid { get; set; }
    public short reqpr { get; set; }
    public short minreq { get; set; }
    public short maxreq { get; set; }
    public short usureq { get; set; }
    public short seq { get; set; }
    public short foralloc { get; set; }
    public short forallocwarn { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
