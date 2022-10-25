using System.IO;

namespace PietDotNet.IO;

/// <remarks>
/// To allow storage and reading of programs without using System.Drawing
/// (which is an extra dependency) an internal binary format is used.
/// 
/// Its stores its dimensions in 8 byte and then 11 codels per 6 byte.
/// 
/// 20^11 = 0xBA43B7400000 (6 byte)
/// </remarks>
public static class Binary
{
    public static Program Load(Stream stream)
    {
        Guard.NotNull(stream, nameof(stream));

        var lookup = Colour.All.ToArray();

        var reader = new BinaryReader(stream);

        var width = reader.ReadInt32();
        var height = reader.ReadInt32();

        var codels = Jagged.Array<Colour>(width, height);

        var length = 0;
        var size = width * height;

        while (length < size)
        {
            ulong big = reader.ReadUInt32();
            ulong small = reader.ReadUInt16();
            ulong buffer = big | (small << 32);
            var codel = 11;

            while(codel-- > 0)
            {
                var pos = length + codel;
                var x = pos / height;
                var y = pos % height;
                var index = buffer % 20;
                
                if (pos < size)
                {
                    codels[x][y] = lookup[(int)index];
                }
                buffer /= 20;
            }
            length += 11;
        }

        return new Program(codels);
    }

    public static void Save(this Program program, Stream stream)
    {
        Guard.NotNull(program, nameof(program));
        Guard.NotNull(stream, nameof(stream));

        var writer = new BinaryWriter(stream);
        writer.Write(program.Width);
        writer.Write(program.Height);

        ulong buffer = 0;
        var size = 0;

        foreach(var codel in program)
        {
            size++;
            buffer *= 20;
            buffer += (ulong)codel.Index;

            if (size == 11)
            {
                writer.Write((uint)buffer);
                writer.Write((ushort)(buffer >> 32));
                buffer = 0;
                size = 0;
            }
        }
        if (buffer != 0)
        {
            while(size++ < 11)
            {
                buffer *= 20;
            }
            writer.Write((uint)buffer);
            writer.Write((ushort)(buffer >> 32));
        }
        writer.Flush();
    }
}
