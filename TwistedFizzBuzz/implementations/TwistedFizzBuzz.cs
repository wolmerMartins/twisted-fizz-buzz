using TwistedFizzBuzzLib.Models;

namespace TwistedFizzBuzzLib.Implementations;

public class TwistedFizzBuzz : ITwistedFizzBuzz
{
    private readonly IPrinter Printer;

    private IEnumerable<int> Numbers;
    private List<Twist>? Twists;

    public TwistedFizzBuzz(IPrinter printer, int rangeStart, int rangeEnd)
    {
        Printer = printer;

        Numbers = GetNumbers(rangeStart, rangeEnd);
    }

    public TwistedFizzBuzz(IPrinter printer, params int[] numbers)
    {
        Printer = printer;

        Numbers = numbers;
    }

    private IEnumerable<int> GetNumbers(int rangeStart, int rangeEnd)
    {
        int start, end;

        if (rangeStart > rangeEnd)
        {
            start = rangeEnd;
            end = rangeStart;
        }
        else
        {
            start = rangeStart;
            end = rangeEnd;
        }

        return Enumerable.Range(start, end - start + 1);
    }

    private List<Twist> GetTwists(List<Twist>? twists = null)
        => twists ?? new List<Twist>
        {
            new Twist("Fizz", 3),
            new Twist("Buzz", 5)
        };

    public void WithTwists(List<Twist> twists)
    {
        Twists = twists;
    }

    public void Execute()
    {
        foreach (int num in Numbers)
        {
            string token = "";

            foreach (Twist twist in GetTwists(Twists))
            {
                if (num % twist.Divisor == 0)
                {
                    token += twist.Token;
                }
            }

            Printer.PrintLine(
                string.IsNullOrEmpty(token) ? num.ToString() : token);
        }
    }
}
