using System;
using System.Collections.Generic;
using System.Text;

namespace PietDotNet.Tests.Tooling
{
    public class TestIO : IInOut
    {
        public Queue<char?> InChrs { get; } = new Queue<char?>();
        public Queue<long?> InInts { get; } = new Queue<long?>();
        public List<char> OutChrs { get; } = new List<char>();
        public List<long> OutInts { get; } = new List<long>();

        public char? InChr() => InChrs.Dequeue();
        public long? InInt() => InInts.Dequeue();

        public void Out(long n)=> OutInts.Add(n);

        public void Out(char c)=> OutChrs.Add(c);
    }
}
