using Piet.Programs;
using Piet.Syntax;

namespace Specs.Syntax.Program_specs;

public class Canvas
{
    [Test]
    public void Off_canvas_for_negative_coordinate()
        => Streams.Fibonacci.Program()
        .OnCanvas(new(-1, 0))
        .Should().BeFalse();

    [Test]
    public void Off_canvas_for_coordinate_exeeding_program_dimensions()
        => Streams.Fibonacci.Program()
        .OnCanvas(new(0, 1204))
        .Should().BeFalse();

    [Test]
    public void On_canvas_for_border_coordinate()
        => Streams.Fibonacci.Program()
        .OnCanvas(new(9, 10))
        .Should().BeTrue();
}

public class Block_selection
{
    [Test]
    public void Border_block_is_returned_for_black_codel()
        => ((object)Streams.Fibonacci.Program()[new(2, 2)])
        .Should().Be(Block.Black);

    [Test]
    public void Border_block_is_returned_for_off_canvas_codel()
        => ((object)Streams.Fibonacci.Program()[new(-1, 0)])
        .Should().Be(Block.Black);
}
