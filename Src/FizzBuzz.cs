namespace FizzBuzzKata.Src;

public class FizzBuzz
{
    private const int FIZZ_NUMBER = 3;
    private const int BUZZ_NUMBER = 5;

    public string Convert(int number)
    {
        var result = string.Empty;

        if (IsMultipleOf(number, FIZZ_NUMBER))
            result += "Fizz";
        if (IsMultipleOf(number, BUZZ_NUMBER))
            result += "Buzz";

        return string.IsNullOrEmpty(result)
            ? number.ToString()
            : result;
    }

    private static bool IsMultipleOf(int number, int divisor)
        => number % divisor == 0;
}