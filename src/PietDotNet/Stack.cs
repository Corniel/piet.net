using PietDotNet.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}"), DebuggerTypeProxy(typeof(CollectionDebugView))]
    public class Stack : IEnumerable<long>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long[] stack = new long[4];

        /// <summary>Creates a new <see cref="Stack"/>.</summary>
        public Stack(int maxSize = int.MaxValue)
        {
            MaxSize = Guard.Positive(maxSize, nameof(maxSize));
        }

        public int MaxSize { get; }

        /// <summary>Gets the current total of items in the stack.</summary>
        public int Count { get; private set; }

        /// <summary>Gets a value based on index.</summary>
        /// <param name="index">
        /// The index of the stack.
        /// </param>
        /// <remarks>
        /// Index 0 is the top value of the stack.
        /// </remarks>
        public long this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return stack[Count - 1 - index];
            }
        }

        /// <summary>Returns true if the stack has at least one item.</summary>
        public bool HasAny() => Count != 0;

        /// <summary>Returns true if the stack has at least two items.</summary>
        public bool HasMultiple() => Count > 1;

        public void Roll(int rollCount, int depth)
        {
            Guard.NotNegative(depth, nameof(depth));

            if(depth > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(depth), "Depth can not be bigger then the stack size.");
            }

            var roll = rollCount.Mod(depth);

            // Everything will stay at the same place.
            if (roll == 0)
            {
                return;
            }

            ExtendIfRequired(depth);

            var start = Count - depth;

            Array.Copy(stack, start, stack, Count, depth);

            for (var d = 0; d < depth; d++)
            {
                var value = stack[Count + d];
                var target = start + (d - roll).Mod(depth);
                stack[target] = value;
            }
        }

        /// <summary>Removes and returns the top integer from the stack.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public long PopInt() => stack[--Count];

        /// <summary>Removes and returns the top <see cref="char"/> from the stack.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public char PopChar() => (char)stack[--Count];

        /// <summary>Returns the top integer from the stack without removing it.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public long Peek() => stack[Count - 1];

        /// <summary>Pushes an integer to the top of the stack.</summary>
        public void Push(long integer)
        {
            ExtendIfRequired();
            stack[Count++] = integer;
        }

        private void ExtendIfRequired(long extra = 1)
        {
            var required = Count + extra;

            if (required > MaxSize)
            {
                throw new StackOverflowException(MaxSize == int.MaxValue ? "Requires more items on the stack than possible" : "Requires more items on the stack than allowed.");
            }

            if (required > stack.Length)
            {
                var length = Math.Min(MaxSize, Count * 2L);
                var extended = new long[length];
                Array.Copy(stack, extended, Count);
                stack = extended;
            }
        }

        /// <summary>Pushes an boolean to the top of the stack.</summary>
        public void Push(bool boolean) => Push(boolean ? 1 : 0);

        /// <summary>Clears the stack.</summary>
        public void Clear() => Count = 0;

        #region DEBUG
        public IEnumerator<long> GetEnumerator()
        {
            return stack.Take(Count).Reverse().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"Count = {Count}";

        #endregion
    }
}
