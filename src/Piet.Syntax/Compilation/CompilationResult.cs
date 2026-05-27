using Qowaiv.Diagnostics.Contracts;

namespace Piet.Syntax.Compilation;

[Mutable]
public sealed class CompilationResult(string name, string @namespace) : Code
{
    public string Name { get; } = name;
    
    public string Namespace { get; } = @namespace;

    public Dictionary<Block, BlockMethod> Methods { get; } = [];

    internal const string state = nameof(state);

    public void WriteTo(CSharpWriter writer)
    {
        writer
            .Line("#pragma warning disable")
            .Line()
            .Line("using Piet.Runtime;")
            .Line("using static Piet.Runtime.CC_DP;")
            .Line()
            .Line($"namespace {Namespace};")
            .Line()
            .Line($"public static class {Name}");

        using (writer.Indent().CodeBlock())
        {
            writer
                .Indent().Line($"private const bool Exit = true;")
                .Line()
                .Indent().Line($"public static bool Execute(State {state})");

            using (writer.Indent().CodeBlock())
            {
                writer.Write(Methods.Values.Select(WriteMethod), writer => writer.Line());
            }
        }
    }

    private static Action<CSharpWriter> WriteMethod(BlockMethod method) => writer
        => writer.Write(method);
}
