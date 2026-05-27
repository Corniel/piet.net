namespace Piet.Syntax.Compilation;

public sealed class BlockMethod(Block block) : Code
{
    private const string state = CompilationResult.state;

    public Block Block { get; } = block;

    public Orientations<Expression> Expressions { get; } = new();

    public void WriteTo(CSharpWriter writer)
    {
        writer.Indent().Line($"{Name(Block)}: switch ({state}.PT) // Size = {Block.Value}, Colour = {Block.Colour.Name}");
        using (writer.Indent().CodeBlock())
        {
            foreach (var (_, e) in Expressions.Where(kvp => kvp.Value is not null))
                writer.Write(e);

            writer.Indent().Line("default: return Exit;");
        }
    }

    public static string Name(Block block)
        => $"B{block.Codels[0].X:000}_{block.Codels[0].Y:000}";
}
