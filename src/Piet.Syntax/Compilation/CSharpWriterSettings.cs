namespace Piet.Syntax.Compilation;

// <summary>Settings for writing C# code.</summary>
public sealed record CSharpWriterSettings
{
    /// <summary>New line character(s).</summary>
    public string NewLine { get; init; } = "\r\n";

    /// <summary>Indentation character(s).</summary>
    public string Indentation { get; init; } = "    ";
}
