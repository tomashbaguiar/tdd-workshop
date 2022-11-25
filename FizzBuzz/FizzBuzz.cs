using System.Text;

namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Resolve(int input)
    {
        var sb = new StringBuilder();

        if (input % 3 == 0)
        {
            sb.Append("Fizz");
        }

        if (input % 5 == 0)
        {
            sb.Append("Buzz");
        }

        return sb.Length == 0 ? input.ToString() : sb.ToString();
    }
}