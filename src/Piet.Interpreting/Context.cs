using Piet.Interpreting.Logging;
using Piet.Syntax;

namespace Piet.Interpreting;

public ref struct Context
{
    public required State State { get; set; }
    public required Logger Logger { get; init; }
    public Block Block { get; set; }

    public required long MaxRuns { get; set; }

    public static Context Default() => new()
    {
        State = State.New(),
        Logger = Logger.Console(),
        Block = Block.Black,
        MaxRuns = int.MaxValue,
    };
}
