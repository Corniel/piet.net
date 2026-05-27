#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class Pi
{
    private const bool Exit = true;

    public static bool Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 52, Colour = dark red
        {
            case LR: state = state.RR.PSH(52); goto B001_051;
            default: return Exit;
        }

        B001_051: switch (state.PT) // Size = 1, Colour = light red
        {
            case RR: state = state.DUP; goto B002_051;
            default: return Exit;
        }

        B002_051: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RR: state = state.MUL; goto B003_051;
            default: return Exit;
        }

        B003_051: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RR: state = state.PSH(8492); goto B111_058;
            default: return Exit;
        }

        B111_058: switch (state.PT) // Size = 1, Colour = dark red
        {
            case RR: state = state.PSH(10); goto B117_058;
            default: return Exit;
        }

        B117_058: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.DUP; goto B118_058;
            default: return Exit;
        }

        B118_058: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RR: state = state.MUL; goto B119_058;
            default: return Exit;
        }

        B119_058: switch (state.PT) // Size = 1, Colour = red
        {
            case RR: state = state.DUP; goto B120_058;
            default: return Exit;
        }

        B120_058: switch (state.PT) // Size = 1, Colour = blue
        {
            case RR: state = state.MUL; goto B121_058;
            default: return Exit;
        }

        B121_058: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RR: state = state.MUL; goto B122_058;
            default: return Exit;
        }

        B122_058: switch (state.PT) // Size = 2, Colour = dark red
        {
            case RR: state = state.PSH(2); goto B124_058;
            default: return Exit;
        }

        B124_058: switch (state.PT) // Size = 1, Colour = light red
        {
            case RR: state = state.PSH(1); goto B125_058;
            default: return Exit;
        }

        B125_058: switch (state.PT) // Size = 1, Colour = red
        {
            case RR: state = state.ROL; goto B126_058;
            default: return Exit;
        }

        B126_058: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case RR: state = state.DIV; goto B127_058;
            default: return Exit;
        }

        B127_058: switch (state.PT) // Size = 1, Colour = dark red
        {
            case RR: state = state.OUTi; goto B128_058;
            default: return Exit;
        }

        B128_058: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case RR: state = state.PSH(10); goto B135_058;
            default: return Exit;
        }

        B135_058: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.OUTc; goto B136_057;
            default: return Exit;
        }

        B136_057: switch (state.PT) // Size = 4, Colour = red
        {
            default: return Exit;
        }
    }
}
