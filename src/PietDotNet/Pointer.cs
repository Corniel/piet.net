using System;

namespace PietDotNet
{
    /// <summary>Represents the pointer with its position and directions.</summary>
    public readonly struct Pointer : IEquatable<Pointer>
    {
        public static readonly Pointer Initial;

        private Pointer(Codel position, DirectionPointer dp, CodelChooser cc)
        {
            Position = position;
            DP = dp;
            CC = cc;
        }

        public Codel Position { get; }
        public DirectionPointer DP { get; }
        public CodelChooser CC { get; }

        public Pointer SingleStep() => new Pointer(
            Position.Next(DP),
            DP, 
            CC);

        /// <summary>Moves the pointer based on the <see cref="DirectionPointer"/>.</summary>
        public Pointer Move(Codel position) => new Pointer(
            position,
            DP,
            CC);

        /// <summary>Rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
        public Pointer Rotate(long rotate) => new Pointer(
            Position,
            DP.Rotate(rotate),
            CC);

        /// <summary>Toggles the CC that many times (the absolute value of that many times if negative).</summary>
        public Pointer Switch(long @switch) => new Pointer(
            Position,
            DP,
            CC.Switch(@switch));

        /// <inheritdoc />
        public override string ToString() => $"{Position}, DP: {DP}, CC: {CC}";

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Pointer other && Equals(other);

        /// <inheritdoc />
        public bool Equals(Pointer other)
        {
            return Position.Equals(other.Position)
                && DP == other.DP
                && CC == other.CC;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Position.GetHashCode()
                ^ (DP.GetHashCode() << 16)
                ^ (CC.GetHashCode() << 24);
        }
    
        public static implicit operator Direction(Pointer pointer) => new Direction(pointer.DP, pointer.CC);
    }
}
