using Domain.Interfaces;

namespace Domain.Models;

public class FoodstuffModel : INutritious
{
    public double Kcal    { get; set; }
    public double Protein { get; set; }
    public double Fett    { get; set; }
    public double Carbs   { get; set; }
}