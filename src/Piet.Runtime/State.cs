using Piet.Runtime.IO;
using System.Linq;
using System.Text;

namespace Piet.Runtime;

[DebuggerDisplay("{DebuggerDisplay}")]
public ref struct State(Stack stack, InOut io)
{
    /// <summary>The (combined) pointer.</summary>
    public CC_DP PT { get; set; }

    public Stack Stack { get; set; } = stack;

    public InOut IO { get; } = io;

    public State this[CC_DP pt]
    {
        get
        {
            PT = pt;
            return this;
        }
    }

    /// <see cref="Stack.Push(long)" />
    public State PSH(long value)
    {
        Stack = Stack.Push(value);
        return this;
    }

    /// <see cref="Stack.Pop(out long?)" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State POP
    {
        get
        {
            Stack = Stack.Pop(out _);
            return this;
        }
    }

    /// <see cref="Stack.Add()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State ADD
    {
        get
        {
            Stack = Stack.Add();
            return this;
        }
    }

    /// <see cref="Stack.Subtract()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State SUB
    {
        get
        {
            Stack = Stack.Subtract();
            return this;
        }
    }

    /// <see cref="Stack.Multiply()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State MUL
    {
        get
        {
            Stack = Stack.Multiply();
            return this;
        }
    }

    /// <see cref="Stack.Divide()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State DIV
    {
        get
        {
            Stack = Stack.Divide();
            return this;
        }
    }

    /// <see cref="Stack.Modulo()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State MOD
    {
        get
        {
            Stack = Stack.Modulo();
            return this;
        }
    }

    /// <see cref="Stack.Not()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State NOT
    {
        get
        {
            Stack = Stack.Not();
            return this;
        }
    }

    /// <see cref="Stack.Greater()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State GT_
    {
        get
        {
            Stack = Stack.Greater();
            return this;
        }
    }

    /// <see cref="Stack.Rotate()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State ROT
    {
        get
        {
            Stack = Stack.Pop(out var pop);
            if (pop is { } rot)
            {
                PT = PT.Rotate(rot);
            }
            return this;
        }
    }

    /// <see cref="Stack.Switch()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State SWI
    {
        get
        {
            Stack = Stack.Pop(out var pop);
            if (pop is { } swi)
            {
                PT = PT.Switch(swi);
            }
            return this;
        }
    }

    /// <see cref="Stack.Duplicate()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State DUP
    {
        get
        {
            Stack = Stack.Duplicate();
            return this;
        }
    }

    /// <see cref="Stack.Roll()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State ROL
    {
        get
        {
            Stack = Stack.Roll();
            return this;
        }
    }

    /// <see cref="InOut.InInt()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State INi
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

    /// <see cref="InOut.InChr()" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State INc
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

    /// <see cref="InOut.Out(long)" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State OUTi
    {
        get
        {
            Stack = Stack.Pop(out var pop);
            if (pop is { } i)
            {
                IO.Out(i);
                
            }
            return this;
        }
    }

    /// <see cref="InOut.Out(char)" />
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public State OUTc
    {
        get
        {
            Stack = Stack.Pop(out var pop);
            if (pop is { } i)
            {
                IO.Out((char)i);
            }
            return this;
        }
    }

    public static State New(InOut? io = null, Stack? stack = null)
        => new(stack ?? Stack.Empty, io ?? InOut.Console);

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay
    {
        get
        {
            var sb = new StringBuilder();
            sb.Append($"CC-DP = {PT}, ").Append($"Stack[{Stack.Count}] = [");

            if (Stack.Count <= 10)
                sb.Append(string.Join(", ", Stack));
            else
                sb.Append(string.Join(",", Stack.Take(8))).Append(", ...");

            return sb.Append(']').ToString();
        }
    }
}
