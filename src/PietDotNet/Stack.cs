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
        private long[] stack = new long[16];

        /// <summary>Gets the current total of items in the stack.</summary>
        public int Count { get; private set; }

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

        public bool HasAny() => Count != 0;
        public bool HasMultiple() => Count > 1;

        public void Roll(int rollCount, int depth)
        {
            Guard.NotNegative(depth, nameof(depth));

            if(depth > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(depth), "Depth can not be bigger then the stack size.");
            }

            // Everything will stay at the same place.
            if (rollCount.Mod(depth) == 0)
            {
                return;
            }

            var start = Count - depth;

            var buffer = new long[depth];

            Array.Copy(stack, start, buffer, 0, depth);

            for (var d = 0; d < depth; d++)
            {
                var value = buffer[d];
                var target = start + (d - rollCount).Mod(depth);
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
            if(Count == stack.Length)
            {
                var extended = new long[Count << 1];
                Array.Copy(stack, extended, Count);
                stack = extended;
            }
            stack[Count++] = integer;
        }

        /// <summary>Pushes an boolean to the top of the stack.</summary>
        public void Push(bool boolean) => Push(boolean ? 1 : 0);

        /// <summary>Clears the stack.</summary>
        public void Clear() => Count = 0;

        #region DEBUG
        public IEnumerator<long> GetEnumerator()
        {
            return stack.Take(Count).OrderByDescending(item => item).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"Count = {Count}";

        #endregion
    }
}
