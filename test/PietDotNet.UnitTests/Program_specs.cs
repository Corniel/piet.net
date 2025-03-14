using PietDotNet.Tests.Tooling;

namespace Program_specs;

public class Canvas
{
    [Test]
    public void Off_canvas_for_negative_coordinate()
    {
        var program = Runner.Load("fibonacci_numbers.gif");
        Assert.False(program.OnCanvas(new Codel(-1, 0)));
    }

    [Test]
    public void Off_canvas_for_coordinate_exeeding_program_dimensions()
    {
        var program = Runner.Load("fibonacci_numbers.gif");
        Assert.False(program.OnCanvas(new Codel(0, 1204)));
    }

    [Test]
    public void On_canvas_for_border_coordinate()
    {
        var program = Runner.Load("fibonacci_numbers.gif");
        Assert.True(program.OnCanvas(new Codel(9, 10)));
    }
}

public class Block_selection
{ 
    [Test]
    public void Border_block_is_returned_for_black_codel()
    {
        var program = Runner.Load("fibonacci_numbers.gif");

        Assert.AreEqual(ColourBlock.Border,  program.SelectBlock(new Codel(2, 2)));
    }

    [Test]
    public void Border_block_is_returned_for_off_canvas_codel()
    {
        var program = Runner.Load("fibonacci_numbers.gif");

        Assert.AreEqual(ColourBlock.Border, program.SelectBlock(new Codel(-1, 0)));
    }
}
