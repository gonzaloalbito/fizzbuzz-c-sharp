using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Act
        var result = fizzBuzz.Convert(1);

        // Assert
        Assert.Equal("1", result);
    }
}