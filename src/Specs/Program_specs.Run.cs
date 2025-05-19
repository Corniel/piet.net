namespace Program_specs;

public class Run
{
    [Test]
    public void Alphabet_prints_a_till_z()
        => Runner.Run("alphabet.png")
        .Should().HaveOutput("abcdefghijklmnopqrstuvwxyz");
    
    [Test]
    public void Euclids_Algorithm_calculates_greatest_comon_divisor()
        => Runner.RunWithInput("euclids_algorithm.png", 42, 35)
        .Should().HaveOutput(7);

    [TestCase("2017-06-11", DayOfWeek.Sunday)]
    [TestCase("2017-06-12", DayOfWeek.Monday)]
    public void Day_of_week(DateTime date, DayOfWeek dayOfWeek)
        => Runner.RunWithInput("day_of_week.png", date.Year, date.Month, date.Day)
        .Should().HaveOutput((long)dayOfWeek);

    [TestCase(11, "11\n")]
    [TestCase(12, "Fizz\n")]
    [TestCase(20, "Buzz\n")]
    [TestCase(30, "FizzBuzz\n")]
    public void FizzBuzz(int input, string output)
        => Runner.RunWithInput("fizz_buzz.png", input)
        .Should().HaveOutput(output);
    
    [Test]
    public void Gnome_sort()
        => Runner.RunWithInput("gnome_sort.png", 4, 17, 69, 0, 42)
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
        => Runner.Run("hello_world.png").Should()
        .HaveOutput("Hello world!");
    
    [Test]
    public void Hello_world_artistic_prints_Hello_World()
        => Runner.Run("hello_world_artistic.gif")
        .Should().HaveOutput("Hello, world!\n");

    [Test]
    public void Hello_world_big_prints_Hello_World()
        => Runner.Run("hello_world_big.gif", codelSize: 4)
        .Should().HaveOutput("hello world!\n");

    [Test]
    public void Hello_world_globe_prints_Hello_World()
        => Runner.Run("hello_world_globe.png")
        .Should().HaveOutput("Hello, world!\n");

    [Test]
    public void Multi_codel_program_with_codel_1_prints_Hello_world()
        => Runner.Run("multi_codel_program.gif", codelSize: 1)
        .Should().HaveOutput("Hello world!\n");

    [Test]
    public void Multi_codel_program_with_codel_2_prints_Hello_world()
        => Runner.Run("multi_codel_program.gif", codelSize: 2)
        .Should().HaveOutput("Piet\n");

    [Test]
    public void Pi052_calculates_pi_as_3_1405()
        => Runner.Run("pi_052.png")
        .Should().HaveOutput(3_1405);

    [Test]
    public void Pong_prints_PONG()
        => Runner.Run("pong.png")
        .Should().HaveOutput("PONG\n");

    [Test]
    public void Power_function_returns_power_of_input()
        => Runner.RunWithInput("power_function.png", 17, 3)
        .Should().HaveOutput(4913);

    [Test]
    public void Tetris_prints_Tetris()
        => Runner.Run("tetris.png")
        .Should().HaveOutput("Tetris");
}
