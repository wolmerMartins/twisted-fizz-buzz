namespace TwistedFizzBuzzLib.Implementations;

public class Printer : IPrinter
{
    public void PrintLine(string value)
    {
        Console.WriteLine(value);
    }
}
