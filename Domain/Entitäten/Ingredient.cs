namespace Domain.Entitäten;

public class Ingredient : BaseConsumableVolume
{
    public Dish Dish { get; set; }
}