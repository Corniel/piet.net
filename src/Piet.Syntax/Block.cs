namespace Piet.Syntax;

[DebuggerDisplay("Colour = {Colour.Name}, Value = {Value}")]
public sealed class Block(Colour colour, ImmutableArray<Codel> codels)
{
    public static readonly Block Black = new(Colour.Black, []);
    
    public Orientations<Cursor> Edges { get; } = codels.Length is 0
        ? new()
        : InitEdges(codels);

    public Colour Colour { get; } = colour;

    public int Value => Codels.Length;

    public ImmutableArray<Codel> Codels { get; } = codels;

    public Orientations<Neighbour> Neighbours { get; } = new();

    public bool HasColour => Colour.HasColour;
    public bool IsBlack => Colour.IsBlack;
    public bool IsWhite => Colour.IsWhite;

    private static Orientations<Cursor> InitEdges(IEnumerable<Codel> codels)
    {
        var xMin = codels.Min(p => p.X);
        var xMax = codels.Max(p => p.X);
        var yMin = codels.Min(p => p.Y);
        var yMax = codels.Max(p => p.Y);

        var o = new Orientations<Cursor>();
        o[CC_DP.LR] = new(CC_DP.LR, codels.Where(p => p.X == xMax).OrderBy(p => p.Y).First());
        o[CC_DP.LD] = new(CC_DP.LD, codels.Where(p => p.Y == yMax).OrderByDescending(p => p.X).First());
        o[CC_DP.LL] = new(CC_DP.LL, codels.Where(p => p.X == xMin).OrderByDescending(p => p.Y).First());
        o[CC_DP.LT] = new(CC_DP.LT, codels.Where(p => p.Y == yMin).OrderBy(p => p.X).First());
        o[CC_DP.RR] = new(CC_DP.RR, codels.Where(p => p.X == xMax).OrderByDescending(p => p.Y).First());
        o[CC_DP.RD] = new(CC_DP.RD, codels.Where(p => p.Y == yMax).OrderBy(p => p.X).First());
        o[CC_DP.RL] = new(CC_DP.RL, codels.Where(p => p.X == xMin).OrderBy(p => p.Y).First());
        o[CC_DP.RT] = new(CC_DP.RT, codels.Where(p => p.Y == yMin).OrderByDescending(p => p.X).First());
        return o;
    }

    /// <inheritdoc />
    public override string ToString() => $"{Colour.Name}, Value: {Value}, Id = {Edges[CC_DP.LR].Codel.X:000}_{Edges[CC_DP.LR].Codel.Y:000}";

    internal void Init(Program blocks)
    {
        foreach (var (pt, cursor) in Edges)
            Neighbours[pt] = Neighbour.New(cursor, blocks);
    }

    public static Block New(Colour colour, IEnumerable<Codel> codels) => colour switch
    {
        { IsBlack: true } => Black,
        _ => new(colour, [.. codels]),
    };
}
