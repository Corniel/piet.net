#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class DayOfWeek
{
    private const bool Exit = true;

    public static bool Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.INi; goto B001_000;
            default: return Exit;
        }

        B001_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(10); goto B005_000;
            default: return Exit;
        }

        B005_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(10); goto B009_000;
            default: return Exit;
        }

        B009_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(10); goto B013_000;
            default: return Exit;
        }

        B013_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(2); goto B016_000;
            default: return Exit;
        }

        B016_000: switch (state.PT) // Size = 3, Colour = light green
        {
            case LR: state = state.MUL; goto B017_000;
            default: return Exit;
        }

        B017_000: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.MUL; goto B018_000;
            default: return Exit;
        }

        B018_000: switch (state.PT) // Size = 3, Colour = blue
        {
            case LR: state = state.MUL; goto B019_000;
            default: return Exit;
        }

        B019_000: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state.SUB; goto B020_000;
            default: return Exit;
        }

        B020_000: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.DUP; goto B021_000;
            default: return Exit;
        }

        B021_000: switch (state.PT) // Size = 3, Colour = blue
        {
            case LR: state = state.DUP; goto B022_000;
            default: return Exit;
        }

        B022_000: switch (state.PT) // Size = 3, Colour = green
        {
            case LR: state = state.PSH(3); goto B025_000;
            default: return Exit;
        }

        B025_000: switch (state.PT) // Size = 3, Colour = light green
        {
            case LR: state = state.ADD; goto B026_000;
            default: return Exit;
        }

        B026_000: switch (state.PT) // Size = 3, Colour = light cyan
        {
            case LR: state = state.PSH(4); goto B029_000;
            default: return Exit;
        }

        B029_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DIV; goto B030_000;
            default: return Exit;
        }

        B030_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.RD.PSH(2); goto B030_004;
            default: return Exit;
        }

        B030_004: switch (state.PT) // Size = 1, Colour = light green
        {
            case RD: state = state.PSH(1); goto B030_007;
            default: return Exit;
        }

        B030_007: switch (state.PT) // Size = 1, Colour = light green
        {
            case RD: state = state.ROL; goto B030_008;
            default: return Exit;
        }

        B030_008: switch (state.PT) // Size = 1, Colour = red
        {
            case RD: state = state.LD.PSH(4); goto B030_011;
            default: return Exit;
        }

        B030_011: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.MOD; goto B030_012;
            default: return Exit;
        }

        B030_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.NOT; goto B030_013;
            default: return Exit;
        }

        B030_013: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.INi; goto B030_016;
            default: return Exit;
        }

        B030_016: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.DUP; goto B030_017;
            default: return Exit;
        }

        B030_017: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.PSH(2); goto B030_020;
            default: return Exit;
        }

        B030_020: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.GT_; goto B030_021;
            default: return Exit;
        }

        B030_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.PSH(2); goto B030_024;
            default: return Exit;
        }

        B030_024: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.PSH(1); goto B030_027;
            default: return Exit;
        }

        B030_027: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.ROL; goto B030_028;
            default: return Exit;
        }

        B030_028: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.DUP; goto B030_029;
            default: return Exit;
        }

        B030_029: switch (state.PT) // Size = 3, Colour = blue
        {
            case LD: state = state.LL.PSH(6); goto B025_030;
            default: return Exit;
        }

        B025_030: switch (state.PT) // Size = 2, Colour = light green
        {
            case LL: state = state.GT_; goto B024_029;
            case RR: state = state.POP; goto B026_030;
            default: return Exit;
        }

        B024_029: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state.RR.GT_; goto B025_030;
            case LL: state = state.ROT; goto B023_029;
            case RR: state = state.GT_; goto B025_030;
            default: return Exit;
        }

        B023_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LR: state = state.SWI; goto B024_029;
            case LD: state = state.RL.PSH(7); goto B018_030;
            case LL: state = state.PSH(7); goto B018_030;
            case LT: state = state.RL.PSH(6); goto B021_025;
            default: return Exit;
        }

        B018_030: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.PSH(9); goto B013_029;
            case RL: state = state.PSH(9); goto B013_029;
            default: return Exit;
        }

        B021_025: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case RL: state = state.SUB; goto B020_025;
            default: return Exit;
        }

        B013_029: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LL: state = state.MUL; goto B012_029;
            case RL: state = state.MUL; goto B012_029;
            default: return Exit;
        }

        B020_025: switch (state.PT) // Size = 3, Colour = light green
        {
            case RL: state = state.PSH(8); goto B015_025;
            default: return Exit;
        }

        B012_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LL: state = state.PSH(9); goto B007_029;
            case RL: state = state.PSH(9); goto B007_029;
            default: return Exit;
        }

        B015_025: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RL: state = state.PSH(9); goto B010_025;
            default: return Exit;
        }

        B026_030: switch (state.PT) // Size = 6, Colour = dark green
        {
            case RR: state = state.LL.PSH(6); goto B025_030;
            default: return Exit;
        }

        B007_029: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LL: state = state.MUL; goto B006_029;
            case RL: state = state.MUL; goto B006_029;
            default: return Exit;
        }

        B010_025: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case RL: state = state.MUL; goto B009_025;
            default: return Exit;
        }

        B006_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LL: state = state.PSH(4); goto B002_030;
            case RL: state = state.PSH(4); goto B002_030;
            default: return Exit;
        }

        B009_025: switch (state.PT) // Size = 3, Colour = green
        {
            case RL: state = state.LT.PSH(8); goto B005_024;
            default: return Exit;
        }

        B002_030: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.ADD; goto B001_030;
            case RL: state = state.ADD; goto B001_030;
            default: return Exit;
        }

        B005_024: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B005_023;
            default: return Exit;
        }

        B001_030: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LL: state = state.RT.PSH(9); goto B001_024;
            case RL: state = state.LT.PSH(9); goto B001_024;
            default: return Exit;
        }

        B005_023: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.PSH(9); goto B005_018;
            default: return Exit;
        }

        B001_024: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B001_023;
            case RT: state = state.MUL; goto B001_023;
            default: return Exit;
        }

        B005_018: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B005_017;
            default: return Exit;
        }

        B001_023: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(9); goto B001_018;
            case RT: state = state.PSH(9); goto B001_018;
            default: return Exit;
        }

        B005_017: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(7); goto B005_012;
            default: return Exit;
        }

        B001_018: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B001_017;
            case RT: state = state.MUL; goto B001_017;
            default: return Exit;
        }

        B005_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B005_011;
            default: return Exit;
        }

        B001_017: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(7); goto B002_012;
            case RT: state = state.PSH(7); goto B002_012;
            default: return Exit;
        }

        B005_011: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.RR.PSH(9); goto B010_010;
            default: return Exit;
        }

        B002_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B002_011;
            case RT: state = state.ADD; goto B002_011;
            default: return Exit;
        }

        B010_010: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case RR: state = state.MUL; goto B011_010;
            default: return Exit;
        }

        B002_011: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.PSH(9); goto B001_006;
            case RT: state = state.PSH(9); goto B001_006;
            default: return Exit;
        }

        B011_010: switch (state.PT) // Size = 3, Colour = green
        {
            case RR: state = state.LD.PSH(6); goto B009_016;
            default: return Exit;
        }

        B001_006: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.RR.MUL; goto B004_006;
            case RL: state = state.RR.MUL; goto B004_006;
            case RT: state = state.LR.MUL; goto B004_006;
            default: return Exit;
        }

        B009_016: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LD: state = state.ADD; goto B009_017;
            default: return Exit;
        }

        B004_006: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(8); goto B009_006;
            case RR: state = state.PSH(8); goto B009_006;
            default: return Exit;
        }

        B009_017: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LD: state = state.PSH(9); goto B011_022;
            default: return Exit;
        }

        B009_006: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B010_006;
            case RR: state = state.ADD; goto B010_006;
            case RL: state = state.POP; goto B006_006;
            default: return Exit;
        }

        B011_022: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.MUL; goto B010_023;
            default: return Exit;
        }

        B010_006: switch (state.PT) // Size = 2, Colour = dark green
        {
            case LR: state = state.PSH(2); goto B014_006;
            case RR: state = state.PSH(2); goto B014_006;
            default: return Exit;
        }

        B010_023: switch (state.PT) // Size = 3, Colour = green
        {
            case LD: state = state.LT.PSH(6); goto B013_020;
            default: return Exit;
        }

        B014_006: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(1); goto B017_006;
            case RR: state = state.RL.POP; goto B013_006;
            default: return Exit;
        }

        B013_020: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B013_019;
            default: return Exit;
        }

        B017_006: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROL; goto B018_006;
            default: return Exit;
        }

        B013_019: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LT: state = state.PSH(9); goto B013_014;
            default: return Exit;
        }

        B013_006: switch (state.PT) // Size = 2, Colour = yellow
        {
            case RL: state = state.INc; goto B009_006;
            default: return Exit;
        }

        B018_006: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.RD.DUP; goto B018_007;
            case LT: state = state.LD.DUP; goto B018_007;
            default: return Exit;
        }

        B013_014: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B013_013;
            default: return Exit;
        }

        B018_007: switch (state.PT) // Size = 3, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B020_010;
            case RD: state = state.LD.PSH(1); goto B020_010;
            default: return Exit;
        }

        B013_013: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(3); goto B013_010;
            default: return Exit;
        }

        B006_006: switch (state.PT) // Size = 8, Colour = yellow
        {
            case RL: state = state.OUTi; goto B001_006;
            default: return Exit;
        }

        B020_010: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.GT_; goto B020_011;
            case LT: state = state.POP; goto B020_009;
            case RT: state = state.POP; goto B020_009;
            default: return Exit;
        }

        B013_010: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B013_009;
            default: return Exit;
        }

        B020_011: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.NOT; goto B020_012;
            case LT: state = state.GT_; goto B020_010;
            case RT: state = state.GT_; goto B020_010;
            default: return Exit;
        }

        B013_009: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LT: state = state.RR.PSH(2); goto B014_006;
            default: return Exit;
        }

        B020_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.ROT; goto B020_013;
            case LT: state = state.ROL; goto B020_011;
            case RT: state = state.ROL; goto B020_011;
            default: return Exit;
        }

        B020_013: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.RD.PSH(1); goto B020_016;
            case LD: state = state.PSH(1); goto B020_016;
            case LL: state = state.POP; goto B019_013;
            case LT: state = state.SWI; goto B020_012;
            default: return Exit;
        }

        B020_016: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.SUB; goto B020_017;
            case RD: state = state.SUB; goto B020_017;
            default: return Exit;
        }

        B019_013: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LL: state = state.RD.PSH(10); goto B017_016;
            default: return Exit;
        }

        B020_017: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LD: state = state.PSH(2); goto B020_021;
            case RD: state = state.LD.PSH(2); goto B020_021;
            default: return Exit;
        }

        B017_016: switch (state.PT) // Size = 1, Colour = light green
        {
            case RD: state = state.MOD; goto B017_017;
            default: return Exit;
        }

        B020_021: switch (state.PT) // Size = 4, Colour = light green
        {
            case LD: state = state.RT.PSH(1); goto B023_018;
            default: return Exit;
        }

        B017_017: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.LD.PSH(3); goto B018_020;
            default: return Exit;
        }

        B023_018: switch (state.PT) // Size = 2, Colour = light green
        {
            case RT: state = state.LR.ROL; goto B025_017;
            default: return Exit;
        }

        B018_020: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.PSH(1); goto B017_023;
            default: return Exit;
        }

        B020_009: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.DIV; goto B018_006;
            case RT: state = state.DIV; goto B020_004;
            default: return Exit;
        }

        B025_017: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.LT.PSH(10); goto B022_013;
            default: return Exit;
        }

        B017_023: switch (state.PT) // Size = 3, Colour = light green
        {
            case LD: state = state.RR.ROL; goto B020_023;
            default: return Exit;
        }

        B020_004: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case RT: state = state.RD.DUP; goto B018_007;
            default: return Exit;
        }

        B022_013: switch (state.PT) // Size = 2, Colour = light green
        {
            case LT: state = state.RT.DIV; goto B023_012;
            default: return Exit;
        }

        B020_023: switch (state.PT) // Size = 1, Colour = red
        {
            case RR: state = state.MUL; goto B021_023;
            default: return Exit;
        }

        B023_012: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RT: state = state.PSH(2); goto B024_009;
            default: return Exit;
        }

        B021_023: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case RR: state = state.ADD; goto B022_023;
            default: return Exit;
        }

        B024_009: switch (state.PT) // Size = 1, Colour = light green
        {
            case RT: state = state.PSH(1); goto B023_004;
            default: return Exit;
        }

        B022_023: switch (state.PT) // Size = 1, Colour = light green
        {
            case RR: state = state.ADD; goto B023_023;
            default: return Exit;
        }

        B023_004: switch (state.PT) // Size = 9, Colour = light green
        {
            case RT: state = state.LL.ROL; goto B022_005;
            default: return Exit;
        }

        B023_023: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case RR: state = state.ADD; goto B024_023;
            default: return Exit;
        }

        B022_005: switch (state.PT) // Size = 2, Colour = red
        {
            case LL: state = state.LD.DUP; goto B018_007;
            default: return Exit;
        }

        B024_023: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RR: state = state.LT.PSH(5); goto B025_021;
            default: return Exit;
        }

        B025_021: switch (state.PT) // Size = 3, Colour = light green
        {
            case LT: state = state.RT.ADD; goto B027_020;
            default: return Exit;
        }

        B027_020: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case RT: state = state.INi; goto B027_019;
            default: return Exit;
        }

        B027_019: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RT: state = state.ADD; goto B027_018;
            default: return Exit;
        }

        B027_018: switch (state.PT) // Size = 1, Colour = dark green
        {
            case RT: state = state.PSH(7); goto B027_013;
            default: return Exit;
        }

        B027_013: switch (state.PT) // Size = 2, Colour = light green
        {
            case RT: state = state.LT.MOD; goto B027_012;
            default: return Exit;
        }

        B027_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LT: state = state.OUTi; goto B027_011;
            default: return Exit;
        }

        B027_011: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            default: return Exit;
        }
    }
}
