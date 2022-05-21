﻿using Application.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Services;

[TestClass]
public abstract class BaseCrudServiceTests<TEntity, TModel>
{
    protected abstract ICrudService<TEntity, TModel> Service { get; }

    [TestMethod]
    public void GetAll_ZweiDatensätzeVorhanden_BeideDatensätzeZurückgegeben()
    {
        // Arrange
        

        // Act


        // Assert
    }
}