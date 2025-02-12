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
    
    [Fact]
    public void ReturnNumberThreeAsFizz()
    {
        int number = 3;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ);
    }
    
    [Fact]
    public void ReturnNumberSixAsFizz()
    {
        int number = 6;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ);
    }
    
    [Fact]
    public void ReturnNumberNineAsFizz()
    {
        int number = 9;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ);
    }
    
    [Fact]
    public void ReturnNumberTwelveAsFizz()
    {
        int number = 12;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ);
    }
    
    [Fact]
    public void ReturnNumberFiveAsBuzz()
    {
        int number = 5;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, BUZZ);
    }
    
    [Fact]
    public void ReturnNumberTenAsBuzz()
    {
        int number = 10;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, BUZZ);
    }
    
    [Fact]
    public void ReturnNumberTwentyAsBuzz()
    {
        int number = 20;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, BUZZ);
    }
    
    [Fact]
    public void ReturnNumberFifteenAsFizzBuzz()
    {
        int number = 15;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ+BUZZ);
    }
    
    [Fact]
    public void ReturnNumberThirteenAsFizzBuzz()
    {
        int number = 30;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ+BUZZ);
    }
    
    [Fact]
    public void ReturnNumberFourtyfiveAsFizzBuzz()
    {
        int number = 45;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ+BUZZ);
    }
    
    [Fact]
    public void ReturnNumberSixteenAsFizzBuzz()
    {
        int number = 60;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, FIZZ+BUZZ);
    }

}