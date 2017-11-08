public class PackageItem
{
    public long id { get; set; }
    public long pkid { get; set; }
    public long? bent { get; set; }
    public long? cce { get; set; }
    public long? pgrp { get; set; }
    public short minreq { get; set; }
    public short maxall { get; set; }
    public bool charge { get; set; }
    public bool incpric { get; set; }
    public short seq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
