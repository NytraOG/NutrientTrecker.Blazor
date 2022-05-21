using System;
using System.Linq;
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

    [TestMethod]
    public async Task CreateAsync_ModelGutBestückt_EntitätPersistiert()
    {
        // Arrange
        var model = new FoodstuffModel { Carbs = 100, Fett = 200, Protein = 300, Kcal = 400, Name = "Whey" };

        // Act
        var foodstuff = await Service.CreateAsync(model);
        await Service.SaveAsync();

        // Assert
        var result = await Service.GetAsync(foodstuff.Id);

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task CreateAsync_ModelGutBestückt_PropertiesMapped()
    {
        // Arrange
        var model = new FoodstuffModel { Carbs = 100, Fett = 200, Protein = 300, Kcal = 400, Name = "Whey" };

        // Act
        var foodstuff = await Service.CreateAsync(model);
        await Service.SaveAsync();

        // Assert
        var result = await Service.GetAsync(foodstuff.Id);

        Assert.AreEqual(model.Carbs, result.Carbs);
        Assert.AreEqual(model.Fett, result.Fett);
        Assert.AreEqual(model.Protein, result.Protein);
        Assert.AreEqual(model.Kcal, result.Kcal);
    }

    [TestMethod]
    [ExpectedException(typeof(EntityNotFoundException<FoodStuff>))]
    public async Task UpdateAsync_EntitätNichtGefunden_ThrowsException() => await Service.UpdateAsync(new FoodstuffModel(), Guid.NewGuid());

    [TestMethod]
    public async Task UpdateAsync_EntitätGefundenUndModelGutBestückt_UpdatePersistiert()
    {
        // Arrange
        var foodstuff = new FoodStuff { Name       = "Sand" };
        var model     = new FoodstuffModel { Carbs = 100, Fett = 200, Protein = 300, Kcal = 400, Name = "Whey" };

        await DBContextMock.AddAsync(foodstuff);
        await Service.SaveAsync();

        // Act 
        await Service.UpdateAsync(model, foodstuff.Id);
        await Service.SaveAsync();

        // Assert
        var result = await Service.GetAsync(foodstuff.Id);

        Assert.AreEqual(model.Carbs, result.Carbs);
        Assert.AreEqual(model.Fett, result.Fett);
        Assert.AreEqual(model.Protein, result.Protein);
        Assert.AreEqual(model.Kcal, result.Kcal);
        Assert.AreEqual(model.Name, result.Name);
    }

    [TestMethod]
    public async Task DeleteAsync_EntitätExistiert_EntitätGelöscht()
    {
        // Arrange
        var foodstuff = new FoodStuff { Name = "Pferd" };

        await DBContextMock.AddAsync(foodstuff);
        await Service.SaveAsync();

        // Act
        await Service.DeleteAsync(foodstuff.Id);
        await Service.SaveAsync();

        // Assert
        var resultSet = await Service.GetAllAsync();

        Assert.AreEqual(0, resultSet.ToList().Count);
    }
}