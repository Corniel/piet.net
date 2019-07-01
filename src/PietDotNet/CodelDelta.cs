using System;

namespace PietDotNet
{
    public struct CodelDelta : IEquatable<CodelDelta>
    {
        public static readonly CodelDelta None; /*         new CodelDelta(0, 0); */
        public static readonly CodelDelta Push = /*     */ new CodelDelta(0, 1);
        public static readonly CodelDelta Pop = /*      */ new CodelDelta(0, 2);

        public static readonly CodelDelta Add = /*      */ new CodelDelta(1, 0);
        public static readonly CodelDelta Subtract = /* */ new CodelDelta(1, 1);
        public static readonly CodelDelta Multiply = /* */ new CodelDelta(1, 2);

        public static readonly CodelDelta Divide = /*   */ new CodelDelta(2, 0);
        public static readonly CodelDelta Mod = /*      */ new CodelDelta(2, 1);
        public static readonly CodelDelta Not = /*      */ new CodelDelta(2, 2);

        public static readonly CodelDelta Greater = /*  */ new CodelDelta(3, 0);
        public static readonly CodelDelta Pointer = /*  */ new CodelDelta(3, 1);
        public static readonly CodelDelta Switch = /*   */ new CodelDelta(3, 2);

        public static readonly CodelDelta Duplicate = /**/ new CodelDelta(4, 0);
        public static readonly CodelDelta Roll = /*     */ new CodelDelta(4, 1);
        public static readonly CodelDelta InInt = /*    */ new CodelDelta(4, 2);

        public static readonly CodelDelta InChr = /*    */ new CodelDelta(5, 0);
        public static readonly CodelDelta OutInt = /*   */ new CodelDelta(5, 1);
        public static readonly CodelDelta OutChr = /*   */ new CodelDelta(5, 2);

        public CodelDelta(int hue, int lightness)
        {
            Hue = hue.Mod(6);
            Lightness = lightness.Mod(3);
        }

        /// <summary>Gets the (delta) hue.</summary>
        public int Hue { get; }

        /// <summary>Gets the (delta) lightness.</summary>
        public int Lightness { get; }

        /// <inheritdoc />
        public override string ToString() => $"Hue: {Hue}, Lightness: {Lightness}";

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is CodelDelta other && Equals(other);

        /// <inheritdoc />
        public bool Equals(CodelDelta other) => Hue == other.Hue && Lightness == other.Lightness;

        /// <inheritdoc />
        public override int GetHashCode() => (Hue << 2) + Lightness;

        public static bool operator ==(CodelDelta l, CodelDelta r) => l.Equals(r);
        public static bool operator !=(CodelDelta l, CodelDelta r) => !(l == r);
    }
}
