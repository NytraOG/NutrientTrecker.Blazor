﻿namespace Domain.Interfaces;

public interface INahrhaft
{
    public double Kcal    { get; set; }
    public double Protein { get; set; }
    public double Fett    { get; set; }
    public double Carbs   { get; set; }
}