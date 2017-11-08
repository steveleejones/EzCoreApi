public class GetVoucherconfig
{
    public long VoucherConfigID { get; set; }
    public string description { get; set; }
    public long? VCHITemp { get; set; }
    public long? VCHATemp { get; set; }
    public bool PrintItemVoucher { get; set; }
    public bool ItemGenCode { get; set; }
    public bool incltax { get; set; }
    public long? itempi { get; set; }
    public short noofreceipts { get; set; }
    public decimal? VoucherMinLimit { get; set; }
    public short? VoucherDuration { get; set; }
    public byte? VoucherItemsPerPage { get; set; }
    public bool OldVoucherSN { get; set; }
    public bool PrintPrompt { get; set; }
    public bool PrintMonVoucher { get; set; }
    public bool ChngVoucher { get; set; }
    public bool unqsn { get; set; }
    public string chgvchtillmsg { get; set; }
    public string chgvchrecmsg { get; set; }
    public bool PrintChngVoucher { get; set; }
    public bool MonGenCode { get; set; }
    public bool PadSerialNo { get; set; }
    public bool HideVoucherMsg { get; set; }
    public string VoucherPrefix { get; set; }
    public bool UsePin { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
