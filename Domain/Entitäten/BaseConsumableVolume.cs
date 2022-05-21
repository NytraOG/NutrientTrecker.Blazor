namespace Domain.Entitäten;

public abstract class BaseConsumableVolume
{
    public FoodStuff FoodStuff { get; set; }
    public int       Amount    { get; set; }
}