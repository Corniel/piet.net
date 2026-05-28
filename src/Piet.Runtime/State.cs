using Piet.Runtime.IO;

namespace Piet.Runtime;

[DebuggerDisplay("CC-DP = {PT}, Stack = {Stack.Count}, Peek = {Stack.Peek()}")]
[DebuggerTypeProxy(typeof(Diagnostics.CollectionDebugView))]
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

    /// <summary>Do nothing.</summary>
    public readonly State NON => this;

    /// <see cref="Stack.Push(long)" />
    public State PSH(long value)
    {
        Stack = Stack.Push(value);
        return this;
    }

    /// <see cref="Stack.Pop(out long?)" />
    public State POP
    {
        get
        {
            Stack = Stack.Pop(out _);
            return this;
        }
    }

    /// <see cref="Stack.Add()" />
    public State ADD
    {
        get
        {
            Stack = Stack.Add();
            return this;
        }
    }

    /// <see cref="Stack.Subtract()" />
    public State SUB
    {
        get
        {
            Stack = Stack.Subtract();
            return this;
        }
    }

    /// <see cref="Stack.Multiply()" />
    public State MUL
    {
        get
        {
            Stack = Stack.Multiply();
            return this;
        }
    }

    /// <see cref="Stack.Divide()" />
    public State DIV
    {
        get
        {
            Stack = Stack.Divide();
            return this;
        }
    }

    /// <see cref="Stack.Modulo()" />
    public State MOD
    {
        get
        {
            Stack = Stack.Modulo();
            return this;
        }
    }

    /// <see cref="Stack.Not()" />
    public State NOT
    {
        get
        {
            Stack = Stack.Not();
            return this;
        }
    }

    /// <see cref="Stack.Greater()" />
    public State GT_
    {
        get
        {
            Stack = Stack.Greater();
            return this;
        }
    }

    /// <see cref="Stack.Rotate()" />
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
    public State DUP
    {
        get
        {
            Stack = Stack.Duplicate();
            return this;
        }
    }

    /// <see cref="Stack.Roll()" />
    public State ROL
    {
        get
        {
            Stack = Stack.Roll();
            return this;
        }
    }

    /// <see cref="InOut.InInt()" />
    public State INi
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

    /// <see cref="InOut.InChr()" />
    public State INc
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

    /// <see cref="InOut.Out(long)" />
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
}
