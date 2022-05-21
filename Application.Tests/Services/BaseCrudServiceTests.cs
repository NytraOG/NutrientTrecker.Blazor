using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Services;

[TestClass]
public abstract class BaseCrudServiceTests<TEntity, TModel>
{
    protected          MemoryDbContext         DBContextMock;
    protected abstract ICrudService<TEntity, TModel> Service { get; }

    [TestInitialize]
    public void Init() => DBContextMock = TestUtils.CreateMemoryContext();

    [TestMethod]
    public virtual async Task GetAll_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben()
    {
        // Act
        var resultSet = await Service.GetAllAsync();

        // Assert
        Assert.AreEqual(2, resultSet.Count());
    }
}