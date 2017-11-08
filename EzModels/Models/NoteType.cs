public class NoteType
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public short seq { get; set; }
    public string defnote { get; set; }
    public bool crtsk { get; set; }
    public short? tskdays { get; set; }
    public int? timact { get; set; }
    public byte comtyp { get; set; }
    public bool enable { get; set; }
    public bool suppress { get; set; }
    public bool defonhold { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
