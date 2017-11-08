public class GoalsReportForPerson
{
    public long PersonGoalId { get; set; }
    public DateTime? PersonGoalCompletedOn { get; set; }
    public long GoalId { get; set; }
    public string GoalDescription { get; set; }
    public long GoalStepId { get; set; }
    public string GoalStepDescription { get; set; }
    public byte GoalStepSequence { get; set; }
    public long? PersonGoalStepId { get; set; }
    public DateTime? PersonGoalStepCompletedOn { get; set; }
    public long? PersonGoalStepAssessmentId { get; set; }
    public DateTime? AssessedOn { get; set; }
    public bool? Achieved { get; set; }
    public string Comment { get; set; }
}
