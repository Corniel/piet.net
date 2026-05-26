using System.Diagnostics.Contracts;
using System.IO;
using System.Text;

namespace Piet.Syntax.Compilation;

/// <summary>Writer to generate C# code.</summary>
/// <remarks>Initializes a new instance of the <see cref="CSharpWriter"/> class.</remarks>
public sealed class CSharpWriter(TextWriter writer, CSharpWriterSettings? settings = null)
{
    /// <summary>UTF-8 BOM.</summary>
    public static readonly Encoding Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

    /// <summary>The C# writer settings.</summary>
    public CSharpWriterSettings Settings { get; } = settings ?? new();

    private readonly TextWriter Writer = Guard.NotNull(writer);
    private int Indentation;

    /// <summary>Writes a character to the code file.</summary>
    public CSharpWriter Write(char ch)
    {
        Writer.Write(ch);
        return this;
    }

    /// <summary>Writes code (represented as a string) to the code file.</summary>
    public CSharpWriter Write(string? code)
    {
        Writer.Write(code);
        return this;
    }

    /// <summary>Writes the code to the code file.</summary>
        public CSharpWriter Write(Code? code)
    {
        code?.WriteTo(this);
        return this;
    }

    /// <summary>Writes multiple instructions separated by a split action.</summary>
    public CSharpWriter Write(IEnumerable<Action<CSharpWriter>> writes, Action<CSharpWriter> split)
    {
        Guard.NotNull(writes);
        Guard.NotNull(split);

        var first = true;

        foreach (var write in writes)
        {
            if (!first) split(this);
            write(this);
            first = false;
        }

        return this;
    }

    /// <summary>Indents the current line of the code file.</summary>
    public CSharpWriter Indent()
    {
        foreach (var code in Enumerable.Repeat(Settings.Indentation, Indentation))
        {
            Write(code);
        }
        return this;
    }

    /// <summary>Writes the line including an ending to the code file.</summary>
    public CSharpWriter Line(string? line) => Write(line).Line();

    /// <summary>Writes the character including an ending to the code file.</summary>
    public CSharpWriter Line(char ch) => Write(ch).Line();

    /// <summary>Writes the character including an ending to the code file.</summary>
    public CSharpWriter Line() => Write(Settings.NewLine);

    /// <summary>Writes a code block (`{ ... }`).</summary>
    [Pure]
    public IDisposable CodeBlock(string markers = "{}")
    {
        Guard.NotNullOrEmpty(markers);
        Line(markers[0]);
        Indentation++;
        return new ScopedCodeBlock(this, markers[1..]);
    }

    /// <summary>
    /// Clears all buffers for the current writer and causes any buffered data
    /// to be written to the code file.
    /// </summary>
    public void Flush() => Writer.Flush();

    private sealed record ScopedCodeBlock(CSharpWriter Writer, string Close) : IDisposable
    {
        /// <inheritdoc />
        public void Dispose()
        {
            Writer.Indentation--;
            Writer.Indent().Line(Close);
        }
    }
}
