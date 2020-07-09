using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace PietDotNet
{
    public readonly struct Command : IEquatable<Command>
    {
        public static readonly Command None; /*         new Delta(0, 0)*/
        public static readonly Command Push = /*     */ new Command(0, 1);
        public static readonly Command Pop = /*      */ new Command(0, 2);

        public static readonly Command Add = /*      */ new Command(1, 0);
        public static readonly Command Subtract = /* */ new Command(1, 1);
        public static readonly Command Multiply = /* */ new Command(1, 2);

        public static readonly Command Divide = /*   */ new Command(2, 0);
        public static readonly Command Modulo = /*   */ new Command(2, 1);
        public static readonly Command Not = /*      */ new Command(2, 2);

        public static readonly Command Greater = /*  */ new Command(3, 0);
        public static readonly Command Rotate = /*   */ new Command(3, 1);
        public static readonly Command Switch = /*   */ new Command(3, 2);

        public static readonly Command Duplicate = /**/ new Command(4, 0);
        public static readonly Command Roll = /*     */ new Command(4, 1);
        public static readonly Command InInt = /*    */ new Command(4, 2);

        public static readonly Command InChr = /*    */ new Command(5, 0);
        public static readonly Command OutInt = /*   */ new Command(5, 1);
        public static readonly Command OutChr = /*   */ new Command(5, 2);

        private Command(int hue, int lightness)
        {
            Hue = hue.Modulo(6);
            Lightness = lightness.Modulo(3);
        }

        /// <summary>Gets the (delta) hue.</summary>
        public int Hue { get; }

        /// <summary>Gets the (delta) lightness.</summary>
        public int Lightness { get; }

        /// <summary>Gets the name.</summary>
        public string Name => Names[this];

        /// <inheritdoc />
        public override string ToString() => $"{Name}, Hue: {Hue}, Lightness: {Lightness}";

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Command other && Equals(other);

        /// <inheritdoc />
        public bool Equals(Command other) => Hue == other.Hue && Lightness == other.Lightness;

        /// <inheritdoc />
        public override int GetHashCode() => (Hue << 2) + Lightness;

        /// <summary>Gets the <see cref="Command"/> based on the delta of the two <see cref="Colour"/>s.</summary>
        internal static Command Delta(Colour current, Colour previous)
        {
            if (current.IsBlackOrWhite || previous.IsBlackOrWhite)
            {
                throw new InvalidOperationException($"A command not be determined once a black or white colour is involved.");
            }
            var h = current.Hue - previous.Hue;
            var l = current.Lightness - previous.Lightness;
            return new Command(h, l);
        }

        private static Dictionary<Command, string> Names
        {
            get
            {
                if (_names is null)
                {
                    _names = new Dictionary<Command, string>();

                    var all = typeof(Command).GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(Command));

                    foreach (var field in all)
                    {
                        var cmd = (Command)field.GetValue(null);
                        _names.Add(cmd, field.Name);
                    }
                }
                return _names;
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<Command, string> _names;
    }
}
