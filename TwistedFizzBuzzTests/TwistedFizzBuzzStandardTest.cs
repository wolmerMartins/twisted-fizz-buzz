using Moq;
using TwistedFizzBuzzLib;
using TwistedFizzBuzzLib.Implementations;

namespace TwistedFizzBuzzTests;

public class TwistedFizzBuzzStandardTest
{
    private readonly Mock<IPrinter> PrinterMock;

    public TwistedFizzBuzzStandardTest()
    {
        PrinterMock = new Mock<IPrinter>();
    }

    [Fact(DisplayName = "Prints to the console 100 times")]
    public void Test1()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 1, 100);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.IsAny<string>()),
            Times.Exactly(100));
    }

    [Fact(DisplayName = "Prints to the console 40 times")]
    public void Test2()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 11, 50);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.IsAny<string>()),
            Times.Exactly(40));
    }

    [Fact(DisplayName = "Prints to the console 36 times")]
    public void Test3()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, -2, -37);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.IsAny<string>()),
            Times.Exactly(36));
    }

    [Fact(DisplayName = "Prints 27 'Fizz' words in 100 prints")]
    public void Test4()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 1, 100);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Fizz")),
            Times.Exactly(27));
    }

    [Fact(DisplayName = "Prints 14 'Buzz' words in 100 prints")]
    public void Test5()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 1, 100);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Buzz")),
            Times.Exactly(14));
    }

    [Fact(DisplayName = "Prints 10 'FizzBuzz' workds in 100 prints")]
    public void Test6()
    {
        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 1, 100);

        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "FizzBuzz")),
            Times.Exactly(6));
    }
}
