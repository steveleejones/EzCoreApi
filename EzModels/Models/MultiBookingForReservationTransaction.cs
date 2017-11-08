public class MultiBookingForReservationTransaction
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
    public long? person { get; set; }
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
}
