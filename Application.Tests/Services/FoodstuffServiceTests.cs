using Application.Interfaces;
using Application.Services;
using Domain.Entitäten;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Services;

[TestClass]
public class FoodstuffServiceTests : BaseCrudServiceTests<FoodStuff, FoodstuffModel>
{
    protected override ICrudService<FoodStuff, FoodstuffModel> Service => new FoodstuffService(DBContextMock?.Object!);
}