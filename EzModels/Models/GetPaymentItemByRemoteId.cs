public class GetPaymentItemByRemoteId
{
    public long paymentItemID { get; set; }
    public string description { get; set; }
    public string zgrpdesc { get; set; }
    public string nlCode { get; set; }
    public long? fnot { get; set; }
    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
    public string tillMessage { get; set; }
    public int noOfRecipts { get; set; }
    public bool authopt { get; set; }
    public bool manalloc { get; set; }
    public bool ccref { get; set; }
    public short Sequence { get; set; }
    public string remid { get; set; }
    public string remgrp { get; set; }
    public string reminfo { get; set; }
    public bool usegrp { get; set; }
    public string mernum { get; set; }
    public long? mercprofile { get; set; }
    public bool debtcon { get; set; }
    public bool avaionline { get; set; }
    public string barCodeNo { get; set; }
    public int? btnColour { get; set; }
    public int txtColour { get; set; }
    public string btnText { get; set; }
    public bool active { get; set; }
    public bool defrefmeth { get; set; }
    public bool postrem { get; set; }
    public bool newmem { get; set; }
    public bool reqsig { get; set; }
    public byte paymentType { get; set; }
    public bool AutoAccept { get; set; }
    public bool ShowOnZ { get; set; }
    public bool inclrecon { get; set; }
    public bool requiresMember { get; set; }
    public string productCode { get; set; }
    public string receiptText { get; set; }
    public long? tinold { get; set; }
    public long? rinold { get; set; }
    public bool ShowOnCashup { get; set; }
    public string export { get; set; }
    public bool usetoken { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
