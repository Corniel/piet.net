namespace PietDotNet;

public partial struct Stack
{
    /// <summary>Pops the top two values off the stack, adds them, and
    /// pushes the result back on the stack.
    /// </summary>
    public Stack Add()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s + f));
    }

    /// <summary>Pops the top two values off the stack, calculates the
    /// second top value minus the top value, and pushes the result back on
    /// the stack.
    /// </summary>
    public Stack Subtract()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s - f));
    }

    /// <summary>Pops the top two values off the stack, multiplies them,
    /// and pushes the result back on the stack.
    /// </summary>
    public Stack Multiply()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s * f));
    }

    /// <summary>Pops the top two values off the stack, calculates the
    /// integer division of the second top value by the top value, and
    /// pushes the result back on the stack.
    /// </summary>
    /// <remarks>
    /// If a divide by zero occurs, it is handled as an implementation-
    /// dependent error, though simply ignoring the command is recommended.
    /// </remarks>
    public Stack Divide()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s / f));
    }

    /// <summary>Pops the top two values off the stack, calculates the
    /// integer division of the second top value by the top value, and
    /// pushes the result back on the stack.
    /// </summary>
    /// <remarks>
    /// If a divide by zero occurs, it is handled as an implementation-
    /// dependent error, though simply ignoring the command is recommended.
    /// </remarks>
    public Stack Modulo()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s.Modulo(f)));
    }

    /// <summary> Pops the top two values off the stack, and pushes 1 on to
    /// the stack if the second top value is greater than the top value,
    /// and pushes 0 if it is not greater.
    /// </summary>
    public Stack Greater()
    {
        var f = Buffer.Peek();
        var n = Buffer.Pop();
        var s = n.Peek();
        return new(n.Pop().Push(s > f ? 1 : 0));
    }

    /// <summary>Replaces the top value of the stack with 0 if it is
    /// non-zero, and 1 if it is zero.
    /// </summary>
    public Stack Not()
        => new(Buffer.Pop().Push(Buffer.Peek() is 0 ? 1 : 0));

    /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
    public Stack Duplicate() => Push(Peek());

    /// <summary>Pops the top two values off the stack and "rolls" the
    /// remaining stack entries to a depth equal to the second value popped,
    /// by a number of rolls equal to the first value popped.
    /// </summary>
    /// <remarks>
    /// A single roll to depth n is defined as burying the top value on the
    /// stack n deep and bringing all values above it up by 1 place. A negative
    /// number of rolls, rolls in the opposite direction. A negative depth is an
    /// error and the command is ignored. If a roll is greater than an
    /// implementation-dependent maximum stack depth, it is handled as an
    /// implementation-dependent error, though simply ignoring the command
    /// is recommended.
    /// </remarks>
    public Stack Roll()
    {
        var roll = Buffer.Peek();
        var n = Buffer.Pop();
        var depth = n.Peek();
        n = n.Pop();

        if (depth < 0) throw new NegativeDepth();
        if (depth == 0 || roll.Modulo(depth) == 0) return new(n);

        if (temp.Length < depth)
        {
            temp = new long[depth];
        }

        for (int i = 0; i < depth; i++)
        {
            temp[depth - i - 1] = n.Peek();
            n = n.Pop();
        }

        for (var i = 0; i < depth; i++)
        {
            n = n.Push(temp[(i - roll).Modulo(depth)]);
        }
        return new(n);
    }
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static long[] temp = [];
}

