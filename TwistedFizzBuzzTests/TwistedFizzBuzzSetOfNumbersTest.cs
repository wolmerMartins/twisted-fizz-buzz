using Moq;
using TwistedFizzBuzzLib;
using TwistedFizzBuzzLib.Implementations;

namespace TwistedFizzBuzzTests;

public class TwistedFizzBuzzSetOfNumbersTest
{
    private readonly Mock<IPrinter> PrinterMock;

    public TwistedFizzBuzzSetOfNumbersTest()
    {
        PrinterMock = new Mock<IPrinter>();
    }

    [Fact(DisplayName = "Prints the words for a random set of numbers")]
    public void Test1()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, -5, 6, 300, 12, 15);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.IsAny<string>()),
            Times.Exactly(5));
    }

    [Fact(DisplayName = "Prints 'Fizz' twice for the given set of number")]
    public void Test2()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, -5, 6, 300, 12, 15);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Fizz")),
            Times.Exactly(2));
    }

    [Fact(DisplayName = "Prints 'Buzz' once for the given set of numbers")]
    public void Test3()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, -5, 6, 300, 12, 15);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Buzz")),
            Times.Once);
    }

    [Fact(DisplayName = "Prints 'FizzBuzz' twice for the given set of numbers")]
    public void Test4()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, -5, 6, 300, 12, 15);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "FizzBuzz")),
            Times.Exactly(2));
    }
}
