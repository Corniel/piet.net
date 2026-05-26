using Piet.Programs;
using Piet.Syntax.Compilation;
using System.Collections.Immutable;
using System.IO;

namespace Specs.Syntax.Compilation_specs;

[Explicit]
public class Compiles
{
    [TestCaseSource(nameof(Compliations))]
    public void Program(CompiledProgram program)
    {
        var compilion = program.Stream.Program().Compile(program.Name, "Piet.Programs.Compiled");

        using var file = new StreamWriter(
            $"../../../../Programs/Compiled/{program.Name}.cs",
            CSharpWriter.Encoding,
            new()
            {
                Access = FileAccess.Write,
                Mode = FileMode.Create,
            });
        var writer = new CSharpWriter(file);
        writer.Write(compilion);
        file.Flush();

        compilion.Methods.Should().NotBeEmpty();
    }

    private static readonly ImmutableArray<CompiledProgram> Compliations =
    [
        new("DayOfWeek", Streams.DayOfWeek),
        new("GnomeSort", Streams.GnomeSort),
        new("FizzBuzz", Streams.FizzBuzz),
        new("Pi", Streams.Pi),
        new("PowerFunction", Streams.PowerFunction),
    ];

    public readonly record struct CompiledProgram(string Name, Stream Stream)
    {
        public override string ToString() => Name;
    }
}
