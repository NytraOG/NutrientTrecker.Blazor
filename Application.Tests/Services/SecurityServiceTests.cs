using Application.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests.Services;

[TestClass]
public class SecurityServiceTests
{
    private SecurityService service;

    [TestInitialize]
    public void Init() => service = new SecurityService();
}