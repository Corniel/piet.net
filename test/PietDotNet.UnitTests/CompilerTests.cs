﻿using NUnit.Framework;
using PietDotNet.Compilation;
using PietDotNet.Tests.Tooling;
using System;

namespace CompilerTests
{
    public class Compile
    {
        [Test]
        public void Testris_program_results_in_executable()
        {
            var program = Runner.Load("fizz_buzz.png");
            var compilation = PietCompilation.Compile(program, "fizz_buzz", new System.IO.DirectoryInfo(@"c:\TEMP"));

            foreach(var result in compilation.Diagnostics)
            {
                Console.WriteLine(result);
            }

            Assert.IsTrue(compilation.Success);
        }
    }
}
