using Piet.Interpreting;
using Piet.Interpreting.Logging;
using Piet.Runtime;
using Piet.Syntax;
using System;
using System.IO;

namespace Piet.CommandLine;

public static class PietCmd
{
    public static void Main(params string[] args)
    {
        if (args is null || args.Length == 0)
        {
            Console.WriteLine("Specify a program.");
            return;
        }
        var file = new FileInfo(args[0]);
        
        if(!file.Exists)
        {
            Console.WriteLine($"Program {file.FullName} does not exist.");
            return;
        }

        var logLevel = args.Length > 1 && Enum.TryParse<LogLevel>(args[1], true, out var parsed)
            ? parsed 
            : LogLevel.Error;

        var program = Program.Load(file);

        var context = new Context
        {
            Logger = Logger.Console(logLevel),
            State = State.New(),
            MaxRuns = int.MaxValue,
        };

        program.Run(context);
    }
}
