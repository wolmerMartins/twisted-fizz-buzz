using Moq;
using TwistedFizzBuzzLib;
using TwistedFizzBuzzLib.Implementations;
using TwistedFizzBuzzLib.Models;

namespace TwistedFizzBuzzTests;

public class TwistedFizzBuzzCustomTwistTest
{
    private readonly Mock<IPrinter> PrinterMock;

    public TwistedFizzBuzzCustomTwistTest()
    {
        PrinterMock = new Mock<IPrinter>();
    }

    [Fact(DisplayName = "Prints 'Poem' twice when number is multiple of '7'")]
    public void Test1()
    {
        List<Twist> twists = new List<Twist>
        {
            new Twist("Poem", 7)
        };

        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 1, 14);

        twistedFizzBuzz.WithTwists(twists);
        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Poem")),
            Times.Exactly(2));
    }

    [Fact(DisplayName = "Prints 'Writer' once for multiples of '17'")]
    public void Test2()
    {
        List<Twist> twists = new List<Twist>
        {
            new Twist("Poem", 7),
            new Twist("Writer", 17)
        };

        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 3, 17);

        twistedFizzBuzz.WithTwists(twists);
        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "Writer")),
            Times.Once);
    }

    [Fact(DisplayName = "Prints 'PoemCollege' twice for multiples of '21'")]
    public void Test3()
    {
        List<Twist> twists = new List<Twist>
        {
            new Twist("PoemCollege", 21)
        };

        var twistedFizzBuzz = new TwistedFizzBuzz(PrinterMock.Object, 21, 42, 8, 4);

        twistedFizzBuzz.WithTwists(twists);
        twistedFizzBuzz.Execute();

        PrinterMock.Verify(
            pm => pm.PrintLine(It.Is<string>(value => value == "PoemCollege")),
            Times.Exactly(2));
    }
}
