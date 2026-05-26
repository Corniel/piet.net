namespace Piet.Syntax;

[DebuggerDisplay("Count = 8")]
[DebuggerTypeProxy(typeof(Diagnostics.CollectionDebugView))]
public sealed class Orientations<T> : IReadOnlyCollection<KeyValuePair<CC_DP, T>>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T[] Lookup = new T[8];

    public T this[Cursor cursor] => this[cursor.PT];

    public T this[CC_DP pt]
    {
        get => Lookup[(int)pt];
        set => Lookup[(int)pt] = value;
    }

    /// <inheritdoc />
    public int Count => 8;

    /// <inheritdoc />
    public IEnumerator<KeyValuePair<CC_DP, T>> GetEnumerator() => Lookup
        .Select((val, key) => new KeyValuePair<CC_DP, T>((CC_DP)key, val))
        .GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
