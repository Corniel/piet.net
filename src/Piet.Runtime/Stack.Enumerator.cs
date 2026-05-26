using System.Diagnostics.CodeAnalysis;

namespace Piet.Runtime;

public partial struct Stack
{
    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    public Enumerator GetEnumerator() => new(this);

    /// <inheritdoc />
    IEnumerator<long> IEnumerable<long>.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public struct Enumerator : IEnumerator<long>
    {
        internal Enumerator(Stack Stack)
        {
            Index = Stack.Count;
            Buffer = Stack.Buffer;
        }

        private int Index;
        private readonly long[] Buffer;

        /// <inheritdoc />
        public readonly long Current => Buffer[Index];

        /// <inheritdoc />
        [ExcludeFromCodeCoverage(Justification = "Legacy contact")]
        readonly object IEnumerator.Current => Current;

        /// <inheritdoc />
        public bool MoveNext() => --Index >= 0;

        /// <inheritdoc />
        public readonly void Dispose() { /* Nothing to dispose. */}

        /// <inheritdoc />
        [ExcludeFromCodeCoverage(Justification = "Legacy contact")]
        public void Reset() => throw new NotSupportedException();
    }
}
