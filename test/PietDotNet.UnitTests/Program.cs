using PietDotNet.Tests.Tooling;

namespace Program;

public class Run
{
    [Test]
    public void Alphabet_prints_a_till_z()
    {
        var result = Runner.Run("alphabet.png");
        RunAssert.HasOutput(result, "abcdefghijklmnopqrstuvwxyz");
    }

    [Test]
    public void Euclids_Algorithm_calculates_greatest_comon_divisor()
    {
        var result = Runner.RunWithInput("euclids_algorithm.png", 42, 35);
        RunAssert.HasNumericOutput(result, 7);
    }

    [TestCase("2017-06-11", DayOfWeek.Sunday)]
    [TestCase("2017-06-12", DayOfWeek.Monday)]
    public void Day_of_week(DateTime date, DayOfWeek dayOfWeek)
    {
        var result = Runner.RunWithInput("day_of_week.png", date.Year, date.Month, date.Day);
        RunAssert.HasNumericOutput(result, (long)dayOfWeek);
    }

    [TestCase(11, "11\n")]
    [TestCase(12, "Fizz\n")]
    [TestCase(20, "Buzz\n")]
    [TestCase(30, "FizzBuzz\n")]
    public void FizzBuzz(int input, string expected)
    {
        var result = Runner.RunWithInput("fizz_buzz.png", input);
        RunAssert.HasOutput(result, expected);
    }

    [Test]
    public void Gnome_sort()
    {
        var result = Runner.RunWithInput("gnome_sort.png", 4, 17, 69, 0, 42);
        RunAssert.HasOutput(result, @"Pietsort: a sorting program written in piet
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
".Replace("\r\n", "\n"));
    }

    [Test]
    public void Hello_world_prints_Hello_World()
    {
        var result = Runner.Run("hello_world.png");
        RunAssert.HasOutput(result, "Hello world!");
    }
    
    [Test]
    public void Hello_world_artistic_prints_Hello_World()
    {
        var result = Runner.Run("hello_world_artistic.gif");
        RunAssert.HasOutput(result, "Hello, world!\n");
    }

    [Test]
    public void Hello_world_big_prints_Hello_World()
    {
        var result = Runner.Run("hello_world_big.gif", codelSize: 4);
        RunAssert.HasOutput(result, "hello world!\n");
    }

    [Test]
    public void Hello_world_globe_prints_Hello_World()
    {
        var result = Runner.Run("hello_world_globe.png");
        RunAssert.HasOutput(result, "Hello, world!\n");
    }

    [Test]
    public void Multi_codel_program_with_codel_1_prints_Hello_world()
    {
        var result = Runner.Run("multi_codel_program.gif", codelSize: 1);
        RunAssert.HasOutput(result, "Hello world!\n");
    }

    [Test]
    public void Multi_codel_program_with_codel_2_prints_Hello_world()
    {
        var result = Runner.Run("multi_codel_program.gif", codelSize: 2);
        RunAssert.HasOutput(result, "Piet\n");
    }

    [Test]
    public void Pi052_calculates_pi_as_3_1405()
    {
        var result = Runner.Run("pi_052.png");
        RunAssert.HasNumericOutput(result,  3_1405);
    }

    [Test]
    public void Pong_prints_PONG()
    {
        var result = Runner.Run("pong.png");
        RunAssert.HasOutput(result, "PONG\n");
    }

    [Test]
    public void Power_function_returns_power_of_input()
    {
        var result = Runner.RunWithInput("power_function.png", 17, 3);
        RunAssert.HasNumericOutput(result, 4913);
    }

    [Test]
    public void Tetris_prints_Tetris()
    {
        var result = Runner.Run("tetris.png");
        RunAssert.HasOutput(result, "Tetris");
    }
}
