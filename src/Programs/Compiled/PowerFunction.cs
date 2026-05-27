#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class PowerFunction
{
    private const bool Exit = true;

    public static bool Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 5, Colour = light green
        {
            case LR: state = state.INi; goto B003_001;
            case LL: state = state.LR.INi; goto B003_001;
            case RL: state = state.LR.INi; goto B003_001;
            default: return Exit;
        }

        B003_001: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.INi; goto B004_001;
            case LL: state = state.MOD; goto B000_000;
            case RL: state = state.MOD; goto B000_000;
            default: return Exit;
        }

        B004_001: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B005_001;
            case LL: state = state.MOD; goto B003_001;
            case RL: state = state.MOD; goto B003_001;
            default: return Exit;
        }

        B005_001: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B006_001;
            case LL: state = state.DIV; goto B004_001;
            case RL: state = state.DIV; goto B004_001;
            default: return Exit;
        }

        B006_001: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B007_001;
            case LL: state = state.POP; goto B005_001;
            case RR: state = state.PSH(1); goto B007_001;
            case RL: state = state.POP; goto B005_001;
            default: return Exit;
        }

        B007_001: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B008_001;
            case LL: state = state.POP; goto B006_001;
            case RR: state = state.SUB; goto B008_001;
            case RL: state = state.POP; goto B006_001;
            default: return Exit;
        }

        B008_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.GT_; goto B009_001;
            case LL: state = state.OUTc; goto B007_001;
            case RR: state = state.GT_; goto B009_001;
            case RL: state = state.OUTc; goto B007_001;
            default: return Exit;
        }

        B009_001: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.NOT; goto B010_001;
            case LL: state = state.GT_; goto B008_001;
            case RR: state = state.NOT; goto B010_001;
            case RL: state = state.GT_; goto B008_001;
            default: return Exit;
        }

        B010_001: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ROT; goto B011_001;
            case LL: state = state.ROL; goto B009_001;
            case RR: state = state.ROT; goto B011_001;
            case RL: state = state.ROL; goto B009_001;
            default: return Exit;
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
            default: return Exit;
        }

        B013_001: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B014_001;
            case RR: state = state.PSH(1); goto B014_001;
            case RL: state = state.POP; goto B011_001;
            default: return Exit;
        }

        B012_002: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.POP; goto B012_003;
            default: return Exit;
        }

        B014_001: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B015_001;
            case RR: state = state.ROL; goto B015_001;
            case RL: state = state.POP; goto B013_001;
            default: return Exit;
        }

        B012_003: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.PSH(1); goto B012_004;
            default: return Exit;
        }

        B015_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B016_001;
            case RR: state = state.DUP; goto B016_001;
            case RL: state = state.NOT; goto B014_001;
            default: return Exit;
        }

        B012_004: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.OUTi; goto B005_007;
            default: return Exit;
        }

        B016_001: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LR: state = state.PSH(3); goto B017_001;
            case LL: state = state.LR.PSH(1); goto B006_001;
            case RR: state = state.PSH(1); goto B006_001;
            case RL: state = state.DIV; goto B015_001;
            default: return Exit;
        }

        B005_007: switch (state.PT) // Size = 31, Colour = light blue
        {
            default: return Exit;
        }

        B017_001: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(2); goto B018_001;
            case LL: state = state.POP; goto B016_001;
            case RL: state = state.POP; goto B016_001;
            default: return Exit;
        }

        B018_001: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B019_001;
            case LL: state = state.POP; goto B017_001;
            case RL: state = state.POP; goto B017_001;
            default: return Exit;
        }

        B019_001: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.DUP; goto B022_001;
            default: return Exit;
        }

        B022_001: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B023_001;
            case LL: state = state.DIV; goto B021_001;
            case RR: state = state.PSH(1); goto B023_001;
            case RL: state = state.DIV; goto B021_001;
            default: return Exit;
        }

        B023_001: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.GT_; goto B024_001;
            case LL: state = state.POP; goto B022_001;
            case RR: state = state.GT_; goto B024_001;
            case RL: state = state.POP; goto B022_001;
            default: return Exit;
        }

        B024_001: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B025_001;
            case LL: state = state.GT_; goto B023_001;
            case RR: state = state.ROT; goto B025_001;
            case RL: state = state.GT_; goto B023_001;
            default: return Exit;
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
            default: return Exit;
        }

        B028_001: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LR: state = state.PSH(2); goto B029_001;
            default: return Exit;
        }

        B025_002: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.SUB; goto B025_003;
            case RD: state = state.SUB; goto B025_003;
            default: return Exit;
        }

        B029_001: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROL; goto B030_001;
            default: return Exit;
        }

        B025_003: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LD: state = state.PSH(3); goto B025_006;
            case RD: state = state.PSH(3); goto B025_006;
            default: return Exit;
        }

        B030_001: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.RD.POP; goto B030_002;
            default: return Exit;
        }

        B025_006: switch (state.PT) // Size = 2, Colour = light blue
        {
            case LD: state = state.PSH(2); goto B025_008;
            case RD: state = state.PSH(2); goto B025_008;
            default: return Exit;
        }

        B030_002: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RD: state = state.POP; goto B029_004;
            default: return Exit;
        }

        B025_008: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B025_009;
            case RD: state = state.ROL; goto B025_009;
            default: return Exit;
        }

        B021_001: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LL: state = state.NOT; goto B018_001;
            case RL: state = state.NOT; goto B018_001;
            default: return Exit;
        }

        B029_004: switch (state.PT) // Size = 12, Colour = yellow
        {
            case RD: state = state.OUTi; goto B029_008;
            default: return Exit;
        }

        B025_009: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.RL.DUP; goto B024_009;
            case RD: state = state.LL.DUP; goto B024_009;
            default: return Exit;
        }

        B029_008: switch (state.PT) // Size = 7, Colour = dark red
        {
            default: return Exit;
        }

        B024_009: switch (state.PT) // Size = 4, Colour = dark red
        {
            case LL: state = state.RL.PSH(4); goto B023_009;
            case RL: state = state.PSH(4); goto B023_009;
            default: return Exit;
        }

        B023_009: switch (state.PT) // Size = 3, Colour = light red
        {
            case RL: state = state.PSH(3); goto B022_009;
            default: return Exit;
        }

        B022_009: switch (state.PT) // Size = 1, Colour = red
        {
            case RL: state = state.LT.ROL; goto B022_008;
            default: return Exit;
        }

        B022_008: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LT: state = state.MUL; goto B022_006;
            default: return Exit;
        }

        B022_006: switch (state.PT) // Size = 3, Colour = magenta
        {
            case LT: state = state.PSH(3); goto B022_005;
            default: return Exit;
        }

        B022_005: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LT: state = state.PSH(2); goto B022_004;
            default: return Exit;
        }

        B022_004: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ROL; goto B021_003;
            default: return Exit;
        }

        B021_003: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LT: state = state.RR.DUP; goto B022_001;
            default: return Exit;
        }
    }
}
