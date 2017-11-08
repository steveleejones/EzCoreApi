public class RoketQueryForName
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public long? querygrp { get; set; }
    public long? notyp { get; set; }
    public string quxml { get; set; }
    public string quxmlnorep { get; set; }
    public long auth { get; set; }
    public string txtauthor { get; set; }
    public bool allsit { get; set; }
    public bool allgrp { get; set; }
    public bool readonly { get; set; }
    public string qtype { get; set; }
    public string exlut { get; set; }
    public short seqno { get; set; }
    public bool? hasChartUI { get; set; }
    public string ChartUIColumnList { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
