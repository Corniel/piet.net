using System;
using System.Collections.Generic;

namespace PietDotNet
{
    /// <summary>Represents a colour.</summary>
    public sealed class Colour
    {
        public static readonly Colour Black = new Colour(0, 0x000000, -1, int.MaxValue, "black");
        public static readonly Colour White = new Colour(1, 0xFFFFFF, -1, int.MinValue, "white");

        public static readonly Colour RedLight = /*    */ new Colour(02, 0xFFC0C0, 0, 0, "light red");
        public static readonly Colour Red = /*         */ new Colour(03, 0xFF0000, 0, 1, "red");
        public static readonly Colour RedDark = /*     */ new Colour(04, 0xC00000, 0, 2, "dark red");

        public static readonly Colour YellowLight = /* */ new Colour(05, 0xFFFFC0, 1, 0, "light yellow");
        public static readonly Colour Yellow = /*      */ new Colour(06, 0xFFFF00, 1, 1, "yellow");
        public static readonly Colour YellowDark = /*  */ new Colour(07, 0xC0C000, 1, 2, "dark yellow");

        public static readonly Colour GreenLight = /*  */ new Colour(08, 0xC0FFC0, 2, 0, "light green");
        public static readonly Colour Green = /*       */ new Colour(09, 0x00FF00, 2, 1, "green");
        public static readonly Colour GreenDark = /*   */ new Colour(10, 0x00C000, 2, 2, "dark green");

        public static readonly Colour CyanLight = /*   */ new Colour(11, 0xC0FFFF, 3, 0, "light cyan");
        public static readonly Colour Cyan = /*        */ new Colour(12, 0x00FFFF, 3, 1, "cyan");
        public static readonly Colour CyanDark = /*    */ new Colour(13, 0x00C0C0, 3, 2, "dark cyan");

        public static readonly Colour BlueLight = /*   */ new Colour(14, 0xC0C0FF, 4, 0, "light blue");
        public static readonly Colour Blue = /*        */ new Colour(15, 0x0000FF, 4, 1, "blue");
        public static readonly Colour BlueDark = /*    */ new Colour(16, 0x0000C0, 4, 2, "dark blue");

        public static readonly Colour MagentaLight = /**/ new Colour(17, 0xFFC0FF, 5, 0, "light magenta");
        public static readonly Colour Magenta = /*     */ new Colour(18, 0xFF00FF, 5, 1, "magenta");
        public static readonly Colour MagentaDark = /* */ new Colour(19, 0xC000C0, 5, 2, "dark magenta");

        /// <summary>Gets all defined <see cref="Colour"/>s.</summary>
        public static readonly IReadOnlyList<Colour> All = new[]
        {
            Black, White,
            RedLight, Red, RedDark,
            YellowLight, Yellow, YellowDark,
            GreenLight, Green, GreenDark,
            CyanLight, Cyan, CyanDark,
            BlueLight, Blue, BlueDark,
            MagentaLight, Magenta, MagentaDark,
        };

        /// <summary>Creates a new instance of a <see cref="Colour"/>.</summary>
        /// <param name="rgb">
        /// The RGB code.
        /// </param>
        /// <param name="hue">
        /// The hue of the colour.
        /// </param>
        /// <param name="ligtness">
        /// The lightness of the colour.
        /// </param>
        /// <param name="name">
        /// The human readable name oft he colour.
        /// </param>
        private Colour(int index, int rgb, int hue, int ligtness, string name)
        {
            Index = index;
            Hue = hue;
            Lightness = ligtness;
            Name = name;
            RgbCode = rgb;
            Index = index;
        }

        /// <summary>Returns true if the codel is not black and not white.</summary>
        public bool NotBlackOrWhite => !IsBlackOrWhite;

        /// <summary>Returns true if the codel is black or white.</summary>
        public bool IsBlackOrWhite => Hue == -1;

        /// <summary>Returns true if the codel is black.</summary>
        public bool IsBlack => Lightness == int.MaxValue;

        /// <summary>Returns true if the codel is white.</summary>
        public bool IsWhite => Lightness == int.MinValue;

        /// <summary>The hue of the colour [0, 6].</summary>
        public int Hue { get; }
       
        /// <summary>The lightness of the colour [0, 2].</summary>
        public int Lightness { get; }

        /// <summary>The (human readable) name of the colour.</summary>
        public string Name { get; }

        /// <summary>The (Hex based) RGB code of the colour.</summary>
        public int RgbCode { get; }

        internal int Index { get; }

        internal string Debug()
        {
            return $"#{(RgbCode >> 20) & 15:X}{(RgbCode >> 12) & 15:X}{(RgbCode >> 4) & 15:X}";
        }

        /// <summary>Gets the <see cref="Command"/> based on the delta of the two <see cref="Colour"/>s.</summary>
        public static Command operator -(Colour l, Colour r) => Command.Delta(l, r);

        /// <inheritdoc />
        public override string ToString() => $"#{RgbCode:X2} {Name}";
    }
}
