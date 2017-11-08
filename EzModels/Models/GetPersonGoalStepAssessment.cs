public class GetPersonGoalStepAssessment
{
    public long id { get; set; }
    public long PersonGoalStepId { get; set; }
    public DateTime AssessedOn { get; set; }
    public bool Achieved { get; set; }
    public string Comment { get; set; }
    public long UserId { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
