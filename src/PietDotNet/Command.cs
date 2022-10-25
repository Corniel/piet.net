namespace PietDotNet;

public readonly struct Command : IEquatable<Command>
{
    public static readonly Command None; /*         new Delta(0, 0)*/
    public static readonly Command Push = /*     */ new(0, 1);
    public static readonly Command Pop = /*      */ new(0, 2);

    public static readonly Command Add = /*      */ new(1, 0);
    public static readonly Command Subtract = /* */ new(1, 1);
    public static readonly Command Multiply = /* */ new(1, 2);

    public static readonly Command Divide = /*   */ new(2, 0);
    public static readonly Command Modulo = /*   */ new(2, 1);
    public static readonly Command Not = /*      */ new(2, 2);

    public static readonly Command Greater = /*  */ new(3, 0);
    public static readonly Command Rotate = /*   */ new(3, 1);
    public static readonly Command Switch = /*   */ new(3, 2);

    public static readonly Command Duplicate = /**/ new(4, 0);
    public static readonly Command Roll = /*     */ new(4, 1);
    public static readonly Command InInt = /*    */ new(4, 2);

    public static readonly Command InChr = /*    */ new(5, 0);
    public static readonly Command OutInt = /*   */ new(5, 1);
    public static readonly Command OutChr = /*   */ new(5, 2);

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
    public override string ToString() => Name;

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

    private static readonly Dictionary<Command, string> Names = new Dictionary<Command, string>
    {
        { None, /*     */ "NONE" },
        { Push, /*     */ "PUSH" },
        { Pop, /*      */ "POP" },
        { Add, /*      */ "ADD" },
        { Subtract, /* */ "SUB" },
        { Multiply, /* */ "MUL" },
        { Divide, /*   */ "DIV" },
        { Modulo, /*   */ "MOD" },
        { Not, /*      */ "NOT" },
        { Greater, /*  */ "GT" },
        { Rotate, /*   */ "ROT" },
        { Switch, /*   */ "SWI" },
        { Duplicate, /**/ "DUP" },
        { Roll, /*     */ "ROL" },
        { InInt, /*    */ "INi" },
        { InChr, /*    */ "INc" },
        { OutInt, /*   */ "OUTi" },
        { OutChr, /*   */ "OUTc" },
    };
}
