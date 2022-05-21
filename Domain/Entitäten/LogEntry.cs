using Domain.Interfaces;

namespace Domain.Entitäten;

public class LogEntry : Base
{
    public INutritious ObjectOfConsumption { get; set; }
    public DateTime    MomentOfConsumption { get; set; }
    public Day         Day                 { get; set; }
}