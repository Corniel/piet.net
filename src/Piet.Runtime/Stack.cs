namespace Piet.Runtime;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Diagnostics.CollectionDebugView))]
public readonly partial struct Stack : IEnumerable<long>
{
    public static readonly Stack Empty = new(-1, []);

    private readonly long[] Buffer;

    private Stack(int index, long[] buffer)
    {
        Index = index;
        Buffer = buffer;
    }

    public bool IsEmpty => Index is -1;

    /// <summary>Gets the number of items on the Stack.</summary>
    public int Count => Index + 1;

    /// <summary>The capacity of the Stack.</summary>
    public int Capacity => Buffer.Length;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int Index;

    /// <summary>Removes the top item from the Stack.</summary>
    public Stack Pop() => IsEmpty
        ? throw new InsufficientStackSize()
        : new(Index - 1, Buffer);

    /// <summary>Returns the top integer from the Stack without removing it.</summary>
    public long Peek() => IsEmpty
        ? throw new InsufficientStackSize()
        : Buffer[Index];

    /// <summary>Pushes an integer to the top of the Stack.</summary>
    public Stack Push(long integer)
    {
        if (Count == Capacity)
        {
            var capacity = IsEmpty ? 128 : Capacity;
            var copy = new long[capacity * 2];
            Array.Copy(Buffer, copy, Capacity);
            copy[Count] = integer;
            return new(Count, copy);
        }
        else
        {
            Buffer[Count] = integer;
            return new(Count, Buffer);
        }
    }
}
