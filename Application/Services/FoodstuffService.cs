using Application.Interfaces;
using Domain.Entitäten;
using Domain.Models;

namespace Application.Services;

public class FoodstuffService : BaseCrudService<FoodStuff, FoodstuffModel>
{
    public FoodstuffService(IApplicationDbContext context) : base(context) { }
}