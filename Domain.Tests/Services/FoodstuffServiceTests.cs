using Domain.Interfaces;
using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Domain.Tests.Services;

[TestClass]
public class FoodstuffServiceTests
{
    private Mock<IConnectionAdapter> adapterMock;
    private FoodstuffService         service;

    [TestInitialize]
    public void Init()
    {
        adapterMock = new Mock<IConnectionAdapter>();
        service     = new FoodstuffService(adapterMock.Object);
    }
}