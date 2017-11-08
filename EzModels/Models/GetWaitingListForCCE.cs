public class GetWaitingListForCCE
{
    public long id { get; set; }
    public long site { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public short reqnot { get; set; }
    public byte Status { get; set; }
    public byte ReservationType { get; set; }
    public long ReservationTypeID { get; set; }
    public short NotifyMethods { get; set; }
    public DateTime Dateonlist { get; set; }
    public decimal Priority { get; set; }
    public long CCEID { get; set; }
    public string CCEDesc { get; set; }
    public long OccuranceID { get; set; }
    public string OccID { get; set; }
}
