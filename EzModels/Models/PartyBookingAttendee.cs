public class PartyBookingAttendee
{
    public long id { get; set; }
    public long be { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public string webdesc { get; set; }
    public short? minage { get; set; }
    public short? maxage { get; set; }
    public short? minatt { get; set; }
    public short? maxatt { get; set; }
    public short? numfree { get; set; }
    public string relmin { get; set; }
    public string relmax { get; set; }
    public long? tzon { get; set; }
    public long positem { get; set; }
    public DateTime? acfrom { get; set; }
    public DateTime? acto { get; set; }
    public byte attype { get; set; }
    public int seq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
