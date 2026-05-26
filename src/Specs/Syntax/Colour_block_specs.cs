using Piet.Programs;
using Piet.Syntax;

namespace Specs.Syntax.Block_specs;

public class Value
{
    [Test]
    public void Equals_the_number_of_codels_of_the_block()
        => Streams.FibonacciNumbers.Program()[new(8, 9)]
        .Should().BeEquivalentTo(new
        {
            Colour = Colour.White,
            Value = 8,
        });

    [Test]
    public void Of_black_is_zero()
        => Block.Black.Value.Should().Be(0);
}
