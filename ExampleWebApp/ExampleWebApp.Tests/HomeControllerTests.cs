using System;
using ExampleWebApp.WebApp.Controllers;
using Xunit;

namespace ExampleWebApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeControllerHomeNotNull()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.NotNull(result);
        }
    }
}
