using Application.Interfaces;
using Application.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Application.Tests.Services;

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