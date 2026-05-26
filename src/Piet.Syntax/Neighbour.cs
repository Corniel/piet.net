namespace Piet.Syntax;

public sealed class Neighbour(CC_DP pt, Block block, bool reset = false)
{
    public static readonly Neighbour Exit = new(default, Block.Black);

    public CC_DP PT { get; } = pt;

    public Block Block { get; } = block;

    public bool Reset { get; } = reset;

    public override string ToString()
        => $"CC-DP = {PT}, Colour = {Block.Colour.Name}, Value = {Block.Value}";

    public static Neighbour New(Cursor cursor, Program blocks)
    {
        var next = cursor.Next();
        var blck = blocks[next.Codel];

        return blck switch
        {
            { IsBlack: true } => TraverseBlack(cursor, blocks),
            { IsWhite: true } => TraverseWhite(next, blocks),
            var block => new(cursor.PT, block)
        };
    }
    /// <summary>Handles traverse for black codels (and program edges).</summary>
    /// <remarks>
    /// Black colour blocks and the edges of the program restrict program
    /// flow. If the Piet interpreter attempts to move into a black block
    /// or off an edge, it is stopped and the CC is toggled. The interpreter
    /// then attempts to move from its current block again. If it fails a
    /// second time, the DP is moved clockwise one step. These attempts are
    /// repeated, with the CC and DP being changed between alternate attempts.
    /// If after eight attempts the interpreter cannot leave its current
    /// colour block, there is no way out and the program terminates. 
    /// </remarks>
    private static Neighbour TraverseBlack(Cursor cursor, Program blocks)
    {
        var curr = cursor;

        for (var retry = 0; retry < 8; retry++)
        {
            curr = retry.IsEven ? curr.Switch() : curr.Rotate();

            var next = blocks[curr.Codel].Edges[curr].Next();
            var neighbour = blocks[next.Codel];

            if (neighbour.HasColour)
            {
                return new(curr.PT, neighbour); 
            }
            else if (neighbour.IsWhite)
            {
                return TraverseWhite(next, blocks);
            }
        }
        return Exit;
    }

    /// <summary>Handles traverse for white codels.</summary>
    /// <remarks>
    /// Sliding across white blocks takes the interpreter in a straight
    /// line until it hits a coloured pixel or edge.
    /// 
    /// 1. The interpreter "slides" across the white block in a straight line.
    /// 2. If it hits a restriction, the CC is toggled.Since this results
    ///    in no difference in where the interpreter is trying to go, the
    ///    DP is immediately stepped clockwise.
    /// 3. The interpreter now begins sliding from its current white codel,
    ///    in the new direction of the DP, until it either enters a
    ///    coloured block or encounters another restriction.
    /// 4. Each time the interpreter hits a restriction while within the
    ///    white block, it toggles the CC and steps the DP clockwise, then
    ///    tries to slide again. This process repeats until the interpreter
    ///    either enters a coloured block (where execution then continues);
    ///    or until the interpreter begins retracing its route.If it retraces
    ///    its route entirely within a white block, there is no way out of
    ///    the white block and execution should terminate.
    /// </remarks>
    private static Neighbour TraverseWhite(Cursor cursor, Program blocks)
    {
        var visits = new HashSet<Cursor>();
        var curr = cursor;

        // if the step was already added, we're retracing the route. 
        while (visits.Add(curr))
        {
            var next = curr.Next();
            var blck = blocks[next.Codel];

            if (blck.HasColour)
                return new(next.PT, blck, true);
            else curr = blck.IsWhite
                ? next
                : curr.Switch(1).Rotate(1);
        }
        return Exit;
    }
}
