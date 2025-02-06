using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void Convert_ShouldReturnNumberAsString_WhenNotMultipleOfThreeOrFive(int input, string expected)
    {
        var fizzBuzz = new FizzBuzz();

        var result = fizzBuzz.Convert(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void Convert_ShouldReturnFizz_WhenMultipleOfThree(int input)
    {
        var fizzBuzz = new FizzBuzz();

        var result = fizzBuzz.Convert(input);

        Assert.Equal("Fizz", result);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void Convert_ShouldReturnBuzz_WhenMultipleOfFive(int input)
    {
        var fizzBuzz = new FizzBuzz();

        var result = fizzBuzz.Convert(input);

        Assert.Equal("Buzz", result);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void Convert_ShouldReturnFizzBuzz_WhenMultipleOfThreeAndFive(int input)
    {
        var fizzBuzz = new FizzBuzz();

        var result = fizzBuzz.Convert(input);

        Assert.Equal("FizzBuzz", result);
    }
}