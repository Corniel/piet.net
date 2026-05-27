using System.Runtime.CompilerServices;

namespace Piet.Runtime;

public partial struct Stack
{
    /// <summary>Pops the top two values off the Stack, adds them, and
    /// pushes the result back on the Stack.
    /// </summary>
    public Stack Add()
    {
        if (Index < 1) return Ignore();

        Buffer[Index - 1] += Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, calculates the
    /// second top value minus the top value, and pushes the result back on
    /// the Stack.
    /// </summary>
    public Stack Subtract()
    {
        if (Index < 1) return Ignore();

        Buffer[Index - 1] -= Buffer[Index];
        return new(Index - 1, Buffer);
    }

    /// <summary>Pops the top two values off the Stack, multiplies them,
    /// and pushes the result back on the Stack.
    /// </summary>
    public Stack Multiply()
    {
        if (Index < 1) return Ignore();

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
        if (Index < 1) return Ignore();

        var divisor = Buffer[Index];
        
        if (divisor is 0) return Ignore();

        Buffer[Index - 1] /= divisor;
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
        if (Index < 1) return Ignore();

        var modulo = Buffer[Index];

        if (modulo is 0) return Ignore();

        Buffer[Index - 1] = Buffer[Index - 1].Modulo(modulo);
        return new(Index - 1, Buffer);
    }

    /// <summary> Pops the top two values off the Stack, and pushes 1 on to
    /// the Stack if the second top value is greater than the top value,
    /// and pushes 0 if it is not greater.
    /// </summary>
    public Stack Greater()
    {
        if (Index < 1) return Ignore();

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
        if (Index is -1) return Ignore();

        Buffer[Index] = Buffer[Index] is 0 ? 1 : 0;
        return this;
    }

    /// <summary> Pushes a copy of the top value on the Stack on to the Stack.</summary>
    public Stack Duplicate()
        => Index is -1
        ? Ignore()
        : Push(Buffer[Index]);

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
        if (Index < 1) return Ignore();

        var index = Index - 2;
        var roll = Buffer[Index];
        var depth = (int)Buffer[Index - 1];

        if (depth < 0 || depth > index + 1) return Ignore();

        var step = depth is 0 ? 0 : (int)roll.Modulo(depth);
        if (step is 0) return new(Index - 2, Buffer);

        var offset = index - depth + 1;

        // Example with STEP 2
        // [offset], A, B, C, D, E // initial
        // [offset], E, D, C, B, A // reverse depth
        // [offset], D, E, C, B, A // reverse step
        // [offset], D, E, A, B, C // reverse remainder of depth
        Array.Reverse(Buffer, offset, depth);
        Array.Reverse(Buffer, offset, step);
        Array.Reverse(Buffer, offset + step,  depth - step);

        return new(index, Buffer);
    }

    /// <summary>Ignore command.</summary>
    /// <remarks>
    /// <![CDATA[
    /// From the specification: 
    /// > Any operations which cannot be performed (such as popping values when
    /// > not enough are on the stack) are simply ignored, and processing
    /// > continues with the next command.
    /// ]]>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Stack Ignore() => this;
}
