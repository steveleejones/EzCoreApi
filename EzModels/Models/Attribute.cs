public class Attribute
{
    public long id { get; set; }
    public long grp { get; set; }
    public string mnem { get; set; }
    public string desc { get; set; }
    public string indesc { get; set; }
    public byte typ { get; set; }
    public byte fscope { get; set; }
    public bool multlin { get; set; }
    public bool mand { get; set; }
    public bool readonly { get; set; }
    public string defval { get; set; }
    public string regex { get; set; }
    public string disval { get; set; }
    public byte chkaln { get; set; }
    public string highal { get; set; }
    public string hightxt { get; set; }
    public string medal { get; set; }
    public string medtxt { get; set; }
    public string lowal { get; set; }
    public string lowtxt { get; set; }
    public bool allsites { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
