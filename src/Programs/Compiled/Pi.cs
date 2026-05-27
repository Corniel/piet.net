#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class Pi
{
    public static void Execute(State state)
    {
        B000_000: state = state.RR.PSH(52); goto B001_051; // PT = RR, Size = 52, Colour = dark red

        B001_051: state = state.DUP; goto B002_051; // PT = , Size = 1, Colour = light red

        B002_051: state = state.MUL; goto B003_051; // PT = , Size = 1, Colour = light blue

        B003_051: state = state.PSH(8492); goto B111_058; // PT = , Size = 1, Colour = dark magenta

        B111_058: state = state.PSH(10); goto B117_058; // PT = , Size = 1, Colour = dark red

        B117_058: state = state.DUP; goto B118_058; // PT = , Size = 1, Colour = dark yellow

        B118_058: state = state.MUL; goto B119_058; // PT = , Size = 1, Colour = dark magenta

        B119_058: state = state.DUP; goto B120_058; // PT = , Size = 1, Colour = red

        B120_058: state = state.MUL; goto B121_058; // PT = , Size = 1, Colour = blue

        B121_058: state = state.MUL; goto B122_058; // PT = , Size = 1, Colour = light magenta

        B122_058: state = state.PSH(2); goto B124_058; // PT = , Size = 2, Colour = dark red

        B124_058: state = state.PSH(1); goto B125_058; // PT = , Size = 1, Colour = light red

        B125_058: state = state.ROL; goto B126_058; // PT = , Size = 1, Colour = red

        B126_058: state = state.DIV; goto B127_058; // PT = , Size = 1, Colour = dark blue

        B127_058: state = state.OUTi; goto B128_058; // PT = , Size = 1, Colour = dark red

        B128_058: state = state.PSH(10); goto B135_058; // PT = , Size = 2, Colour = light magenta

        B135_058: state = state.OUTc; return; // PT = , Size = 1, Colour = dark yellow
    }
}
