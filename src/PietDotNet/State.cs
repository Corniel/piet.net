using System.Drawing;
using System.Text;

namespace PietDotNet
{
    public class State
    {
        public State(Program program, Stack stack)
        {
            Program = Guard.NotNull(program, nameof(program));
            Stack = Guard.NotNull(stack, nameof(stack));

            Previous = program.Block(default);
            Current = program.Block(default);
        }

        public Program Program { get; }
        public Stack Stack { get; }

        public DirectionPointer DP { get; private set; }
        public CodelChooser CC { get; private set; }
        public Edge Edge => new Edge(DP, CC);

        public ColourBlock Previous { get; private set; }
        public ColourBlock Current { get; private set; }
        public ColourBlock Next => Program.Block(NextPointer);

        public Point Pointer { get; private set; }
        public Point NextPointer => Current.GetEdge(Edge).Next(DP);

        public bool IsBlack => Current.IsBlack;
        public bool IsWhite => Current.IsWhite;

        public Delta Delta => Current.Codel - Previous.Codel;

        public int Value => Previous.Value;

        public void SwitchCC(long @switch = 1) => CC = CC.Switch(@switch);

        public void RotateDP(long rotate = 1) => DP = DP.Rotate(rotate);

        /// <summary>Moves to the next colour block, by updating both <see cref="Current"/> and <see cref="Previous"/>.</summary>
        public void MoveToNext()
        {
            Pointer = NextPointer;
            Previous = Current;
            Current = Next;
        }

        public void LeaveWhiteBlock(Point pointer)
        {
            Pointer = pointer;
            Current = Program.Block(Pointer);
            Previous = Current;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();

            var curr = Current.Codel;
            var prev = Previous.Codel;

            sb.Append($"Pointer: {Pointer.Debug()}, ");
            sb.Append($"Curr: {curr.Colour.Debug()}, ");
            sb.Append($"Prev: {prev.Colour.Debug()}, ");
            sb.Append($"DP: {DP}, CC: {CC}, ");

            if (!curr.IsBlackOrWhite && !prev.IsBlackOrWhite)
            {
                var str = Delta == Delta.OutChr
                    ? "'" + ((char)Value).ToString() + "'"
                    : Value.ToString();

                sb.Append($"Action: {Delta.Action}, Value: {str}, ");
            }

            sb.Append($"Stack: {{ {string.Join(", ", Stack)} }}");

            return sb.ToString();
        }
    }
}
