using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    //private static readonly int[] DIV3 = [3,6,9,12,15,18,21,24,27,30,33,36,39,42,45,48,51,54,57,60,63,66,69,72,75,78,81,84,87,90,93,96,99];
    
    [Fact]
    public void ReturnNumberOneAsText()
    {
        int number = 1;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "1");
    }
    
    [Fact]
    public void ReturnNumberTwoAsText()
    {
        int number = 2;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "2");
    }
    
    [Fact]
    public void ReturnNumberFourAsText()
    {
        int number = 4;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "4");
    }
}