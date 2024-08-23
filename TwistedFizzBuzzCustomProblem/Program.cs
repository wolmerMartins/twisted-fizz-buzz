using TwistedFizzBuzzLib.Implementations;
using TwistedFizzBuzzLib.Models;

var printer = new Printer();
var twistedFizzBuzz = new TwistedFizzBuzz(printer, -20, 127);

twistedFizzBuzz.WithTwists(
    new List<Twist>
    {
        new Twist("Fizz", 5),
        new Twist("Buzz", 9),
        new Twist("Bar", 27)
    });

twistedFizzBuzz.Execute();
