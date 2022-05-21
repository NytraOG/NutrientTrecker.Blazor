using Application.Exceptions;
using Application.Interfaces;
using Domain.Entitäten;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class FoodstuffService : BaseCrudService<FoodStuff, FoodstuffModel>
{
    public FoodstuffService(IApplicationDbContext context) : base(context) { }

    public override async Task<IEnumerable<FoodStuff>> GetAllAsync() => Context.FoodStuff;

    public override async Task<FoodStuff> GetAsync(Guid id)
    {
        var foodstuff = await Context.FoodStuff.FirstOrDefaultAsync(f => f.Id == id);

        if (foodstuff is null)
            throw new EntityNotFoundException<FoodStuff>(id);

        return foodstuff;
    }
}