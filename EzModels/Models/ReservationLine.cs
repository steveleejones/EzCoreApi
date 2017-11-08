public class ReservationLine
{
    public long id { get; set; }
    public long rvid { get; set; }
    public long resourceid { get; set; }
    public DateTime lstdate { get; set; }
    public DateTime lendate { get; set; }
    public long? abcap { get; set; }
    public byte rlstat { get; set; }
    public long? cncdet { get; set; }
    public bool reslk { get; set; }
    public bool archived { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
