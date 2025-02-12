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
        if(number%3==0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}