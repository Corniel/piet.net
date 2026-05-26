using Compiled = Piet.Programs.Compiled;

namespace Specs.Runtime.Compiled_specs;

public class Executes
{
    [TestCase("2017-06-11", DayOfWeek.Sunday)]
    [TestCase("2017-06-12", DayOfWeek.Monday)]
    public void Day_of_week(DateTime date, DayOfWeek dayOfWeek)
    => Runner.Run(Compiled.DayOfWeek.Execute, date.Year, date.Month, date.Day)
    .Should().HaveOutput((long)dayOfWeek);

    [TestCase(11, "11\n")]
    [TestCase(12, "Fizz\n")]
    [TestCase(20, "Buzz\n")]
    [TestCase(30, "FizzBuzz\n")]
    public void FizzBuzz_program(int input, string output) => Runner.Run(
        Compiled.FizzBuzz.Execute, input)
        .Should().HaveOutput(output);

    [Test]
    public void Pi_program() => Runner.Run(
        Compiled.Pi.Execute)
        .Should().HaveOutput(31405L);

#if RELEASE // Stackoverflow in DEBUG mode
    [Test]
    public void GnomeSort_program() => Runner.Run(
        Compiled.GnomeSort.Execute, 4, 17, 69, 0, 42)
        .Should().HaveOutput("""
            Pietsort: a sorting program written in piet
            Copyright 2010 Joshua Schulter
            How many elements to be sorted?
            elements:
            the sorted list:
            0
            17
            42
            69
            This work by Joshua Schulter is licensed under 
            the CC-GNU GPL version 2.0 or later.

            """.Replace("\r\n", "\n"));
#endif
}
