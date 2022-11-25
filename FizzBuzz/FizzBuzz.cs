namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Resolve(int input)
    {
        return input % 3 == 0 ?"Fizz" : "Buzz";
    }
}