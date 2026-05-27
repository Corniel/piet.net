namespace Piet.Syntax.Compilation;

public sealed class BlockMethod(Block block) : Code
{
    private const string state = CompilationResult.state;

    public Block Block { get; } = block;

    public Orientations<Expression> Expressions { get; } = new();

    public bool ExitOnly => Active.All(e => e is ExitExpression);

    public IEnumerable<Expression> Active => Expressions.Where(kvp => kvp.Value is not null).Select(kvp => kvp.Value);

    public void WriteTo(CSharpWriter writer)
    {
        if (Active.Count() is 1)
        {
            Instruction(writer);
        }
        else
        {
            Instructions(writer);
        }
    }

    private void Instruction(CSharpWriter writer)
    {
        var e = Active.First();
        writer
            .Indent()
            .Write($"{Name(Block)}: ")
            .Write(e)
            .Line($" // PT = {e.PT}, Size = {Block.Value}, Colour = {Block.Colour.Name}");
    }

    private void Instructions(CSharpWriter writer)
    {
        writer.Indent().Line($"{Name(Block)}: switch ({state}.PT) // Size = {Block.Value}, Colour = {Block.Colour.Name}");
        using (writer.Indent().CodeBlock())
        {
            foreach (var e in Active)
                writer.Indent().Write($"case {e.Key}: ").Write(e).Line();
        }
    }

    public static string Name(Block block)
        => $"B{block.Codels[0].X:000}_{block.Codels[0].Y:000}";
}
