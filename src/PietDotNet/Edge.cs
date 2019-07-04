using System;

namespace PietDotNet
{
    /// <summary>Combines the <see cref="DirectionPointer"/> and <see cref="CodelChooser"/>
    /// to define the edge to search for on a <see cref="ColourBlock"/>.
    /// </summary>
    public struct Edge: IEquatable<Edge>
    {
        public Edge(DirectionPointer dp, CodelChooser cc)
        {
            DP = Guard.DefinedEnum(dp, nameof(dp));
            CC = Guard.DefinedEnum(cc, nameof(cc));
        }

        /// <summary>Gets the <see cref="DirectionPointer"/>.</summary>
        public DirectionPointer DP { get; }

        /// <summary>Gets the <see cref="CodelChooser"/>.</summary>
        public CodelChooser CC { get; }
        
        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Edge other && Equals(other);

        /// <inheritdoc />
        public bool Equals(Edge other) => DP == other.DP && CC == other.CC;

        /// <inheritdoc />
        public override int GetHashCode() => (int)DP | ((int)CC << 3);

        /// <inheritdoc />
        public override string ToString() => $"{DP}, {CC}";
    }
}
