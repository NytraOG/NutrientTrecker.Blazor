using System;
using Domain.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests.Utils;

[TestClass]
public class HasherTests
{
    [TestMethod]
    public void GenerateHash_StringRein_PasswordHashUndSaltRaus()
    {
        // Arrange
        var input = "I bims 1 Passwort";

        // Act
        var (hashResult, saltResult) = Hasher.GenerateHash(input);

        // Assert
        Assert.IsTrue(!string.IsNullOrWhiteSpace(hashResult));
        Assert.IsTrue(!string.IsNullOrWhiteSpace(saltResult));
    }

    [TestMethod]
    public void GenerateHash_ZweiMalDerGleichStringHashed_BeideHashesGleich()
    {
        // Arrange
        var input = "I bims auch 1 Passwor";
        var (hashResult1, saltResult) = Hasher.GenerateHash(input);

        // Act
        var hashResult2 = Hasher.GenerateHash(input, saltResult);

        // Assert
        Assert.AreEqual(hashResult1, hashResult2);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GenerateHash_SaltIsNull_ThrowsException() => Hasher.GenerateHash("Henlo", null);
}