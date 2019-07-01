using PietDotNet.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}"), DebuggerTypeProxy(typeof(CollectionDebugView))]
    public class Stack : IEnumerable<long>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Stack<long> stack = new Stack<long>();

        /// <summary>Gets the current total of items in the stack.</summary>
        public int Count => stack.Count;

        public bool HasAny() => Count != 0;
        public bool HasMultiple() => Count > 1;

        /// <summary>Removes and returns the top integer from the stack.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public long PopInt() => stack.Pop();

        /// <summary>Removes and returns the top <see cref="char"/> from the stack.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public char PopChar() => (char)stack.Pop();

        /// <summary>Returns the top integer from the stack without removing it.</summary>
        /// <returns>
        /// null if empty, otherwise the top item of the stack.
        /// </returns>
        public long Peek() => stack.Peek();

        /// <summary>Pushes an integer to the top of the stack.</summary>
        public void Push(long integer) => stack.Push(integer);

        /// <summary>Pushes an boolean to the top of the stack.</summary>
        public void Push(bool boolean) => stack.Push(boolean ? 1 : 0);

        /// <summary>Clears the stack.</summary>
        public void Clear() => stack.Clear();

        #region DEBUG
        public IEnumerator<long> GetEnumerator()
        {
            return ((IEnumerable<long>)stack).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay => $"Count = {Count}";

        #endregion
    }
}
