using System;
using System.Drawing;

namespace PietDotNet
{
    /// <summary>Represents a step of a route of the pointer on white colour blocks.</summary>
    public struct Step : IEquatable<Step>
    {
        /// <summary>Creates a new instance of a <see cref="Step"/>.</summary>
        public Step(Point point, DirectionPointer dp)
        {
            Point = point;
            DP = dp;
        }

        /// <summary>Gets the <see cref="Point"/> of the step.</summary>
        public Point Point { get; }
        
        /// <summary>Gets the <see cref="DirectionPointer"/> of the step.</summary>
        public DirectionPointer DP { get; }

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Step other && Equals(other);
        
        /// <inheritdoc />
        public bool Equals(Step other) => Point == other.Point && DP == other.DP;
        
        /// <inheritdoc />
        public override int GetHashCode() => Point.GetHashCode() ^ (DP.GetHashCode() << 16);

        /// <inheritdoc />
        public override string ToString() => $"{Point.Debug()} {DP}";
    }
}
