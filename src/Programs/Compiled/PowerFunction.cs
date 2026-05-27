#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class PowerFunction
{
    public static void Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 5, Colour = light green
        {
            case LR: state = state.INi; goto B003_001;
            case LL: state = state.LR.INi; goto B003_001;
            case RL: state = state.LR.INi; goto B003_001;
        }

        B003_001: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.INi; goto B004_001;
            case LL: state = state.MOD; goto B000_000;
            case RL: state = state.MOD; goto B000_000;
        }

        B004_001: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B005_001;
            case LL: state = state.MOD; goto B003_001;
            case RL: state = state.MOD; goto B003_001;
        }

        B005_001: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B006_001;
            case LL: state = state.DIV; goto B004_001;
            case RL: state = state.DIV; goto B004_001;
        }

        B006_001: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B007_001;
            case LL: state = state.POP; goto B005_001;
            case RR: state = state.PSH(1); goto B007_001;
            case RL: state = state.POP; goto B005_001;
        }

        B007_001: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B008_001;
            case LL: state = state.POP; goto B006_001;
            case RR: state = state.SUB; goto B008_001;
            case RL: state = state.POP; goto B006_001;
        }

        B008_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.GT_; goto B009_001;
            case LL: state = state.OUTc; goto B007_001;
            case RR: state = state.GT_; goto B009_001;
            case RL: state = state.OUTc; goto B007_001;
        }

        B009_001: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.NOT; goto B010_001;
            case LL: state = state.GT_; goto B008_001;
            case RR: state = state.NOT; goto B010_001;
            case RL: state = state.GT_; goto B008_001;
        }

        B010_001: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ROT; goto B011_001;
            case LL: state = state.ROL; goto B009_001;
            case RR: state = state.ROT; goto B011_001;
            case RL: state = state.ROL; goto B009_001;
        }

        B011_001: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LR: state = state.PSH(2); goto B013_001;
            case LD: state = state.POP; goto B012_002;
            case LL: state = state.SWI; goto B010_001;
            case LT: state = state.RR.PSH(2); goto B013_001;
            case RR: state = state.PSH(2); goto B013_001;
            case RD: state = state.LR.GT_; goto B009_001;
            case RL: state = state.SWI; goto B010_001;
            case RT: state = state.LR.PSH(2); goto B013_001;
        }

        B013_001: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B014_001;
            case RR: state = state.PSH(1); goto B014_001;
            case RL: state = state.POP; goto B011_001;
        }

        B012_002: state = state.POP; goto B012_003; // PT = , Size = 1, Colour = light magenta

        B014_001: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B015_001;
            case RR: state = state.ROL; goto B015_001;
            case RL: state = state.POP; goto B013_001;
        }

        B012_003: state = state.PSH(1); goto B012_004; // PT = , Size = 1, Colour = dark magenta

        B015_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B016_001;
            case RR: state = state.DUP; goto B016_001;
            case RL: state = state.NOT; goto B014_001;
        }

        B012_004: state = state.OUTi; return; // PT = , Size = 1, Colour = light magenta

        B016_001: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LR: state = state.PSH(3); goto B017_001;
            case LL: state = state.LR.PSH(1); goto B006_001;
            case RR: state = state.PSH(1); goto B006_001;
            case RL: state = state.DIV; goto B015_001;
        }

        B017_001: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(2); goto B018_001;
            case LL: state = state.POP; goto B016_001;
            case RL: state = state.POP; goto B016_001;
        }

        B018_001: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B019_001;
            case LL: state = state.POP; goto B017_001;
            case RL: state = state.POP; goto B017_001;
        }

        B019_001: state = state.DUP; goto B022_001; // PT = , Size = 1, Colour = magenta

        B022_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B023_001;
            case LL: state = state.DIV; goto B021_001;
            case RR: state = state.PSH(1); goto B023_001;
            case RL: state = state.DIV; goto B021_001;
        }

        B023_001: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.GT_; goto B024_001;
            case LL: state = state.POP; goto B022_001;
            case RR: state = state.GT_; goto B024_001;
            case RL: state = state.POP; goto B022_001;
        }

        B024_001: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B025_001;
            case LL: state = state.GT_; goto B023_001;
            case RR: state = state.ROT; goto B025_001;
            case RL: state = state.GT_; goto B023_001;
        }

        B025_001: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(3); goto B028_001;
            case LD: state = state.PSH(1); goto B025_002;
            case LL: state = state.SWI; goto B024_001;
            case LT: state = state.LR.PSH(3); goto B028_001;
            case RR: state = state.LR.PSH(3); goto B028_001;
            case RD: state = state.PSH(1); goto B025_002;
            case RL: state = state.SWI; goto B024_001;
            case RT: state = state.LR.PSH(3); goto B028_001;
        }

        B028_001: state = state.PSH(2); goto B029_001; // PT = , Size = 2, Colour = cyan

        B025_002: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.SUB; goto B025_003;
            case RD: state = state.SUB; goto B025_003;
        }

        B029_001: state = state.ROL; goto B030_001; // PT = , Size = 1, Colour = dark cyan

        B025_003: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LD: state = state.PSH(3); goto B025_006;
            case RD: state = state.PSH(3); goto B025_006;
        }

        B030_001: state = state.RD.POP; goto B030_002; // PT = RD, Size = 1, Colour = light yellow

        B025_006: switch (state.PT) // Size = 2, Colour = light blue
        {
            case LD: state = state.PSH(2); goto B025_008;
            case RD: state = state.PSH(2); goto B025_008;
        }

        B030_002: state = state.POP; goto B029_004; // PT = , Size = 1, Colour = dark yellow

        B025_008: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B025_009;
            case RD: state = state.ROL; goto B025_009;
        }

        B021_001: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LL: state = state.NOT; goto B018_001;
            case RL: state = state.NOT; goto B018_001;
        }

        B029_004: state = state.OUTi; return; // PT = , Size = 12, Colour = yellow

        B025_009: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.RL.DUP; goto B024_009;
            case RD: state = state.LL.DUP; goto B024_009;
        }

        B024_009: switch (state.PT) // Size = 4, Colour = dark red
        {
            case LL: state = state.RL.PSH(4); goto B023_009;
            case RL: state = state.PSH(4); goto B023_009;
        }

        B023_009: state = state.PSH(3); goto B022_009; // PT = , Size = 3, Colour = light red

        B022_009: state = state.LT.ROL; goto B022_008; // PT = LT, Size = 1, Colour = red

        B022_008: state = state.MUL; goto B022_006; // PT = , Size = 1, Colour = dark blue

        B022_006: state = state.PSH(3); goto B022_005; // PT = , Size = 3, Colour = magenta

        B022_005: state = state.PSH(2); goto B022_004; // PT = , Size = 2, Colour = dark magenta

        B022_004: state = state.ROL; goto B021_003; // PT = , Size = 1, Colour = light magenta

        B021_003: state = state.RR.DUP; goto B022_001; // PT = RR, Size = 2, Colour = cyan
    }
}
