using PietDotNet.Drawing;
using System;
using System.IO;

namespace PietDotNet;

public static class Programs
{
    public static readonly Program Alphabet = Load("alphabet.png").Value;

    public static readonly Program DayOfWeek = Load("day_of_week.png").Value;

    public static readonly Program EuclidsAlgorithm = Load("euclids_algorithm.png").Value;

    public static readonly Program FibonacciNumbers = Load("fibonacci_numbers.gif").Value;

    public static readonly Program FizzBuzz = Load("fizz_buzz.png").Value;

    public static readonly Program GnomeSort = Load("gnome_sort.png").Value;

    public static readonly Program Hello_World = Load("hello_world.png").Value;

    public static readonly Program Hello_World_artistic = Load("hello_world_artistic.gif").Value;

    public static readonly Program Hello_World_big = Load("hello_world_big.gif", 4).Value;

    public static readonly Program Hello_World_globe = Load("hello_world_globe.png").Value;

    public static Program MultiCodelProgram(int codelSize) => Load("multi_codel_program.gif", codelSize).Value;

    public static readonly Program Pi = Load("pi_052.png").Value;

    public static readonly Program Pong = Load("pong.png").Value;

    public static readonly Program PowerFunction = Load("power_function.png").Value;

    public static readonly Program Tetris = Load("tetris.png").Value;

    internal static Lazy<Program> Load(string path, int codelsize = 1) => new(() =>
    {
        using var stream = typeof(Programs).Assembly
            .GetManifestResourceStream("Programs.Programs." + path)
            ?? throw new FileNotFoundException(path);

        return Bitmapping.Load(stream, codelsize);
    });
}
