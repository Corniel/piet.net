#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class DayOfWeek
{
    public static void Execute(State state)
    {
        B000_000: state = state.INi; goto B001_000; // PT = LR, Size = 1, Colour = dark green

        B001_000: state = state.PSH(10); goto B005_000; // PT = LR, Size = 1, Colour = red

        B005_000: state = state.PSH(10); goto B009_000; // PT = LR, Size = 1, Colour = light green

        B009_000: state = state.PSH(10); goto B013_000; // PT = LR, Size = 1, Colour = light green

        B013_000: state = state.PSH(2); goto B016_000; // PT = LR, Size = 1, Colour = light green

        B016_000: state = state.MUL; goto B017_000; // PT = LR, Size = 3, Colour = light green

        B017_000: state = state.MUL; goto B018_000; // PT = LR, Size = 3, Colour = dark cyan

        B018_000: state = state.MUL; goto B019_000; // PT = LR, Size = 3, Colour = blue

        B019_000: state = state.SUB; goto B020_000; // PT = LR, Size = 3, Colour = light magenta

        B020_000: state = state.DUP; goto B021_000; // PT = LR, Size = 3, Colour = red

        B021_000: state = state.DUP; goto B022_000; // PT = LR, Size = 3, Colour = blue

        B022_000: state = state.PSH(3); goto B025_000; // PT = LR, Size = 3, Colour = green

        B025_000: state = state.ADD; goto B026_000; // PT = LR, Size = 3, Colour = light green

        B026_000: state = state.PSH(4); goto B029_000; // PT = LR, Size = 3, Colour = light cyan

        B029_000: state = state.DIV; goto B030_000; // PT = LR, Size = 1, Colour = light green

        B030_000: state = state[RD].PSH(2); goto B030_004; // PT = LR, Size = 1, Colour = light blue

        B030_004: state = state.PSH(1); goto B030_007; // PT = RD, Size = 1, Colour = light green

        B030_007: state = state.ROL; goto B030_008; // PT = RD, Size = 1, Colour = light green

        B030_008: state = state[LD].PSH(4); goto B030_011; // PT = RD, Size = 1, Colour = red

        B030_011: state = state.MOD; goto B030_012; // PT = LD, Size = 1, Colour = light green

        B030_012: state = state.NOT; goto B030_013; // PT = LD, Size = 1, Colour = blue

        B030_013: state = state.INi; goto B030_016; // PT = LD, Size = 1, Colour = light red

        B030_016: state = state.DUP; goto B030_017; // PT = LD, Size = 1, Colour = red

        B030_017: state = state.PSH(2); goto B030_020; // PT = LD, Size = 1, Colour = blue

        B030_020: state = state.GT_; goto B030_021; // PT = LD, Size = 1, Colour = light green

        B030_021: state = state.PSH(2); goto B030_024; // PT = LD, Size = 1, Colour = light magenta

        B030_024: state = state.PSH(1); goto B030_027; // PT = LD, Size = 1, Colour = light green

        B030_027: state = state.ROL; goto B030_028; // PT = LD, Size = 1, Colour = light green

        B030_028: state = state.DUP; goto B030_029; // PT = LD, Size = 1, Colour = red

        B030_029: state = state[LL].PSH(6); goto B025_030; // PT = LD, Size = 3, Colour = blue

        B025_030: switch (state.PT) // Size = 2, Colour = light green
        {
            case LL: state = state.GT_; goto B024_029;
            case RR: state = state.POP; goto B026_030;
        }

        B024_029: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state[RR].GT_; goto B025_030;
            case LL: state = state.ROT; goto B023_029;
            case RR: state = state.GT_; goto B025_030;
        }

        B023_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LR: state = state.SWI; goto B024_029;
            case LD: state = state[RL].PSH(7); goto B018_030;
            case LL: state = state.PSH(7); goto B018_030;
            case LT: state = state[RL].PSH(6); goto B021_025;
        }

        B018_030: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.PSH(9); goto B013_029;
            case RL: state = state.PSH(9); goto B013_029;
        }

        B021_025: state = state.SUB; goto B020_025; // PT = RL, Size = 3, Colour = dark yellow

        B013_029: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LL: state = state.MUL; goto B012_029;
            case RL: state = state.MUL; goto B012_029;
        }

        B020_025: state = state.PSH(8); goto B015_025; // PT = RL, Size = 3, Colour = light green

        B012_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LL: state = state.PSH(9); goto B007_029;
            case RL: state = state.PSH(9); goto B007_029;
        }

        B015_025: state = state.PSH(9); goto B010_025; // PT = RL, Size = 1, Colour = dark yellow

        B026_030: state = state[LL].PSH(6); goto B025_030; // PT = RR, Size = 6, Colour = dark green

        B007_029: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LL: state = state.MUL; goto B006_029;
            case RL: state = state.MUL; goto B006_029;
        }

        B010_025: state = state.MUL; goto B009_025; // PT = RL, Size = 3, Colour = dark yellow

        B006_029: switch (state.PT) // Size = 3, Colour = green
        {
            case LL: state = state.PSH(4); goto B002_030;
            case RL: state = state.PSH(4); goto B002_030;
        }

        B009_025: state = state[LT].PSH(8); goto B005_024; // PT = RL, Size = 3, Colour = green

        B002_030: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.ADD; goto B001_030;
            case RL: state = state.ADD; goto B001_030;
        }

        B005_024: state = state.ADD; goto B005_023; // PT = LT, Size = 1, Colour = dark yellow

        B001_030: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LL: state = state[RT].PSH(9); goto B001_024;
            case RL: state = state[LT].PSH(9); goto B001_024;
        }

        B005_023: state = state.PSH(9); goto B005_018; // PT = LT, Size = 1, Colour = dark green

        B001_024: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B001_023;
            case RT: state = state.MUL; goto B001_023;
        }

        B005_018: state = state.MUL; goto B005_017; // PT = LT, Size = 3, Colour = dark yellow

        B001_023: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(9); goto B001_018;
            case RT: state = state.PSH(9); goto B001_018;
        }

        B005_017: state = state.PSH(7); goto B005_012; // PT = LT, Size = 3, Colour = green

        B001_018: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state.MUL; goto B001_017;
            case RT: state = state.MUL; goto B001_017;
        }

        B005_012: state = state.ADD; goto B005_011; // PT = LT, Size = 1, Colour = dark yellow

        B001_017: switch (state.PT) // Size = 3, Colour = green
        {
            case LT: state = state.PSH(7); goto B002_012;
            case RT: state = state.PSH(7); goto B002_012;
        }

        B005_011: state = state[RR].PSH(9); goto B010_010; // PT = LT, Size = 1, Colour = dark green

        B002_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.ADD; goto B002_011;
            case RT: state = state.ADD; goto B002_011;
        }

        B010_010: state = state.MUL; goto B011_010; // PT = RR, Size = 3, Colour = dark yellow

        B002_011: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.PSH(9); goto B001_006;
            case RT: state = state.PSH(9); goto B001_006;
        }

        B011_010: state = state[LD].PSH(6); goto B009_016; // PT = RR, Size = 3, Colour = green

        B001_006: switch (state.PT) // Size = 3, Colour = dark yellow
        {
            case LT: state = state[RR].MUL; goto B004_006;
            case RL: state = state[RR].MUL; goto B004_006;
            case RT: state = state[LR].MUL; goto B004_006;
        }

        B009_016: state = state.ADD; goto B009_017; // PT = LD, Size = 3, Colour = dark yellow

        B004_006: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(8); goto B009_006;
            case RR: state = state.PSH(8); goto B009_006;
        }

        B009_017: state = state.PSH(9); goto B011_022; // PT = LD, Size = 3, Colour = dark green

        B009_006: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B010_006;
            case RR: state = state.ADD; goto B010_006;
            case RL: state = state.POP; goto B006_006;
        }

        B011_022: state = state.MUL; goto B010_023; // PT = LD, Size = 1, Colour = dark yellow

        B010_006: switch (state.PT) // Size = 2, Colour = dark green
        {
            case LR: state = state.PSH(2); goto B014_006;
            case RR: state = state.PSH(2); goto B014_006;
        }

        B010_023: state = state[LT].PSH(6); goto B013_020; // PT = LD, Size = 3, Colour = green

        B014_006: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(1); goto B017_006;
            case RR: state = state[RL].POP; goto B013_006;
        }

        B013_020: state = state.ADD; goto B013_019; // PT = LT, Size = 3, Colour = dark yellow

        B017_006: state = state.ROL; goto B018_006; // PT = LR, Size = 1, Colour = dark yellow

        B013_019: state = state.PSH(9); goto B013_014; // PT = LT, Size = 3, Colour = dark green

        B013_006: state = state.INc; goto B009_006; // PT = RL, Size = 2, Colour = yellow

        B018_006: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state[RD].DUP; goto B018_007;
            case LT: state = state[LD].DUP; goto B018_007;
        }

        B013_014: state = state.MUL; goto B013_013; // PT = LT, Size = 3, Colour = dark yellow

        B018_007: switch (state.PT) // Size = 3, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B020_010;
            case RD: state = state[LD].PSH(1); goto B020_010;
        }

        B013_013: state = state.PSH(3); goto B013_010; // PT = LT, Size = 3, Colour = green

        B006_006: state = state.OUTi; goto B001_006; // PT = RL, Size = 8, Colour = yellow

        B020_010: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.GT_; goto B020_011;
            case LT: state = state.POP; goto B020_009;
            case RT: state = state.POP; goto B020_009;
        }

        B013_010: state = state.ADD; goto B013_009; // PT = LT, Size = 3, Colour = dark yellow

        B020_011: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.NOT; goto B020_012;
            case LT: state = state.GT_; goto B020_010;
            case RT: state = state.GT_; goto B020_010;
        }

        B013_009: state = state[RR].PSH(2); goto B014_006; // PT = LT, Size = 3, Colour = dark green

        B020_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.ROT; goto B020_013;
            case LT: state = state.ROL; goto B020_011;
            case RT: state = state.ROL; goto B020_011;
        }

        B020_013: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state[RD].PSH(1); goto B020_016;
            case LD: state = state.PSH(1); goto B020_016;
            case LL: state = state.POP; goto B019_013;
            case LT: state = state.SWI; goto B020_012;
        }

        B020_016: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.SUB; goto B020_017;
            case RD: state = state.SUB; goto B020_017;
        }

        B019_013: state = state[RD].PSH(10); goto B017_016; // PT = LL, Size = 1, Colour = dark blue

        B020_017: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LD: state = state.PSH(2); goto B020_021;
            case RD: state = state[LD].PSH(2); goto B020_021;
        }

        B017_016: state = state.MOD; goto B017_017; // PT = RD, Size = 1, Colour = light green

        B020_021: state = state[RT].PSH(1); goto B023_018; // PT = LD, Size = 4, Colour = light green

        B017_017: state = state[LD].PSH(3); goto B018_020; // PT = RD, Size = 1, Colour = blue

        B023_018: state = state[LR].ROL; goto B025_017; // PT = RT, Size = 2, Colour = light green

        B018_020: state = state.PSH(1); goto B017_023; // PT = LD, Size = 1, Colour = light green

        B020_009: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LT: state = state.DIV; goto B018_006;
            case RT: state = state.DIV; goto B020_004;
        }

        B025_017: state = state[LT].PSH(10); goto B022_013; // PT = LR, Size = 3, Colour = red

        B017_023: state = state[RR].ROL; goto B020_023; // PT = LD, Size = 3, Colour = light green

        B020_004: state = state[RD].DUP; goto B018_007; // PT = RT, Size = 3, Colour = light magenta

        B022_013: state = state[RT].DIV; goto B023_012; // PT = LT, Size = 2, Colour = light green

        B020_023: state = state.MUL; goto B021_023; // PT = RR, Size = 1, Colour = red

        B023_012: state = state.PSH(2); goto B024_009; // PT = RT, Size = 1, Colour = light blue

        B021_023: state = state.ADD; goto B022_023; // PT = RR, Size = 1, Colour = light yellow

        B024_009: state = state.PSH(1); goto B023_004; // PT = RT, Size = 1, Colour = light green

        B022_023: state = state.ADD; goto B023_023; // PT = RR, Size = 1, Colour = light green

        B023_004: state = state[LL].ROL; goto B022_005; // PT = RT, Size = 9, Colour = light green

        B023_023: state = state.ADD; goto B024_023; // PT = RR, Size = 1, Colour = light cyan

        B022_005: state = state[LD].DUP; goto B018_007; // PT = LL, Size = 2, Colour = red

        B024_023: state = state[LT].PSH(5); goto B025_021; // PT = RR, Size = 1, Colour = light blue

        B025_021: state = state[RT].ADD; goto B027_020; // PT = LT, Size = 3, Colour = light green

        B027_020: state = state.INi; goto B027_019; // PT = RT, Size = 1, Colour = light cyan

        B027_019: state = state.ADD; goto B027_018; // PT = RT, Size = 1, Colour = dark yellow

        B027_018: state = state.PSH(7); goto B027_013; // PT = RT, Size = 1, Colour = dark green

        B027_013: state = state[LT].MOD; goto B027_012; // PT = RT, Size = 2, Colour = light green

        B027_012: state = state.OUTi; return; // PT = LT, Size = 1, Colour = blue
    }
}
