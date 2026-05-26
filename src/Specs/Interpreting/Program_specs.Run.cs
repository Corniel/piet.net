using Piet.Programs;

namespace Specs.Interperter_specs;

public class Runs
{
    [Test]
    public void Alphabet_prints_a_till_z()
        => Runner.Run(Streams.Alphabet.Program())
        .Should().HaveOutput("abcdefghijklmnopqrstuvwxyz");
    
    [Test]
    public void Euclids_Algorithm_calculates_greatest_comon_divisor()
        => Runner.Run(Streams.EuclidsAlgorithm.Program(), 42, 35)
        .Should().HaveOutput(7);

    [TestCase("2017-06-11", DayOfWeek.Sunday)]
    [TestCase("2017-06-12", DayOfWeek.Monday)]
    public void Day_of_week(DateTime date, DayOfWeek dayOfWeek)
        => Runner.Run(Streams.DayOfWeek.Program(), date.Year, date.Month, date.Day)
        .Should().HaveOutput((long)dayOfWeek);

    [TestCase(11, "11\n")]
    [TestCase(12, "Fizz\n")]
    [TestCase(20, "Buzz\n")]
    [TestCase(30, "FizzBuzz\n")]
    public void FizzBuzz(int input, string output)
        => Runner.Run(Streams.FizzBuzz.Program(), input)
        .Should().HaveOutput(output);
    
    [Test]
    public void Gnome_sort()
        => Runner.Run(Streams.GnomeSort.Program(), 4, 17, 69, 0, 42)
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

    [Test]
    public void Hello_world_prints_Hello_World()
        => Runner.Run(Streams.Hello_World.Program()).Should()
        .HaveOutput("Hello world!");
    
    [Test]
    public void Hello_world_artistic_prints_Hello_World()
        => Runner.Run(Streams.Hello_World_artistic.Program())
        .Should().HaveOutput("Hello, world!\n");

    [Test]
    public void Hello_world_big_prints_Hello_World()
        => Runner.Run(Streams.Hello_World_big.Program(4))
        .Should().HaveOutput("hello world!\n");

    [Test]
    public void Hello_world_globe_prints_Hello_World()
        => Runner.Run(Streams.Hello_World_globe.Program())
        .Should().HaveOutput("Hello, world!\n");

    [Test]
    public void Multi_codel_program_with_codel_1_prints_Hello_world()
        => Runner.Run(Streams.MultiCodelProgram.Program(1))
        .Should().HaveOutput("Hello world!\n");

    [Test]
    public void Multi_codel_program_with_codel_2_prints_Hello_world()
        => Runner.Run(Streams.MultiCodelProgram.Program(2))
        .Should().HaveOutput("Piet\n");

    [Test]
    public void Pi052_calculates_pi_as_3_1405()
        => Runner.Run(Streams.Pi.Program())
        .Should().HaveOutput(3_1405);

    [Test]
    public void Pong_prints_PONG()
        => Runner.Run(Streams.Pong.Program())
        .Should().HaveOutput("PONG\n");

    [Test]
    public void Power_function_returns_power_of_input()
        => Runner.Run(Streams.PowerFunction.Program(), 17, 3)
        .Should().HaveOutput(4913);

    [Test]
    public void Tetris_prints_Tetris()
        => Runner.Run(Streams.Tetris.Program())
        .Should().HaveOutput("Tetris");
}
