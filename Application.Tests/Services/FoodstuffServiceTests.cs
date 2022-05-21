using System;
using System.Threading.Tasks;
using Application.Exceptions;
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
    [ExpectedException(typeof(EntityNotFoundException<FoodStuff>))]
    public async Task GetAsync_EntitätNichtDa_ThrowsException()
    {
        // Act & Assert
        var _ = await Service.GetAsync(Guid.NewGuid());
    }

    [TestMethod]
    public override async Task GetAllAsync_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben()
    {
        await DBContextMock.AddAsync(new FoodStuff { Name = "Apfel", Carbs = 10, Fett = 20, Kcal = 30, Protein = 50 });
        await DBContextMock.AddAsync(new FoodStuff { Name = "Brot", Carbs  = 10, Fett = 20, Kcal = 30, Protein = 50 });
        await DBContextMock.SaveChangesAsync();

        await base.GetAllAsync_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben();
    }

    [TestMethod]
    public async Task GetAsync_DatensatzVorhanden_DatensatzZurückgegeben()
    {
        // Arrange
        var foodstuff = new FoodStuff { Name = "Kirsche" };

        await DBContextMock.AddAsync(foodstuff);
        await DBContextMock.SaveChangesAsync();

        // Act
        var result = await Service.GetAsync(foodstuff.Id);

        // Assert
        Assert.AreEqual(foodstuff.Id, result.Id);
    }
}