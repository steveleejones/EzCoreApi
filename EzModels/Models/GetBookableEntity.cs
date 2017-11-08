public class GetBookableEntity
{
    public long id { get; set; }
    public long? sitegrp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string longdesc { get; set; }
    public string intdesc { get; set; }
    public long? beimage { get; set; }
    public string http { get; set; }
    public string videourl { get; set; }
    public string alert { get; set; }
    public long grp { get; set; }
    public long appear { get; set; }
    public long? appeartu { get; set; }
    public long? appearlf { get; set; }
    public decimal dayad { get; set; }
    public decimal dayadweb { get; set; }
    public decimal hourcnc { get; set; }
    public decimal hourgrace { get; set; }
    public bool enablebe { get; set; }
    public bool onlypack { get; set; }
    public bool onlypackpos { get; set; }
    public byte starthour { get; set; }
    public string daycut { get; set; }
    public short minatt { get; set; }
    public short maxatt { get; set; }
    public short minbk { get; set; }
    public short maxbk { get; set; }
    public short usubk { get; set; }
    public short bookdiv { get; set; }
    public short bkplace { get; set; }
    public short seqno { get; set; }
    public short cellw { get; set; }
    public short cellh { get; set; }
    public byte payopt { get; set; }
    public byte webbook { get; set; }
    public byte bookmeth { get; set; }
    public short mingam { get; set; }
    public short maxgam { get; set; }
    public short moveback { get; set; }
    public short moveforward { get; set; }
    public short preptime { get; set; }
    public short recotime { get; set; }
    public bool overlap { get; set; }
    public bool prombe { get; set; }
    public bool allowsel { get; set; }
    public short maxattgam { get; set; }
    public short mingap { get; set; }
    public bool unrelatt { get; set; }
    public bool stoatt { get; set; }
    public bool qkcli { get; set; }
    public bool waitlist { get; set; }
    public long? avpex { get; set; }
    public bool offstres { get; set; }
    public long? intprof { get; set; }
    public byte? minage { get; set; }
    public byte? maxage { get; set; }
    public byte allgend { get; set; }
    public decimal hourmove { get; set; }
    public decimal hourmvgrace { get; set; }
    public long? UpsellOption { get; set; }
    public byte bookingtype { get; set; }
    public long? waiverid { get; set; }
    public long? appearwaiverincomp { get; set; }
    public long? appearwaivercomp { get; set; }
    public bool changefirst { get; set; }
    public bool DisallowAutomaticTimeRelocation { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
