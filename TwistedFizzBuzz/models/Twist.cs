namespace TwistedFizzBuzzLib.Models;

public class Twist
{
    public string Token { get; set; }
    public int Divisor { get; set; }

    public Twist(string token, int divisor)
    {
        Token = token;
        Divisor = divisor;
    }
}
