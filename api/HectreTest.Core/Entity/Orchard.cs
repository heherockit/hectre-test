namespace HectreTest.Core;

public class Orchard : IEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string OrchardId { get; set; } = string.Empty;
    public string VarietyId { get; set; } = string.Empty;
    public float HoursWorked { get; set; }
    public string OrchardName { get; set; } = string.Empty;
    public DateTime? PickingDate { get; set; }
    public string VarietyName { get; set; } = string.Empty;
    public int NumberOfBins { get; set; }
    public float PayRatePerHour { get; set; }
}
