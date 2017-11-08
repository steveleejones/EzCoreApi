public class GetPackage
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public string tooltip { get; set; }
    public string webdesc { get; set; }
    public long? pkgimage { get; set; }
    public short seq { get; set; }
    public byte payopt { get; set; }
    public bool enablepk { get; set; }
    public long? lett { get; set; }
    public string emlmes { get; set; }
    public bool disableemail { get; set; }
    public string smsmes { get; set; }
    public string note { get; set; }
    public bool itincal { get; set; }
    public byte promptpc { get; set; }
    public byte? minage { get; set; }
    public byte? maxage { get; set; }
    public byte allgend { get; set; }
    public long? UpsellOption { get; set; }
    public short? PackageMins { get; set; }
    public long? PackageGrouping { get; set; }
    public long? ConfirmationId { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
