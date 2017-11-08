public class OnHoldNotesForClient
{
    public long id { get; set; }
    public long personid { get; set; }
    public long? notyp { get; set; }
    public string initials { get; set; }
    public long? caseid { get; set; }
    public DateTime datent { get; set; }
    public DateTime? datact { get; set; }
    public string note { get; set; }
    public string noteattold { get; set; }
    public byte[] attmnt { get; set; }
    public byte atttyp { get; set; }
    public bool reqsig { get; set; }
    public bool issign { get; set; }
    public DateTime? datsigned { get; set; }
    public bool ismandate { get; set; }
    public short? numrsig { get; set; }
    public short? numsign { get; set; }
    public long? user { get; set; }
    public bool achold { get; set; }
    public bool active { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
