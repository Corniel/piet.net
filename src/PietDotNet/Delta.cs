using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace PietDotNet
{
    public struct Delta : IEquatable<Delta>
    {
        public static readonly Delta None; /*         new Delta(0, 0); */
        public static readonly Delta Push = /*     */ new Delta(0, 1);
        public static readonly Delta Pop = /*      */ new Delta(0, 2);

        public static readonly Delta Add = /*      */ new Delta(1, 0);
        public static readonly Delta Subtract = /* */ new Delta(1, 1);
        public static readonly Delta Multiply = /* */ new Delta(1, 2);

        public static readonly Delta Divide = /*   */ new Delta(2, 0);
        public static readonly Delta Mod = /*      */ new Delta(2, 1);
        public static readonly Delta Not = /*      */ new Delta(2, 2);

        public static readonly Delta Greater = /*  */ new Delta(3, 0);
        public static readonly Delta Pointer = /*  */ new Delta(3, 1);
        public static readonly Delta Switch = /*   */ new Delta(3, 2);

        public static readonly Delta Duplicate = /**/ new Delta(4, 0);
        public static readonly Delta Roll = /*     */ new Delta(4, 1);
        public static readonly Delta InInt = /*    */ new Delta(4, 2);

        public static readonly Delta InChr = /*    */ new Delta(5, 0);
        public static readonly Delta OutInt = /*   */ new Delta(5, 1);
        public static readonly Delta OutChr = /*   */ new Delta(5, 2);

        public Delta(int hue, int lightness)
        {
            Hue = hue.Mod(6);
            Lightness = lightness.Mod(3);
        }

        /// <summary>Gets the (delta) hue.</summary>
        public int Hue { get; }

        /// <summary>Gets the (delta) lightness.</summary>
        public int Lightness { get; }

        /// <summary>Gets the corresponding action.</summary>
        public string Action => Actions[this];

        /// <inheritdoc />
        public override string ToString() => $"Hue: {Hue}, Lightness: {Lightness}, Action: {Action}";

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Delta other && Equals(other);

        /// <inheritdoc />
        public bool Equals(Delta other) => Hue == other.Hue && Lightness == other.Lightness;

        /// <inheritdoc />
        public override int GetHashCode() => (Hue << 2) + Lightness;

        public static bool operator ==(Delta l, Delta r) => l.Equals(r);
        public static bool operator !=(Delta l, Delta r) => !(l == r);

        private static Dictionary<Delta, string> Actions
        {
            get
            {
                if (_actions is null)
                {
                    _actions = new Dictionary<Delta, string>();

                    var all = typeof(Delta).GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.FieldType == typeof(Delta));

                    foreach (var field in all)
                    {
                        var delta = (Delta)field.GetValue(null);
                        _actions.Add(delta, field.Name);
                    }
                }
                return _actions;
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<Delta, string> _actions;
    }
}
