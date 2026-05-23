namespace Colour_block_specs;

public class Value
{
    [Test]
    public void Equals_the_number_of_codels_of_the_block()
    {
        var program = Programs.FibonacciNumbers;
        object block = program.SelectBlock(new Codel(8, 9));
        block.Should().BeEquivalentTo(new
        {
            Colour = Colour.White,
            Value = 8,
        });    
    }

    [Test]
    public void Of_border_block_is_zero()
        => ColourBlock.Border.Value.Should().Be(0);
}

public class Edge
{
    [TestCase(0, 3, DirectionPointer.left, /*..*/ CodelChooser.left)]
    [TestCase(0, 1, DirectionPointer.left, /*..*/ CodelChooser.right)]
    [TestCase(4, 1, DirectionPointer.right, /*.*/ CodelChooser.left)]
    [TestCase(4, 3, DirectionPointer.right, /*.*/ CodelChooser.right)]
    [TestCase(1, 0, DirectionPointer.top, /*...*/ CodelChooser.left)]
    [TestCase(3, 0, DirectionPointer.top, /*...*/ CodelChooser.right)]
    [TestCase(3, 4, DirectionPointer.down, /*..*/ CodelChooser.left)]
    [TestCase(1, 4, DirectionPointer.down, /*..*/ CodelChooser.right)]
    public void From_complex_form(int x, int y, DirectionPointer dp, CodelChooser cc)
    {
        var program = Runner.Load("Snippets.edge.png");
        var block = program.SelectBlock(new Codel(2, 2));
        var pointer = Pointer.Initial.Rotate((int)dp).Switch((int)cc);

        block.Edge(pointer).Should().Be(new Codel(x, y));
    }

    [TestCase(DirectionPointer.left, /*..*/ CodelChooser.left)]
    [TestCase(DirectionPointer.left, /*..*/ CodelChooser.right)]
    [TestCase(DirectionPointer.right, /*.*/ CodelChooser.left)]
    [TestCase(DirectionPointer.right, /*.*/ CodelChooser.right)]

    [TestCase(DirectionPointer.top, /*...*/ CodelChooser.left)]
    [TestCase(DirectionPointer.top, /*...*/ CodelChooser.right)]
    [TestCase(DirectionPointer.down, /*..*/ CodelChooser.left)]
    [TestCase(DirectionPointer.down, /*..*/ CodelChooser.right)]
    public void From_1x1_form(DirectionPointer dp, CodelChooser cc)
    {
        var codel = new Codel(9, 0);
        var program = Programs.FibonacciNumbers;
        var block = program.SelectBlock(codel);
        var pointer = Pointer.Initial.Rotate((int)dp).Switch((int)cc);
        
        block.Edge(pointer).Should().Be(codel);
    }
}
