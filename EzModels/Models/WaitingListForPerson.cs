public class WaitingListForPerson
{
    public long id { get; set; }
    public DateTime stdate { get; set; }
    public DateTime? endate { get; set; }
    public long persid { get; set; }
    public short reqnot { get; set; }
    public short reqdur { get; set; }
    public long? wlgrp { get; set; }
    public short nfy { get; set; }
    public DateTime datlist { get; set; }
    public decimal wlpri { get; set; }
    public byte stat { get; set; }
    public string statdesc { get; set; }
    public string resline { get; set; }
}
