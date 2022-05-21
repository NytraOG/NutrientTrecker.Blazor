using Domain.Interfaces;

namespace Domain.Entitäten;

public class Dish : Base, INutritious
{
    public Dish() => Ingredients = new List<Ingredient>();

    public List<Ingredient> Ingredients { get; set; }
    public double           Kcal        { get; set; }
    public double           Protein     { get; set; }
    public double           Fett        { get; set; }
    public double           Carbs       { get; set; }
}