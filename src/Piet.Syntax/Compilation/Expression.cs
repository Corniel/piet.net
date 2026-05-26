namespace Piet.Syntax.Compilation;

public sealed class Expression(CC_DP key, CC_DP? pt, Command cmd, int value, Block next) : Code
{
    private const string state = CompilationResult.state;

    public CC_DP Key { get; } = key;
    public CC_DP? PT { get; } = pt;
    public Command Command { get; } = cmd;
    public int Value { get; } = value;
    public Block Next { get; } = next;

    public void WriteTo(CSharpWriter writer)
    {
        writer.Indent().Write($"{Key} => {state}");
        
        if (PT.HasValue)
            writer.Write($".{PT}");

        if (!Command.Equals(Command.None))
            writer.Write($".{Command.Name}");

        if (Command.Equals(Command.Push))
            writer.Write($"({Value})");

        writer.Line($".{BlockMethod.Name(Next)},");
    }
}
