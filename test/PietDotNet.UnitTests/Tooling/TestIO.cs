using PietDotNet.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PietDotNet.Tests.Tooling
{
    public class TestIO : InOut
    {
        private readonly StringBuilder sb = new StringBuilder();

        public Queue<char?> InChrs { get; } = new Queue<char?>();
        public Queue<long?> InInts { get; } = new Queue<long?>();
        public List<long> OutInts { get; } = new List<long>();


        public char? InChr() => InChrs.Dequeue();
        public long? InInt() => InInts.Dequeue();

        public void Out(long n)
        {
            Console.Write(n);
            sb.Append(n);
            OutInts.Add(n);
        }

        public void Out(char c)
        {
            Console.Write(c);
            sb.Append(c);
        }

        public override string ToString() => sb.ToString();
    }
}
