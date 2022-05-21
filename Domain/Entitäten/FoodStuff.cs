using Domain.Interfaces;

namespace Domain.Entitäten;

public class FoodStuff : Base, INutritious
{
    public FoodStuff() => Consumed = new List<Consumed>();

    public List<Consumed> Consumed { get; set; }

    //public Image  Image   { get; set; }
    //public Image  Thumbnail   { get; set; }
    public double Kcal    { get; set; }
    public double Protein { get; set; }
    public double Fett    { get; set; }
    public double Carbs   { get; set; }
}