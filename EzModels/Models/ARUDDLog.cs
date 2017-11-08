public class ARUDDLog
{
    public long ID { get; set; }
    public long debitLog { get; set; }
    public long? origCharge { get; set; }
    public long? reversalCharge { get; set; }
    public long? personNote { get; set; }
    public long? personHeld { get; set; }
    public long? handlingCharge { get; set; }
    public bool revSucess { get; set; }
    public string ref { get; set; }
    public string transCode { get; set; }
    public string returnCode { get; set; }
    public string returnDescription { get; set; }
    public DateTime? procDate { get; set; }
    public decimal? unpaid { get; set; }
    public string currency { get; set; }
    public long? subid { get; set; }
    public string prevcolcod { get; set; }
    public string prevddid { get; set; }
    public byte? prevstat { get; set; }
    public long? tranalloc { get; set; }
    public string uniqueinstid { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
