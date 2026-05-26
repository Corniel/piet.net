using Piet.Syntax;
using System.IO;

namespace Piet.Programs;

public static class Streams
{
    public static readonly Stream Alphabet = Load("alphabet.png");

    public static readonly Stream DayOfWeek = Load("day_of_week.png");

    public static readonly Stream EuclidsAlgorithm = Load("euclids_algorithm.png");

    public static readonly Stream Fibonacci = Load("fibonacci_numbers.gif");

    public static readonly Stream FizzBuzz = Load("fizz_buzz.png");

    public static readonly Stream GnomeSort = Load("gnome_sort.png");

    public static readonly Stream Hello_World = Load("hello_world.png");

    public static readonly Stream Hello_World_artistic = Load("hello_world_artistic.gif");

    public static readonly Stream Hello_World_big = Load("hello_world_big.gif");

    public static readonly Stream Hello_World_globe = Load("hello_world_globe.png");

    public static Stream MultiCodelProgram => Load("multi_codel_program.gif");

    public static readonly Stream Pi = Load("pi_052.png");

    public static readonly Stream Pong = Load("pong.png");

    public static readonly Stream IsPrime = Load("prime_tester.png");

    public static readonly Stream PowerFunction = Load("power_function.png");

    public static readonly Stream Tetris = Load("tetris.png");

    internal static Stream Load(string path)
        => typeof(Streams).Assembly
            .GetManifestResourceStream("Programs.Programs." + path)
            ?? throw new FileNotFoundException(path);

    extension(Stream stream)
    {
        public Program Program(int codelSize = 1) => Syntax.Program.Load(stream, codelSize);
    }
}
