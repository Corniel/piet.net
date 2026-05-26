using Piet.Runtime;
using Specs.Programs.Compiled;
using static Piet.Runtime.CC_DP;

namespace Specs.Runtime.Compiled_specs;

public class Executes
{
    [Test]
    public void Pi_program()
    {
        var io = new TestIO();
        var state = State.New(io);
        Pi.Execute(state).Should().BeTrue();
        io.OutInts.Should().BeEquivalentTo([31405L]);
    }
}
