namespace FizzBuzzKata.Src;

public class FizzBuzz
{
    public static string Convert(int number)
    {
        if(number<=0)
        {
            throw new ArgumentOutOfRangeException("Number should be greater than zero");
        }
        if(number>=101)
        {
            throw new ArgumentOutOfRangeException("Number should be lower than 101");
        }
        if(number%15==0)
        {
            return "FizzBuzz";
        }
        if(number%3==0)
        {
            return "Fizz";
        }
        if(number%5==0)
        {
            return "Buzz";
        }
        return number.ToString();
    }
}