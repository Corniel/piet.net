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
        }

        public Program Program { get; }
        public Stack Stack { get; }

        public DirectionPointer DP { get; private set; }
        public CodelChooser CC{ get; private set; }

        public Point Previous { get; private set; }
        public Point Current { get; private set; }
        public Point Active
        {
            get => active;
            private set
            {
                last = active;
                active = value;
            }
        }
        private Point active;
        private Point last;

        public bool IsBlack => Program[Active].IsBlack;
        public bool IsWhite => Program[Active].IsWhite;

        public bool OnColourBlock => Program[Active] == Program[Current];

        public Delta Delta => Program[Active] - Program[Previous];

        public int Value => Program.Value(Previous);

        /// <summary>Moves the active point to the next point.</summary>
        public void MoveForward() => Active = Active.Next(DP);

        public void MoveAside() => Active = Active.Next(DP, CC);

        public void SwitchCC(long @switch = 1) => CC = CC.Switch(@switch);

        public void RotateDP(long rotate = 1) => DP = DP.Rotate(rotate);

        /// <summary>Resets the active pointer to the current pointer.</summary>
        public void ResetActive() => Active = last;

        /// <summary>Updates the active to current.</summary>
        public void UpdateCurrent()
        {
            Current = Active;
        }

        /// <summary>Updates the previous to active.</summary>
        public void UpdatePrevious()
        {
            Previous = Current;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Active != Current)
            {
                sb.Append($"Active: {Program[Active].RgbCode} {Active.Debug()}, ");
            }

            sb.Append($"Curr: {Program[Current].RgbCode} {Current.Debug()}, ");
            sb.Append($"Prev: {Program[Previous].RgbCode} {Previous.Debug()}, ");
            sb.Append($"DP: {DP}, CC: {CC}, ");

            var curr = Program[Current];
            var prev = Program[Previous];

            if (!curr.IsBlackOrWhite && !prev.IsBlackOrWhite)
            {
                var delta = curr - prev;
                
                var str = delta == Delta.OutChr
                    ? "'" + ((char)Value).ToString() + "'"
                    : Value.ToString();

                sb.Append($"Action: {delta.Action}, Value: {str}, ");
            }

            sb.Append($"Stack: {{ {string.Join(", ", Stack)} }}");

            return sb.ToString();
        }
    }
}
