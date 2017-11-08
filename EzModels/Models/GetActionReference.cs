public class GetActionReference
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public byte reftyp { get; set; }
    public short seqno { get; set; }
    public long prio { get; set; }
    public short? estcom { get; set; }
    public short? defalm { get; set; }
    public long? meetbe { get; set; }
    public long? tskresp { get; set; }
    public bool mantask { get; set; }
    public bool initask { get; set; }
    public bool clotask { get; set; }
    public string tfunc { get; set; }
    public string tparam { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
