using Domain.Interfaces;

namespace Domain.Entitäten;

public class LogEntry : Base, INutritious
{
    public string   ObjectOfConsumption { get; set; }
    public DateTime MomentOfConsumption { get; set; }
    public Day      Day                 { get; set; }
    public double   Kcal                { get; set; }
    public double   Protein             { get; set; }
    public double   Fett                { get; set; }
    public double   Carbs               { get; set; }
}