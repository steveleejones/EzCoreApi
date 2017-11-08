public class BookingsForPersonAndRelatedBetweenDates
{
    public long *raid { get; set; }
    public long *rvid { get; set; }
    public long? *beid { get; set; }
    public long? *cceocc { get; set; }
    public long? *crecheid { get; set; }
    public string Client { get; set; }
    public string Description { get; set; }
    public DateTime OnDate/120 { get; set; }
    public int? Duration/75 { get; set; }
    public DateTime PlannedIn { get; set; }
    public DateTime PlannedOut { get; set; }
    public long? PlannedAdultsAttending { get; set; }
    public long? PlannedChildrenAttending { get; set; }
}
