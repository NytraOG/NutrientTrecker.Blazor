namespace Domain.Entitäten;

public abstract class BaseConsumableVolume : Base
{
    public FoodStuff FoodStuff { get; set; }
    public int       Amount    { get; set; }
}