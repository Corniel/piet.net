using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class FibernacciNumbersTest : ProgramTestBase
    {
        protected override string Location => "fibonacci_numbers.gif";

        [Test]
        public void Execute_GeneratesFibernacciNumbers()
        {
            IO.InChrs.Enqueue('c');
            IO.InInts.Enqueue(12);
            
            Interpreter.Execute();

            CollectionAssert.AreEqual(new long[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 }, IO.OutInts);
        }
    }
}
