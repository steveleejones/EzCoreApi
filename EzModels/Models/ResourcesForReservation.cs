public class ResourcesForReservation
{
    public long linid { get; set; }
    public long resourceid { get; set; }
    public string desc { get; set; }
    public DateTime lstdate { get; set; }
    public DateTime lendate { get; set; }
    public long? abcap { get; set; }
    public string abdesc { get; set; }
    public byte rlstat { get; set; }
    public bool reslk { get; set; }
}
