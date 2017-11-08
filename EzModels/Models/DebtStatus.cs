public class DebtStatus
{
    public long id { get; set; }
    public string desc { get; set; }
    public byte debtlev { get; set; }
    public decimal debtamt { get; set; }
    public int debtage { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
