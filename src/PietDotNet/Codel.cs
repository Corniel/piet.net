using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace PietDotNet
{
    /// <summary>Represents a single codel.</summary>
    /// <remarks>
    ///  Individual pixels of colour are significant in the language, so it is
    ///  common for programs to be enlarged for viewing so that the details are
    ///  easily visible. In such enlarged programs, the term "codel" is used to
    ///  mean a block of colour equivalent to a single pixel of code, to avoid
    ///  confusion with the actual pixels of the enlarged graphic, of which
    ///  many may make up one codel. 
    /// </remarks>
    public sealed class Codel
    {
        /// <summary>Gets all defined <see cref="Codel"/>s.</summary>
        public static IReadOnlyCollection<Codel> All => Types.Values;

        public static readonly Codel White = new Codel("#FFFFFF", -1, int.MinValue, "white");
        public static readonly Codel Black = new Codel("#000000", -1, int.MaxValue, "black");

        public static readonly Codel RedLight = /*     */ new Codel("#FFC0C0", 0, 0, "light red");
        public static readonly Codel Red = /*          */ new Codel("#FF0000", 0, 1, "red");
        public static readonly Codel RedDark = /*      */ new Codel("#C00000", 0, 2, "dark red");

        public static readonly Codel YellowLight = /*  */ new Codel("#FFFFC0", 1, 0, "light yellow");
        public static readonly Codel Yellow = /*       */ new Codel("#FFFF00", 1, 1, "yellow");
        public static readonly Codel YellowDark = /*   */ new Codel("#C0C000", 1, 2, "dark yellow");

        public static readonly Codel GreenLight = /*   */ new Codel("#C0FFC0", 2, 0, "light green");
        public static readonly Codel Green = /*        */ new Codel("#00FF00", 2, 1, "green");
        public static readonly Codel GreenDark = /*    */ new Codel("#00C000", 2, 2, "dark green");

        public static readonly Codel CyanLight = /*    */ new Codel("#C0FFFF", 3, 0, "light cyan");
        public static readonly Codel Cyan = /*         */ new Codel("#00FFFF", 3, 1, "cyan");
        public static readonly Codel CyanDark = /*     */ new Codel("#00C0C0", 3, 2, "dark cyan");

        public static readonly Codel BlueLight = /*    */ new Codel("#C0C0FF", 4, 0, "light blue");
        public static readonly Codel Blue = /*         */ new Codel("#0000FF", 4, 1, "blue");
        public static readonly Codel BlueDark = /*     */ new Codel("#0000C0", 4, 2, "dark blue");

        public static readonly Codel MargentaLight = /**/ new Codel("#FFC0FF", 5, 0, "light magenta");
        public static readonly Codel Margenta = /*     */ new Codel("#FF00FF", 5, 1, "magenta");
        public static readonly Codel MargentaDark = /* */ new Codel("#C000C0", 5, 2, "dark magenta");

        /// <summary>Creates a new instance of a <see cref="Codel"/>.</summary>
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
        private Codel(string rgb, int hue, int ligtness, string name)
        {
            Colour = Color.FromArgb(
                int.Parse(rgb.Substring(1, 2), NumberStyles.HexNumber),
                int.Parse(rgb.Substring(3, 2), NumberStyles.HexNumber),
                int.Parse(rgb.Substring(5, 2), NumberStyles.HexNumber));

            Hue = hue;
            Lightness = ligtness;
            Name = name;
            RgbCode = rgb;

        }

        public Color Colour { get; }

        /// <summary>Returns true if the codel is not black and not white.</summary>
        public bool HasColour => !IsBlackOrWhite;

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
        public string RgbCode { get; }

        /// <summary>Gets the <see cref="Delta"/> of tho <see cref="Codel"/>s.</summary>
        public static Delta operator -(Codel l, Codel r) => l.Subtract(r);

        /// <summary>Gets the <see cref="Delta"/> of tho <see cref="Codel"/>s.</summary>
        private Delta Subtract(Codel other)
        {
            if(IsBlackOrWhite || other.IsBlackOrWhite)
            {
                throw new InvalidOperationException($"A delta can not be determined once a black or white codel is involved.");
            }
            var h = Hue - other.Hue;
            var l = Lightness - other.Lightness;
            return new Delta(h, l);
        }

        /// <inheritdoc />
        public override string ToString() => $"{RgbCode} {Name}";

        /// <summary>Gets a <see cref="Codel"/> based on a colour.</summary>
        /// <returns>
        /// Null if the colour is not a known <see cref="Codel"/>.
        /// </returns>
        public static Codel From(Color colour)
        {
            if (Types.TryGetValue(colour, out var codel))
            {
                return codel;
            }
            return null;
        }

        private static Dictionary<Color, Codel> Types
        {
            get
            {
                if (_types is null)
                {
                    _types = new Dictionary<Color, Codel>();

                    var all = typeof(Codel).GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(Codel));

                    foreach (var field in all)
                    {
                        var codel = (Codel)field.GetValue(null);
                        _types.Add(codel.Colour, codel);
                    }
                }
                return _types;
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<Color, Codel> _types;
    }
}
