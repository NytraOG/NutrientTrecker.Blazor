using Domain.Entitäten;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Services;

public class FoodstuffService : ICrudService<FoodStuff, FoodstuffModel>
{
    private readonly IConnectionAdapter connectionAdapter;

    public FoodstuffService(IConnectionAdapter connectionAdapter) => this.connectionAdapter = connectionAdapter;

    public IEnumerable<FoodStuff> GetAll() => throw new NotImplementedException();

    public FoodStuff Get(Guid id) => throw new NotImplementedException();

    public FoodStuff Create(FoodstuffModel model) => throw new NotImplementedException();

    public FoodStuff Update(FoodstuffModel model, Guid id) => throw new NotImplementedException();

    public void Delete(Guid id) => throw new NotImplementedException();

    public void Save() => throw new NotImplementedException();
}