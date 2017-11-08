public class Goal
{
    public long id { get; set; }
    public string description { get; set; }
    public long? FollowOnGoal { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
