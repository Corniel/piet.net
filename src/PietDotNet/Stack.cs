using PietDotNet.Diagnostics;
using PietDotNet.Validation;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}"), DebuggerTypeProxy(typeof(CollectionDebugView))]
    public abstract class Stack : IEnumerable<long>
    {
        public static readonly Stack Empty = new EmptyStack();

        private Stack() { }

        /// <summary>Gets the number of items in the stack.</summary>
        public abstract int Count { get; }

        /// <summary>Removes the top item from the stack.</summary>
        public abstract Stack Pop();

        /// <summary>Removes the top n items from the stack.</summary>
        public Stack Pop(int repeat) => 
            repeat == 0 
            ? this 
            : Pop().Pop(repeat - 1);

        /// <summary>Returns the top integer from the stack without removing it.</summary>
        public abstract long Peek();

        /// <summary>Pushes an integer to the top of the stack.</summary>
        public Stack Push(long integer) => new NonEmptyStack(this, integer);

        /// <summary>Pushes an boolean to the top of the stack.</summary>
        public Stack Push(bool boolean) => Push(boolean ? 1 : 0);

        /// <inheritdoc />
        public abstract IEnumerator<long> GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"Count = {Count}";

        private class NonEmptyStack : Stack
        {
            private readonly Stack previous;
            private readonly long value;

            internal NonEmptyStack(Stack previous, long value)
            {
                this.previous = previous;
                this.value = value;
            }

            /// <inheritdoc />
            public override int Count => previous.Count + 1;

            /// <inheritdoc />
            public override long Peek() => value;

            /// <inheritdoc />
            public override Stack Pop() => previous;

            /// <inheritdoc />
            public override IEnumerator<long> GetEnumerator() => Enumerate().GetEnumerator();
            
            private IEnumerable<long> Enumerate()
            {
                Stack current = this;
                while (current is NonEmptyStack nonEmpty)
                {
                    yield return nonEmpty.value;
                    current = nonEmpty.previous;
                }
            }
        }

        private class EmptyStack : Stack
        {
            /// <inheritdoc />
            public override int Count => 0;

            /// <inheritdoc />
            public override IEnumerator<long> GetEnumerator() => Enumerable.Empty<long>().GetEnumerator();

            /// <inheritdoc />
            public override long Peek() => throw new InsufficientStackSize();

            /// <inheritdoc />
            public override Stack Pop() => throw new InsufficientStackSize();
        }
    }
}
