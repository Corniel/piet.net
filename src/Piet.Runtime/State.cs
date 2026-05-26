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
            Stack = Stack.Pop();
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
            PT = PT.Rotate(Stack.Peek());
            Stack = Stack.Pop();
            return this;
        }
    }

    public State SWI
    {
        get
        {
            PT = PT.Switch(Stack.Peek());
            Stack = Stack.Pop();
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
            IO.Out(Stack.Peek());
            Stack = Stack.Pop();
            return this;
        }
    }

    public State OUTc
    {
        get
        {
            IO.Out((char)Stack.Peek());
            Stack = Stack.Pop();
            return this;
        }
    }

    public State LR { get { PT = CC_DP.LR; return this; } }
    public State LD { get { PT = CC_DP.LD; return this; } }
    public State LL { get { PT = CC_DP.LL; return this; } }
    public State LT { get { PT = CC_DP.LT; return this; } }
    public State RR { get { PT = CC_DP.RR; return this; } }
    public State RD { get { PT = CC_DP.RD; return this; } }
    public State RL { get { PT = CC_DP.RL; return this; } }
    public State RT { get { PT = CC_DP.RT; return this; } }

    public static State New(InOut? io = null, Stack? stack = null)
        => new(stack ?? Stack.Empty, io ?? InOut.Console);
}
