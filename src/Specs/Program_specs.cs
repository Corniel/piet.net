namespace Program_specs;

public class Canvas
{
    [Test]
    public void Off_canvas_for_negative_coordinate() 
        => Programs.FibonacciNumbers
        .OnCanvas(new(-1, 0))
        .Should().BeFalse();

    [Test]
    public void Off_canvas_for_coordinate_exeeding_program_dimensions() 
        => Programs.FibonacciNumbers
        .OnCanvas(new(0, 1204))
        .Should().BeFalse();

    [Test]
    public void On_canvas_for_border_coordinate()
        => Programs.FibonacciNumbers
        .OnCanvas(new(9, 10))
        .Should().BeTrue();
}

public class Block_selection
{ 
    [Test]
    public void Border_block_is_returned_for_black_codel()
        => ((object)Programs.FibonacciNumbers
        .SelectBlock(new Codel(2, 2)))
        .Should().Be(ColourBlock.Border);

    [Test]
    public void Border_block_is_returned_for_off_canvas_codel()
        => ((object)Programs.FibonacciNumbers
        .SelectBlock(new Codel(-1, 0)))
        .Should().Be(ColourBlock.Border);
}
