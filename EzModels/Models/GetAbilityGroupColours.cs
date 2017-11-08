public class GetAbilityGroupColours
{
    public long abilityID { get; set; }
    public long groupID { get; set; }
    public string mnemonic { get; set; }
    public string description { get; set; }
    public long? cellViewID { get; set; }
    public bool allowAllocation { get; set; }
    public int backgroundColor { get; set; }
    public int foregroundColor { get; set; }
}
