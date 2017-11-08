public class GetPersonGoal
{
    public long id { get; set; }
    public long PersonId { get; set; }
    public long GoalId { get; set; }
    public DateTime StartOn { get; set; }
    public DateTime? CompletedOn { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
