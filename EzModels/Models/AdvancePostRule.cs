public class AdvancePostRule
{
    public long ID { get; set; }
    public long basegrp { get; set; }
    public long nextgrp { get; set; }
    public byte applies { get; set; }
    public bool allowPost { get; set; }
    public bool prorate { get; set; }
    public long? rokprorate { get; set; }
    public bool prorefund { get; set; }
    public long? rokrefund { get; set; }
    public bool joinfee { get; set; }
    public decimal? joinnfeeamt { get; set; }
    public long? joinfeepositem { get; set; }
    public byte contractrule { get; set; }
    public decimal? inttranfee { get; set; }
    public long? icpositem { get; set; }
    public bool mandate { get; set; }
    public byte mandateopt { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
