using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests.Services;

[TestClass]
public class SecurityServiceTests
{
    private SecurityService service;

    [TestInitialize]
    public void Init() => service = new SecurityService();
}