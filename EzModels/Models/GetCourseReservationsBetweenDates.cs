public class GetCourseReservationsBetweenDates
{
    public long resid { get; set; }
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public byte csubstat { get; set; }
    public byte paidstat { get; set; }
    public string occdesc { get; set; }
    public byte resstat { get; set; }
    public long cceid { get; set; }
    public long occid { get; set; }
    public string ccedesc { get; set; }
    public long ccegrp { get; set; }
    public long? ccecat { get; set; }
}
