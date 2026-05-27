namespace Piet.Syntax.Compilation;

public class Expression(CC_DP key, CC_DP? pt, Command cmd, int value, Block next) : Code
{
    private const string state = CompilationResult.state;

    public CC_DP Key { get; } = key;
    public CC_DP? PT { get; } = pt;
    public Command Command { get; } = cmd;
    public int Value { get; } = value;
    public Block Next { get; } = next;

    public virtual void WriteTo(CSharpWriter writer)
    {
        writer.Write($"{state} = {state}");
        
        if (PT.HasValue)
            writer.Write($"[{PT}]");

        if (!Command.Equals(Command.None))
            writer.Write($".{Command.Name}");

        if (Command.Equals(Command.Push))
            writer.Write($"({Value})");

        if (Next == Block.Black)
        {
            writer.Write($"; return;");
        }
        else
        {
            writer.Write($"; goto {BlockMethod.Name(Next)};");
        }
    }
}
