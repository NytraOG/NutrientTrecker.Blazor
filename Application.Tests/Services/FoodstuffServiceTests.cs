using System.Threading.Tasks;
using Application.Interfaces;
using Application.Services;
using Domain.Entitäten;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Services;

[TestClass]
public class FoodstuffServiceTests : BaseCrudServiceTests<FoodStuff, FoodstuffModel>
{
    protected override ICrudService<FoodStuff, FoodstuffModel> Service => new FoodstuffService(DBContextMock!);

    [TestMethod]
    public override async Task GetAll_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben()
    {
        await DBContextMock.AddAsync(new FoodStuff { Name = "Apfel", Carbs = 10, Fett = 20, Kcal = 30, Protein = 50 });
        await DBContextMock.AddAsync(new FoodStuff { Name = "Brot", Carbs  = 10, Fett = 20, Kcal = 30, Protein = 50 });
        await DBContextMock.SaveChangesAsync();

        await base.GetAll_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben();
    }
}