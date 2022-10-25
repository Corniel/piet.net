using PietDotNet.Diagnostics;

namespace PietDotNet;

[DebuggerTypeProxy(typeof(CollectionDebugView))]
public class ColourBlock : IEnumerable<Pointer>
{
    public static readonly ColourBlock Border = new Border();
    private readonly Codel[] _edges;

    protected ColourBlock() { }

    internal ColourBlock(Colour colour, IEnumerable<Codel> codels)
    {
        Colour = Guard.NotNull(colour, nameof(colour));
        Value = codels.Count();
        _edges = InitEdges(codels);
    }

    private static Codel[] InitEdges(IEnumerable<Codel> codels)
    {
        var xMin = codels.Min(p => p.X);
        var xMax = codels.Max(p => p.X);
        var yMin = codels.Min(p => p.Y);
        var yMax = codels.Max(p => p.Y);

        return new[]
        {
            /* DP.right CC.left  */ codels.Where(p => p.X == xMax).OrderBy(p => p.Y).FirstOrDefault(),
            /* DP.right CC.right */ codels.Where(p => p.X == xMax).OrderByDescending(p => p.Y).FirstOrDefault(),
            /* DP.down  CC.left  */ codels.Where(p => p.Y == yMax).OrderByDescending(p => p.X).FirstOrDefault(),
            /* DP.down  CC.right */ codels.Where(p => p.Y == yMax).OrderBy(p => p.X).FirstOrDefault(),
            /* DP.left  CC.left  */ codels.Where(p => p.X == xMin).OrderByDescending(p => p.Y).FirstOrDefault(),
            /* DP.left  CC.right */ codels.Where(p => p.X == xMin).OrderBy(p => p.Y).FirstOrDefault(),
            /* DP.top   CC.left  */ codels.Where(p => p.Y == yMin).OrderBy(p => p.X).FirstOrDefault(),
            /* DP.top   CC.right */ codels.Where(p => p.Y == yMin).OrderByDescending(p => p.X).FirstOrDefault(),
        };
    }

    public bool HasColour => Colour.NotBlackOrWhite;
    public bool IsBlack => Colour.IsBlack;
    public bool IsWhite => Colour.IsWhite;

    public virtual Colour Colour { get; }

    public int Value { get; }

    public Pointer Leave(Pointer pointer)
    {
        var position = Edge(pointer).Next(pointer.DP);
        return pointer.Move(position);
    }

    public Codel Edge(Pointer pointer) => _edges[Index(pointer)];

    /// <inheritdoc />
    public override string ToString() => $"{Colour.Name}, Value: {Value}";

    /// <inheritdoc />
    public IEnumerator<Pointer> GetEnumerator()
    {
        return _edges
            .Select((codel, i) =>
                new Pointer(codel, (DirectionPointer)(i >> 1), (CodelChooser)(i & 1))
            ).GetEnumerator();
    }
    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static int Index(Pointer p) => (int)p.CC | ((int)p.DP << 1);
}
