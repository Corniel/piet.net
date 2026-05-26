namespace Piet.Runtime;

public partial struct Stack
{
    /// <summary>Pops the top two values off the Stack, adds them, and
    /// pushes the result back on the Stack.
    /// </summary>
    public Stack Add()
    {
        if (Index < 1) throw new InsufficientStackSize();

        Buffer[Index - 1] += Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, calculates the
    /// second top value minus the top value, and pushes the result back on
    /// the Stack.
    /// </summary>
    public Stack Subtract()
    {
        if (Index < 1) throw new InsufficientStackSize();

        Buffer[Index - 1] -= Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, multiplies them,
    /// and pushes the result back on the Stack.
    /// </summary>
    public Stack Multiply()
    {
        if (Index < 1) throw new InsufficientStackSize();

        Buffer[Index - 1] *= Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, calculates the
    /// integer division of the second top value by the top value, and
    /// pushes the result back on the Stack.
    /// </summary>
    /// <remarks>
    /// If a divide by zero occurs, it is handled as an implementation-
    /// dependent error, though simply ignoring the command is recommended.
    /// </remarks>
    public Stack Divide()
    {
        if (Index < 1) throw new InsufficientStackSize();

        Buffer[Index - 1] /= Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, calculates the
    /// integer division of the second top value by the top value, and
    /// pushes the result back on the Stack.
    /// </summary>
    /// <remarks>
    /// If a divide by zero occurs, it is handled as an implementation-
    /// dependent error, though simply ignoring the command is recommended.
    /// </remarks>
    public Stack Modulo()
    {
        if (Index < 1) throw new InsufficientStackSize();

        Buffer[Index - 1] = Buffer[Index - 1].Modulo(Buffer[Index]);
        return new(Index - 1, Buffer);
    }

    /// <summary> Pops the top two values off the Stack, and pushes 1 on to
    /// the Stack if the second top value is greater than the top value,
    /// and pushes 0 if it is not greater.
    /// </summary>
    public Stack Greater()
    {
        if (Index < 1) throw new InsufficientStackSize();

        var f = Buffer[Index];
        var s = Buffer[Index - 1];
        Buffer[Index - 1] = s > f ? 1 : 0;
        return new(Index - 1, Buffer);
    }

    /// <summary>Replaces the top value of the Stack with 0 if it is
    /// non-zero, and 1 if it is zero.
    /// </summary>
    public Stack Not()
    {
        if (Index is -1) throw new InsufficientStackSize();

        Buffer[Index] = Buffer[Index] is 0 ? 1 : 0;
        return this;
    }

    /// <summary> Pushes a copy of the top value on the Stack on to the Stack.</summary>
    public Stack Duplicate()
        => Push(Peek());

    /// <summary>Pops the top two values off the Stack and "rolls" the
    /// remaining Stack entries to a depth equal to the second value popped,
    /// by a number of rolls equal to the first value popped.
    /// </summary>
    /// <remarks>
    /// A single roll to depth n is defined as burying the top value on the
    /// Stack n deep and bringing all values above it up by 1 place. A negative
    /// number of rolls, rolls in the opposite direction. A negative depth is an
    /// error and the command is ignored. If a roll is greater than an
    /// implementation-dependent maximum Stack depth, it is handled as an
    /// implementation-dependent error, though simply ignoring the command
    /// is recommended.
    /// </remarks>
    public Stack Roll()
    {
        if (Index < 1) throw new InsufficientStackSize();

        var index = Index - 2;
        var roll = Buffer[Index];
        var depth = Buffer[Index - 1];

        if (depth < 0) throw new NegativeDepth();
        if (depth == 0 || roll.Modulo(depth) == 0) return new(Index - 2, Buffer);
        if (depth > index + 1) throw new InsufficientStackSize();

        var offset = index - depth + 1;

        if (temp.Length < depth)
#pragma warning disable S2696 // Static field is used as global buffer
            temp = new long[depth];
#pragma warning restore S2696

        Array.Copy(Buffer, offset, temp, 0, depth);

        for (int i = 0; i < depth; i++)
        {
            Buffer[offset + i] = temp[(i - roll).Modulo(depth)];
        }
        return new(index, Buffer);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static long[] temp = [];
}
