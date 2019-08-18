using api;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class ExampleControllerTests
    {
        [Test]
        public void Should_ReturnBadRequest_When_IncorrectModel()
        {
            // Arrange
            var model = new ExampleCommand()
            {
                Type = 0
            };

            // Act
            var controller = new ExampleController();

            var result = controller.Post(model);

            // Assert
            var okObjectResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
            okObjectResult.StatusCode.Should().Be(400);
        }
    }
}
