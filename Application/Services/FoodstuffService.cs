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
        var foodstuff = await Context.FoodStuff
                                     .FirstOrDefaultAsync(f => f.Id == id)
                                     .ConfigureAwait(false);

        if (foodstuff is null)
            throw new EntityNotFoundException<FoodStuff>(id);

        return foodstuff;
    }

    public override async Task<FoodStuff> CreateAsync(FoodstuffModel model)
    {
        var foodstuff = new FoodStuff
        {
            Carbs   = model.Carbs,
            Protein = model.Protein,
            Fett    = model.Fett,
            Kcal    = model.Kcal,
            Name    = model.Name
        };

        await Context.FoodStuff
                     .AddAsync(foodstuff)
                     .ConfigureAwait(false);

        return foodstuff;
    }

    public override async Task<FoodStuff> UpdateAsync(FoodstuffModel model, Guid id)
    {
        var foodstuff = await GetAsync(id);

        foodstuff.Carbs   = model.Carbs;
        foodstuff.Fett    = model.Fett;
        foodstuff.Protein = model.Protein;
        foodstuff.Kcal    = model.Kcal;
        foodstuff.Name    = model.Name;
        
        return foodstuff;
    }

    public override async Task DeleteAsync(Guid id)
    {
        var foodstuff = await GetAsync(id);

        Context.FoodStuff.Remove(foodstuff);
    }

    public override async Task SaveAsync() => await Context.SaveChangesAsync()
                                                           .ConfigureAwait(false);
}