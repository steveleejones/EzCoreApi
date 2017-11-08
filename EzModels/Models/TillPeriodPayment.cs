public class TillPeriodPayment
{
    public long id { get; set; }
    public long tillperiodid { get; set; }
    public long? cshdec { get; set; }
    public short? PaymentTypeID { get; set; }
    public decimal Amount { get; set; }
    public decimal sysamnt { get; set; }
    public bool zreading { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
