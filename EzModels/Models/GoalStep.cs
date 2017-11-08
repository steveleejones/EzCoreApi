public class GoalStep
{
    public long id { get; set; }
    public long GoalId { get; set; }
    public string description { get; set; }
    public byte? RequiredAchievements { get; set; }
    public byte seq { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
