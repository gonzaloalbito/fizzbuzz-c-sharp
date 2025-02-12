using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    protected const string FIZZ = "Fizz";
    protected const string BUZZ = "Buzz";

    [Fact]
    public void EnsureNumberIsGreaterThan0()
    {
        int[] numbers = [0, -1, -2, -3, -5, -10, -15, -100, -1000];
        foreach(int number in numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>{
                    FizzBuzz.Convert(number);
                });
        }
    }

    [Fact]
    public void EnsureNumberIsLowerThan101()
    {
        int[] numbers = [101, 102, 103, 105, 1000];
        foreach(int number in numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>{
                FizzBuzz.Convert(number);
            });
        }
    }
    
    [Fact]
    public void ReturnNumberOneAsText()
    {
        int[] numbers = [1, 2, 4, 6, 7, 11, 34, 46, 57, 68, 79];
        foreach(int number in numbers)
        {
            string result = FizzBuzz.Convert(number);
            Assert.Equal(result, ""+number);
        }
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
    
    [Fact]
    public void ReturnMultiplesOfThreeAsFizz()
    {
        int[] numbers = [3, 6, 9, 12, 18, 27];
        foreach(int number in numbers)
        {
            string result = FizzBuzz.Convert(number);
            Assert.Equal(result, FIZZ);
        }
    }
    
    [Fact]
    public void ReturnMultiplesOfFiveAsBuzz()
    {
        int[] numbers = [5, 10, 20, 25, 50];
        foreach(int number in numbers)
        {
            string result = FizzBuzz.Convert(number);
            Assert.Equal(result, BUZZ);
        }
    }
    
    [Fact]
    public void ReturnMultiplesOfThreeAndFiveAsFizzBuzz()
    {
        int[] numbers = [15, 30, 45, 60, 90];
        foreach(int number in numbers)
        {
            string result = FizzBuzz.Convert(number);
            Assert.Equal(result, FIZZ+BUZZ);
        }
    }
}