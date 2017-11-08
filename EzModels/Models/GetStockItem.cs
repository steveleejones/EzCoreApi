public class GetStockItem
{
    public long id { get; set; }
    public long grp { get; set; }
    public string desc { get; set; }
    public string prcod { get; set; }
    public string batbcod { get; set; }
    public string sbcod { get; set; }
    public byte[] stkimg { get; set; }
    public long? stkgrp { get; set; }
    public long? stkun { get; set; }
    public byte stocktype { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
