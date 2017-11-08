public class PackageForReservationTransaction
{
    public decimal? totalprice { get; set; }
    public DateTime stdate { get; set; }
    public DateTime endate { get; set; }
    public long id { get; set; }
    public long site { get; set; }
    public byte resstat { get; set; }
    public byte paidstat { get; set; }
    public long? pkgrp { get; set; }
    public long persid { get; set; }
    public long tran { get; set; }
    public long? pack { get; set; }
    public long? lead { get; set; }
    public string occdesc { get; set; }
    public long? occid { get; set; }
    public string bedesc { get; set; }
    public long? beid { get; set; }
    public long? cceid { get; set; }
    public string ccedesc { get; set; }
    public long? ccegroup { get; set; }
    public long? crid { get; set; }
    public string crdesc { get; set; }
    public long? ccecat { get; set; }
    public string packdesc { get; set; }
    public short minreq { get; set; }
    public short maxall { get; set; }
    public bool charge { get; set; }
    public short seq { get; set; }
    public bool incpric { get; set; }
    public long itemid { get; set; }
    public bool syncoth { get; set; }
    public bool defsel { get; set; }
    public bool supdisp { get; set; }
    public short itemseq { get; set; }
    public string webdesc { get; set; }
}
