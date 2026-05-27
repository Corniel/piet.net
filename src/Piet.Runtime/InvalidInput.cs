namespace Piet.Runtime;

public sealed class InvalidInput : ArgumentException
{
    public InvalidInput() : base("Invalid input.") { }
}
