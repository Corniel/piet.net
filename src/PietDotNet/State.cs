namespace PietDotNet;

public class State
{
    public static State Initial(Program program)
    {
        Guard.NotNull(program, nameof(program));
        return new State(Pointer.Initial, Stack.Empty, program.SelectBlock((Codel)default));
    }

    private State(Pointer pointer, Stack stack, ColourBlock block)
    {
        Pointer = pointer;
        Stack = stack;
        Block = block;
    }

    public Pointer Pointer { get; }
    public Stack Stack { get; }
    public ColourBlock Block { get; }
    public Codel Position => Pointer.Position;
    public Colour Colour => Block.Colour;
    public long Value => Block.Value;

    public State SelectBlock(ColourBlock block) => new(
         Pointer,
         Stack,
         block);

    public State PointerLeaves(ColourBlock block) => With(block.Leave(Pointer));
    public State SingleStep() => With(Pointer.SingleStep());
    public State Rotate() => With(Pointer.Rotate(1));
    public State Switch() => With(Pointer.Switch(1));
    
    internal State With(Pointer pointer, Stack stack) => new(
        pointer,
        stack,
        Block);
  
    private State With(Pointer pointer) => new(
        pointer,
        Stack,
        Block);

    internal State With(Stack stack) => new(
        Pointer,
        stack,
        Block);

    /// <inheritdoc />
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"Cursor: {Pointer}, ");
        sb.Append($"Block: {Block.Colour.Debug()}, ");
        sb.Append($"Value: {Value}, ");
        sb.Append($"Stack: {{ {string.Join(", ", Stack)} }}");

        return sb.ToString();
    }
}
