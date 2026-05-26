using Piet.Binary;
using Piet.Programs;
using System.Globalization;
using System.IO;

namespace Binary_format_specs;

public class Compression
{
    [Test]
    public void With_density_of_11_codels_per_6_byte_is_achieved()
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
        results[0].Should().BeEquivalentTo(new { Codels = 11, ByteSize = 6 });
    }

    [Test]
    public void With_density_of_1_8501_is_theoratical_optimum()
    {
        var optimum = Math.Log(256) / Math.Log(20);
        optimum.Should().BeApproximately(1.8510, precision: 0.0001);
    }

    private readonly struct CodelDensity(int codels, ulong size) : IComparable<CodelDensity>
    {
        public int Codels { get; } = codels;

        public int ByteSize { get; } = (size.ToString("X2").Length + 1) / 2;
        
        public double Density => Codels / (double)ByteSize;
        
        public int CompareTo(CodelDensity other) => other.Density.CompareTo(Density);

        public override string ToString() => string.Create(CultureInfo.InvariantCulture,
            $"Codels = {Codels:00} ({ByteSize} byte), Density = {Density:0.000} Codels/byte");
    }
}

public class Storage
{
    [Test]
    public void Save_and_reload_of_program_has_no_data_loss()
    {
        var program = Streams.Tetris.Program();

        using var stream = new MemoryStream();
        program.Save(stream);

        stream.Should().HaveLength(188);

        stream.Position = 0;

        var reloaded = BinaryFormat.Load(stream);

        ((object)reloaded).Should().BeEquivalentTo(new
        {
            program.Width,
            program.Height,
        });

        reloaded.Should().BeEquivalentTo(program);
    }
}
