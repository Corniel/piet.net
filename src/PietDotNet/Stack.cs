using PietDotNet.Diagnostics;
using System.Collections.Immutable;

namespace PietDotNet;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView))]
public readonly partial struct Stack : IEnumerable<long>
{
    public static readonly Stack Empty = new([]);

    private readonly ImmutableStack<long> Buffer;

    private Stack(ImmutableStack<long> buffer) => Buffer = buffer;

    public bool IsEmpty => Buffer.IsEmpty;

    /// <summary>Gets the number of items in the stack.</summary>
    public int Count => Buffer.Count();

    /// <summary>Removes the top item from the stack.</summary>
    public Stack Pop() => Buffer.IsEmpty
        ? throw new InsufficientStackSize()
        : new(Buffer.Pop());

    /// <summary>Returns the top integer from the stack without removing it.</summary>
    public long Peek() => Buffer.IsEmpty
        ? throw new InsufficientStackSize()
        :  Buffer.Peek();

    /// <summary>Pushes an integer to the top of the stack.</summary>
    public Stack Push(long integer) => new(Buffer.Push(integer));

    /// <inheritdoc />
    public IEnumerator<long> GetEnumerator() => Buffer.AsEnumerable().GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
