using Xunit;
using FizzBuzzKata.Src;

namespace FizzBuzzKata.Tests;

public class FizzBuzzTests
{
    //private static readonly int[] DIV3 = [3,6,9,12,15,18,21,24,27,30,33,36,39,42,45,48,51,54,57,60,63,66,69,72,75,78,81,84,87,90,93,96,99];


    [Fact]
    public void EnsureNumberIsNotZero()
    {
        int number = 0;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
                FizzBuzz.Convert(number);
            });
    }

    [Fact]
    public void EnsureNumberIsNotMinusOne()
    {
        int number = -1;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
            FizzBuzz.Convert(number);
        });
    }

    [Fact]
    public void EnsureNumberIsNotMinusTwo()
    {
        int number = -2;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
            FizzBuzz.Convert(number);
        });
    }

    [Fact]
    public void EnsureNumberIsNot101()
    {
        int number = 101;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
            FizzBuzz.Convert(number);
        });
    }

    [Fact]
    public void EnsureNumberIsNot102()
    {
        int number = 102;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
            FizzBuzz.Convert(number);
        });
    }

    [Fact]
    public void EnsureNumberIsNot103()
    {
        int number = 103;
        Assert.Throws<ArgumentOutOfRangeException>(()=>{
            FizzBuzz.Convert(number);
        });
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
        Assert.Equal(result, "Fizz");
    }
    
    [Fact]
    public void ReturnNumberSixAsFizz()
    {
        int number = 6;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Fizz");
    }
    
    [Fact]
    public void ReturnNumberNineAsFizz()
    {
        int number = 9;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Fizz");
    }
    
    [Fact]
    public void ReturnNumberTwelveAsFizz()
    {
        int number = 12;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Fizz");
    }
    
    [Fact]
    public void ReturnNumberFiveAsBuzz()
    {
        int number = 5;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Buzz");
    } 
    
    [Fact]
    public void ReturnNumberTenAsBuzz()
    {
        int number = 10;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Buzz");
    } 
    
    [Fact]
    public void ReturnNumberTwentyAsBuzz()
    {
        int number = 20;
        string result = FizzBuzz.Convert(number);
        Assert.Equal(result, "Buzz");
    } 

}