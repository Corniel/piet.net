using System.Diagnostics.Contracts;

namespace Piet.Syntax;

public static class Executer
{
    extension(Command cmd)
    {
        [Pure]
        public State Execute(State state, int value) => cmd switch
        {
            _ when cmd == Command.None /*......*/ => state,
            _ when cmd == Command.Push /*......*/ => state.PSH(value),
            _ when cmd == Command.Pop /*.......*/ => state.POP,
            _ when cmd == Command.Add /*.......*/ => state.ADD,
            _ when cmd == Command.Subtract /*..*/ => state.SUB,
            _ when cmd == Command.Multiply /*..*/ => state.MUL,
            _ when cmd == Command.Divide /*....*/ => state.DIV,
            _ when cmd == Command.Modulo /*....*/ => state.MOD,
            _ when cmd == Command.Not /*.......*/ => state.NOT,
            _ when cmd == Command.Greater /*...*/ => state.GT_,
            _ when cmd == Command.Rotate /*....*/ => state.ROT,
            _ when cmd == Command.Switch /*....*/ => state.SWI,
            _ when cmd == Command.Duplicate /*.*/ => state.DUP,
            _ when cmd == Command.Roll /*......*/ => state.ROL,
            _ when cmd == Command.InInt /*.....*/ => state.INi,
            _ when cmd == Command.InChr /*.....*/ => state.INc,
            _ when cmd == Command.OutInt /*....*/ => state.OUTi,
            _ when cmd == Command.OutChr /*....*/ => state.OUTc,

            _ => throw new InvalidOperationException(),
        };
    }

}
