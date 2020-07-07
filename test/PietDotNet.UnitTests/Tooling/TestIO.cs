using PietDotNet.Communication;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PietDotNet.Tests.Tooling
{
    public class TestIO : InOut
    {
        public Queue<char?> InChrs { get; } = new Queue<char?>();
        public Queue<long?> InInts { get; } = new Queue<long?>();
        public List<object> Outs { get; } = new List<object>();

        public char? InChr() => InChrs.Dequeue();
        public long? InInt() => InInts.Dequeue();

        public void Out(long n)
        {
            Console.Write(n);
            Outs.Add(n);
        }

        public void Out(char c)
        {
            Console.Write(c);
            Outs.Add(c);
        }

        public bool IsCharOnly => Outs.All(obj => obj is char);
        public bool IsIntOnly => Outs.All(obj => obj is long || (obj is char ch && ch == '\n'));

        public string OutString => new string(Outs.OfType<char>().ToArray());
        public long[] OutInts => Outs.OfType<long>().ToArray();

        public override string ToString()
        {
            if(IsCharOnly)
            {
                return OutString;
            }
            return "{ "+ string.Join(", ", GetOutObjects()) + " }";
        }

        private IEnumerable<object> GetOutObjects()
        {
            foreach(var obj in Outs)
            {
                if(obj is char ch)
                {
                    yield return $"'{ch}'";
                }
                else
                {
                    yield return obj;
                }
            }
        }
    }
}
