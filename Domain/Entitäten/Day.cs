using Domain.Entitäten.Security;

namespace Domain.Entitäten;

public class Day : Base
{
    public double         TotalCarbs    { get; set; }
    public double         TotalProtein  { get; set; }
    public double         TotalFat      { get; set; }
    public double         TotalKcal     { get; set; }
    public DateTime       Date          { get; set; }
    public double         Weight        { get; set; }
    public User           User          { get; set; }
    public List<Consumed> ConsumedStuff { get; set; }
    public List<LogEntry> Log           { get; set; }
}