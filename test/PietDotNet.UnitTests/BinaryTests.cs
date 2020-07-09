using NUnit.Framework;
using PietDotNet.IO;
using PietDotNet.Tests.Tooling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BinaryTests
{
    public class Compression
    {
        [Test]
        public void Density_of_11_codels_per_6_byte_is_achieved()
        {
            ulong size = 1;
            var codels = 1;
            var overflown = false;

            var results = new List<CodelDensity>();

            while (!overflown)
            {
                try
                {
                    checked { size *= 20; }
                    results.Add(new CodelDensity(codels++, size));
                }
                catch (OverflowException) { overflown = true; }
            }
            results.Sort();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Assert.AreEqual(11, results.First().Codels);
            Assert.AreEqual(6, results.First().ByteSize);
        }
        private readonly struct CodelDensity : IComparable<CodelDensity>
        {
            public CodelDensity(int codels, ulong size)
            {
                Codels = codels;
                ByteSize = (size.ToString("X2").Length + 1) / 2;
            }

            public int Codels { get; }
            public int ByteSize { get; }
            public double Density => Codels / (double)ByteSize;
            public int CompareTo(CodelDensity other) => other.Density.CompareTo(Density);
            public override string ToString() => $"Codels: {Codels:00} {ByteSize} byte, {Density:0.000}";
        }
    }
    
    public class Storage
    {
        [Test]
        public void Program_has_same_struture_after_reload()
        {
            var program = Runner.Load("tetris.png");

            using var stream = new MemoryStream();
            program.Save(stream);

            Assert.AreEqual(188, stream.Length);

            stream.Position = 0;

            var reloaded = Binary.Load(stream);
            Assert.AreEqual(program.Width, reloaded.Width);
            Assert.AreEqual(program.Height, reloaded.Height);
            CollectionAssert.AreEqual(program.ToArray(), reloaded.ToArray());
        }
    }
}
