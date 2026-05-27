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

    public readonly State NON => this;

    public State PSH(long value)
    {
        Stack = Stack.Push(value);
        return this;
    }

    public State POP
    {
        get
        {
            Stack = Stack.Pop(out _);
            return this;
        }
    }

    public State ADD
    {
        get
        {
            Stack = Stack.Add();
            return this;
        }
    }

    public State SUB
    {
        get
        {
            Stack = Stack.Subtract();
            return this;
        }
    }

    public State MUL
    {
        get
        {
            Stack = Stack.Multiply();
            return this;
        }
    }

    public State DIV
    {
        get
        {
            Stack = Stack.Divide();
            return this;
        }
    }

    public State MOD
    {
        get
        {
            Stack = Stack.Modulo();
            return this;
        }
    }

    public State NOT
    {
        get
        {
            Stack = Stack.Not();
            return this;
        }
    }

    public State GT_
    {
        get
        {
            Stack = Stack.Greater();
            return this;
        }
    }

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

    public State DUP
    {
        get
        {
            Stack = Stack.Duplicate();
            return this;
        }
    }

    public State ROL
    {
        get
        {
            Stack = Stack.Roll();
            return this;
        }
    }

    public State INi
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

    public State INc
    {
        get
        {
            Stack = Stack.Push(IO.InInt() ?? throw new InvalidInput());
            return this;
        }
    }

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
