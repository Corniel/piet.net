using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PietDotNet
{
    public static class Piet
    {
        public static void Main(params string[] args)
        {
            if (args is null || args.Length == 0)
            {
                Console.WriteLine("Specify a program.");
                return;
            }

            var program = Program.From(new FileInfo(args[0]));

            var interpreter = new Interpreter(program);
            interpreter.Execute();
        }
    }
}
