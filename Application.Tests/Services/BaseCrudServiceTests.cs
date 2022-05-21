using Application.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Application.Tests.Services;

[TestClass]
public abstract class BaseCrudServiceTests<TEntity, TModel>
{
    protected          Mock<IApplicationDbContext>?  DBContextMock;
    protected abstract ICrudService<TEntity, TModel> Service { get; }

    [TestInitialize]
    public void Init() => DBContextMock = new Mock<IApplicationDbContext>();

    [TestMethod]
    public void GetAll_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben()
    {
        // Arrange
        
        
        // Act

        // Assert
    }
}