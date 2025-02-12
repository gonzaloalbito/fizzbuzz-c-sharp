namespace FizzBuzzKata.Src;

public class FizzBuzz
{
    protected const string FIZZ = "Fizz";
    protected const string BUZZ = "Buzz";
    
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
            return FIZZ+BUZZ;
        }
        if(number%3==0)
        {
            return FIZZ;
        }
        if(number%5==0)
        {
            return BUZZ;
        }
        return number.ToString();
    }
}