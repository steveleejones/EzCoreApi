public class GetTill
{
    public long tillID { get; set; }
    public long site { get; set; }
    public string description { get; set; }
    public string ControlChars { get; set; }
    public long? VoucherConfig { get; set; }
    public long Currency { get; set; }
    public string FiscalInterface { get; set; }
    public long? Layout { get; set; }
    public string FiscalDir { get; set; }
    public string szloc { get; set; }
    public bool HoldMember { get; set; }
    public bool CommPrompt { get; set; }
    public bool Refrsn { get; set; }
    public byte recprev { get; set; }
    public bool xzprev { get; set; }
    public bool stpackbal { get; set; }
    public bool shwinwout { get; set; }
    public int ItemColour { get; set; }
    public int HeaderFooterColour { get; set; }
    public int DiscountColour { get; set; }
    public int LoyaltyColour { get; set; }
    public int UnitPriceColor { get; set; }
    public int TotalColour { get; set; }
    public int CommColour { get; set; }
    public int hdrbckcol1 { get; set; }
    public int hdrbckcol2 { get; set; }
    public int pnbckcol1 { get; set; }
    public int pnbckcol2 { get; set; }
    public int ftbckcol1 { get; set; }
    public int ftbckcol2 { get; set; }
    public bool grdlns { get; set; }
    public long? receipt { get; set; }
    public long? trannum { get; set; }
    public long? rokarr { get; set; }
    public long? rectrannum { get; set; }
    public bool ShowPast { get; set; }
    public bool chggrpalloc { get; set; }
    public bool ltab { get; set; }
    public bool sweepalloc { get; set; }
    public bool zdefclose { get; set; }
    public bool allocalatestfirst { get; set; }
    public long? lindisp { get; set; }
    public long? drwcomm { get; set; }
    public bool reftran { get; set; }
    public bool ShowFuture { get; set; }
    public short? ShowDaysInAdvance { get; set; }
    public long? chgpayitm { get; set; }
    public long? cddpositem { get; set; }
    public long? ddrefundpositem { get; set; }
    public bool RunTabOption { get; set; }
    public byte tabrecopt { get; set; }
    public short? tabnorec { get; set; }
    public byte tivis { get; set; }
    public bool ShowAcceptOnBalance { get; set; }
    public long? recprntr { get; set; }
    public long? xzprntr { get; set; }
    public string TillPrinterOld { get; set; }
    public long? rprtprntr { get; set; }
    public string ReportPrinterOld { get; set; }
    public bool splittrans { get; set; }
    public decimal? maxvalue { get; set; }
    public bool reqLogon { get; set; }
    public byte? UserLogon { get; set; }
    public byte? SwipeLogon { get; set; }
    public bool autoalloc { get; set; }
    public bool showfuturedd { get; set; }
    public bool autoshowCTA { get; set; }
    public bool showbal { get; set; }
    public bool showpkitmsdisc { get; set; }
    public bool usereslnk { get; set; }
    public bool autocashup { get; set; }
    public int? cunormaltime { get; set; }
    public int? cubankhol { get; set; }
    public bool singleinv { get; set; }
    public bool postonz { get; set; }
    public byte tillType { get; set; }
    public long? room { get; set; }
    public long? Food { get; set; }
    public long? Drink { get; set; }
    public bool sendwholefood { get; set; }
    public bool sendwholedrink { get; set; }
    public bool showaggresatt { get; set; }
    public bool forcecreditaccount { get; set; }
    public byte UseMemAccBalForCalcs { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
