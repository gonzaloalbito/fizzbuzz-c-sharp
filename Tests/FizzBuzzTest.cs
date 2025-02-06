using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void DemoTest()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Act
        var result = fizzBuzz.Convert();

        // Assert
        Assert.Equal(null, result);
    }
}