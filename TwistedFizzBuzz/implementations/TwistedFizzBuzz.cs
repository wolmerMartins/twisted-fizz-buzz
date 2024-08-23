namespace TwistedFizzBuzzLib.Implementations;

public class TwistedFizzBuzz : ITwistedFizzBuzz
{
    private readonly IPrinter Printer;

    private IEnumerable<int> Numbers;

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

    public void Execute()
    {
        foreach (int num in Numbers)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Printer.PrintLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Printer.PrintLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Printer.PrintLine("Buzz");
            }
            else
            {
                Printer.PrintLine(num.ToString());
            }
        }
    }
}
