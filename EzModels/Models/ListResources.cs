public class ListResources
{
    public long id { get; set; }
    public long? site { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string sdesc { get; set; }
    public string longdesc { get; set; }
    public byte typ { get; set; }
    public long? shp { get; set; }
    public long avail { get; set; }
    public long? resreg { get; set; }
    public bool enable { get; set; }
    public short? maxocc { get; set; }
    public long? respers { get; set; }
    public string http { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
