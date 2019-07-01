using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class FibernacciNumbersTest
    {
        [Test]
        public void Run_GeneratesFibernacciNumbers()
        {
            var io = new TestIO();
            io.InChrs.Enqueue('c');
            io.InInts.Enqueue(12);
            var program = TestProgram.Load("fibonacci_numbers.gif");
            var interpreter = new Interpreter(io);

            interpreter.Execute(program);

            CollectionAssert.AreEqual(new long[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 }, io.OutInts);
        }
    }
}