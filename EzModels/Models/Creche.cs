public class Creche
{
    public long id { get; set; }
    public long site { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string sdesc { get; set; }
    public long carab { get; set; }
    public short? maxatc { get; set; }
    public long avail { get; set; }
    public decimal dayad { get; set; }
    public decimal hourcnc { get; set; }
    public decimal hourgrace { get; set; }
    public short minbk { get; set; }
    public short maxbk { get; set; }
    public short usubk { get; set; }
    public short bookdiv { get; set; }
    public short bkplace { get; set; }
    public short cellw { get; set; }
    public byte payopt { get; set; }
    public long? tskresp { get; set; }
    public byte ratcalc { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
