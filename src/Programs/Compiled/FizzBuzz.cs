#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class FizzBuzz
{
    public static void Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.INi; goto B001_000;
            case LL: state = state.LR.INi; goto B001_000;
            case RL: state = state.RR.INi; goto B001_000;
        }

        B001_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B002_000;
            case LL: state = state.MOD; goto B000_000;
            case RR: state = state.DUP; goto B002_000;
            case RL: state = state.MOD; goto B000_000;
        }

        B002_000: switch (state.PT) // Size = 3, Colour = green
        {
            case LR: state = state.PSH(3); goto B005_000;
            case LL: state = state.DIV; goto B001_000;
            case RR: state = state.PSH(3); goto B005_000;
            case RL: state = state.DIV; goto B001_000;
        }

        B005_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.MOD; goto B006_000;
            case LL: state = state.POP; goto B002_000;
            case RR: state = state.MOD; goto B006_000;
            case RL: state = state.POP; goto B002_000;
        }

        B006_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B007_000;
            case LL: state = state.INi; goto B005_000;
            case RR: state = state.NOT; goto B007_000;
            case RL: state = state.INi; goto B005_000;
        }

        B007_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B008_000;
            case LL: state = state.ROL; goto B006_000;
            case RR: state = state.ROT; goto B008_000;
            case RL: state = state.ROL; goto B006_000;
        }

        B008_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B026_000;
            case LD: state = state.PSH(3); goto B008_007;
            case LL: state = state.SWI; goto B007_000;
            case LT: state = state.RR.PSH(1); goto B026_000;
            case RR: state = state.PSH(1); goto B026_000;
            case RD: state = state.GT_; goto B006_007;
            case RL: state = state.SWI; goto B007_000;
            case RT: state = state.LR.PSH(1); goto B026_000;
        }

        B026_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(2); goto B057_000;
            case RR: state = state.PSH(2); goto B057_000;
        }

        B008_007: state = state.ROT; goto B006_008; // PT = , Size = 1, Colour = light cyan

        B057_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(1); goto B058_000;
            case LL: state = state.POP; goto B055_000;
            case RR: state = state.PSH(1); goto B058_000;
            case RL: state = state.POP; goto B055_000;
        }

        B006_008: switch (state.PT) // Size = 70, Colour = red
        {
            case LR: state = state.PSH(70); goto B006_025;
            case LD: state = state.PSH(70); goto B006_025;
            case LL: state = state.PSH(70); goto B005_022;
            case LT: state = state.ROT; goto B006_006;
            case RD: state = state.PSH(70); goto B006_025;
        }

        B058_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B059_000;
            case LL: state = state.POP; goto B057_000;
            case RR: state = state.ROL; goto B059_000;
            case RL: state = state.POP; goto B057_000;
        }

        B006_025: switch (state.PT) // Size = 29, Colour = dark red
        {
            case LR: state = state.OUTc; goto B018_020;
            case LD: state = state.POP; goto B007_027;
            case RD: state = state.POP; goto B007_027;
        }

        B005_022: state = state.POP; goto B004_022; // PT = , Size = 1, Colour = dark red

        B006_006: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.RD.GT_; goto B006_007;
            case LD: state = state.PSH(3); goto B008_007;
            case LL: state = state.LR.PSH(1); goto B026_000;
            case LT: return;
        }

        B059_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DUP; goto B060_000;
            case LL: state = state.NOT; goto B058_000;
            case RR: state = state.DUP; goto B060_000;
            case RL: state = state.NOT; goto B058_000;
        }

        B007_027: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_028;
            case RD: state = state.PSH(1); goto B007_028;
        }

        B004_022: state = state.PSH(1); return; // PT = , Size = 1, Colour = red

        B006_007: state = state.POP; goto B006_008; // PT = , Size = 1, Colour = dark red

        B018_020: state = state.PSH(105); goto B029_015; // PT = , Size = 1, Colour = magenta

        B060_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(5); goto B069_000;
            case RR: state = state.PSH(5); goto B069_000;
        }

        B007_028: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_029;
            case RD: state = state.POP; goto B007_029;
        }

        B029_015: state = state.OUTc; goto B030_015; // PT = , Size = 1, Colour = dark red

        B069_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MOD; goto B072_000;
            case RR: state = state.MOD; goto B072_000;
        }

        B007_029: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_030;
            case RD: state = state.PSH(1); goto B007_030;
        }

        B030_015: state = state.PSH(122); goto B033_032; // PT = , Size = 1, Colour = magenta

        B072_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.NOT; goto B073_000;
            case LL: state = state.INi; goto B071_000;
            case RR: state = state.NOT; goto B073_000;
            case RL: state = state.INi; goto B071_000;
        }

        B007_030: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_031;
            case RD: state = state.POP; goto B007_031;
        }

        B033_032: state = state.OUTc; goto B051_031; // PT = , Size = 76, Colour = dark red

        B073_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROT; goto B074_000;
            case LL: state = state.ROL; goto B072_000;
            case RR: state = state.ROT; goto B074_000;
            case RL: state = state.ROL; goto B072_000;
        }

        B007_031: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_032;
            case RD: state = state.PSH(1); goto B007_032;
        }

        B051_031: state = state.PSH(3); goto B054_031; // PT = , Size = 1, Colour = magenta

        B074_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B077_000;
            case LD: state = state.PSH(3); goto B076_007;
            case LL: state = state.SWI; goto B073_000;
            case LT: state = state.RR.PSH(1); goto B077_000;
            case RR: state = state.PSH(1); goto B077_000;
            case RD: state = state.GT_; goto B074_007;
            case RL: state = state.SWI; goto B073_000;
            case RT: state = state.LR.PSH(1); goto B077_000;
        }

        B007_032: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_033;
            case RD: state = state.POP; goto B007_033;
        }

        B054_031: state = state.ROT; goto B053_015; // PT = , Size = 1, Colour = light cyan

        B077_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B143_000;
            case RR: state = state.MUL; goto B143_000;
        }

        B076_007: state = state.ROT; goto B076_008; // PT = , Size = 1, Colour = light blue

        B007_033: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); return;
            case RD: state = state.PSH(1); return;
        }

        B053_015: switch (state.PT) // Size = 122, Colour = red
        {
            case LR: state = state.PSH(122); goto B054_015;
            case LD: state = state.PSH(122); return;
            case LL: state = state.RT.PSH(122); goto B053_014;
            case LT: state = state.PSH(122); goto B053_014;
            case RD: state = state.PSH(122); return;
        }

        B074_007: switch (state.PT) // Size = 101, Colour = dark yellow
        {
            case LL: state = state.RT.GT_; return;
            case RD: state = state.RT.GT_; return;
        }

        B143_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.MUL; goto B144_000;
            case LL: state = state.OUTi; goto B142_000;
            case RR: state = state.MUL; goto B144_000;
            case RL: state = state.OUTi; goto B142_000;
        }

        B076_008: switch (state.PT) // Size = 66, Colour = yellow
        {
            case LR: state = state.RR.PSH(66); goto B094_015;
            case LD: state = state.PSH(66); goto B092_018;
            case LL: state = state.PSH(66); goto B074_007;
            case LT: state = state.RR.PSH(66); goto B094_015;
        }

        B054_015: state = state.LL.POP; goto B053_015; // PT = LL, Size = 19, Colour = dark red

        B053_014: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B053_015;
            case LT: state = state.OUTc; goto B053_013;
            case RD: state = state.POP; goto B053_015;
            case RT: state = state.OUTc; goto B053_013;
        }

        B144_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DUP; goto B151_000;
            case RR: state = state.DUP; goto B151_000;
        }

        B092_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.RL.POP; goto B091_018;
            case RR: state = state.RL.POP; goto B091_018;
        }

        B094_015: state = state.OUTc; goto B095_015; // PT = , Size = 1, Colour = dark yellow

        B071_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.POP; goto B064_000;
            case RL: state = state.POP; goto B064_000;
        }

        B053_013: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.PSH(1); goto B053_010;
            case RT: state = state.PSH(1); goto B053_010;
        }

        B151_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.NOT; goto B152_000;
            case LL: state = state.DIV; goto B150_000;
            case RR: state = state.NOT; goto B152_000;
            case RL: state = state.DIV; goto B150_000;
        }

        B091_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B092_018;
            case RL: state = state.PSH(1); goto B090_018;
        }

        B095_015: state = state.PSH(117); goto B119_015; // PT = , Size = 1, Colour = red

        B064_000: switch (state.PT) // Size = 5, Colour = light yellow
        {
            case LL: state = state.DIV; goto B059_000;
            case RL: state = state.DIV; goto B059_000;
        }

        B053_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.PSH(1); goto B053_007;
            case RT: state = state.PSH(1); goto B053_007;
        }

        B152_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROT; goto B164_000;
            case RR: state = state.ROT; goto B164_000;
        }

        B090_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.POP; goto B091_018;
            case RL: state = state.POP; goto B089_018;
        }

        B119_015: state = state.OUTc; goto B120_015; // PT = , Size = 1, Colour = dark yellow

        B053_007: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.SUB; goto B053_004;
            case RT: state = state.SUB; goto B053_004;
        }

        B164_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTi; goto B165_000;
            case LD: state = state.PSH(10); goto B163_008;
            case LL: state = state.SWI; goto B163_000;
            case LT: state = state.RR.OUTi; goto B165_000;
            case RR: state = state.OUTi; goto B165_000;
            case RD: state = state.PSH(10); goto B163_008;
            case RL: state = state.SWI; goto B163_000;
            case RT: state = state.LR.OUTi; goto B165_000;
        }

        B089_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B090_018;
            case RL: state = state.PSH(1); goto B088_018;
        }

        B120_015: state = state.PSH(122); goto B122_032; // PT = , Size = 1, Colour = red

        B053_004: switch (state.PT) // Size = 1, Colour = green
        {
            case LT: state = state.PSH(1); goto B053_001;
            case RT: state = state.PSH(1); goto B053_001;
        }

        B165_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B166_000;
            case LL: state = state.MUL; goto B164_000;
            case RR: state = state.PSH(1); goto B166_000;
            case RL: state = state.MUL; goto B164_000;
        }

        B163_008: switch (state.PT) // Size = 37, Colour = dark blue
        {
            case LD: state = state.OUTc; return;
            case RD: state = state.OUTc; return;
        }

        B163_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.ROL; goto B151_000;
            case RL: state = state.ROL; goto B151_000;
        }

        B088_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.POP; goto B089_018;
            case RL: state = state.POP; goto B087_018;
        }

        B122_032: state = state.LR.OUTc; goto B140_031; // PT = LR, Size = 76, Colour = dark yellow

        B053_001: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.POP; goto B053_002;
            case LT: state = state.ROT; goto B053_000;
            case RD: state = state.POP; goto B053_002;
            case RT: state = state.ROT; goto B053_000;
        }

        B166_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B167_000;
            case LL: state = state.POP; goto B165_000;
            case RR: state = state.ROT; goto B167_000;
            case RL: state = state.POP; goto B165_000;
        }

        B087_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B088_018;
            case RL: state = state.PSH(1); goto B086_018;
        }

        B140_031: state = state.PSH(3); goto B143_031; // PT = , Size = 1, Colour = red

        B055_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LL: state = state.POP; goto B025_000;
            case RL: state = state.POP; goto B025_000;
        }

        B053_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(2); goto B057_000;
            case LD: state = state.SWI; goto B053_001;
            case LL: state = state.POP; goto B025_000;
            case LT: state = state.RR.PSH(2); goto B057_000;
            case RR: state = state.PSH(2); goto B057_000;
            case RD: state = state.SWI; goto B053_001;
            case RL: state = state.POP; goto B025_000;
            case RT: state = state.LR.PSH(2); goto B057_000;
        }

        B167_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.LL.SWI; goto B166_000;
            case LD: state = state.PSH(10); goto B163_008;
            case LL: state = state.SWI; goto B166_000;
            case LT: state = state.RL.SWI; goto B166_000;
            case RR: state = state.RL.SWI; goto B166_000;
            case RD: state = state.PSH(10); goto B163_008;
            case RL: state = state.SWI; goto B166_000;
            case RT: state = state.LL.SWI; goto B166_000;
        }

        B150_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.OUTi; goto B143_000;
            case RL: state = state.OUTi; goto B143_000;
        }

        B086_018: state = state.RR.POP; goto B087_018; // PT = RR, Size = 1, Colour = dark yellow

        B143_031: state = state.ROT; goto B142_015; // PT = , Size = 1, Colour = light blue

        B025_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.SWI; goto B007_000;
            case RL: state = state.SWI; goto B007_000;
        }

        B142_015: switch (state.PT) // Size = 122, Colour = yellow
        {
            case LR: state = state.PSH(122); goto B143_015;
            case LD: state = state.PSH(122); return;
            case LL: state = state.RT.PSH(122); goto B142_014;
            case LT: state = state.PSH(122); goto B142_014;
        }

        B053_002: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.OUTc; goto B053_005;
            case RD: state = state.OUTc; goto B053_005;
        }

        B142_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.POP; goto B076_000;
            case RL: state = state.POP; goto B076_000;
        }

        B143_015: state = state.LL.POP; goto B142_015; // PT = LL, Size = 19, Colour = dark yellow

        B142_014: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.OUTc; goto B142_013;
            case RT: state = state.OUTc; goto B142_013;
        }

        B053_005: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.POP; goto B053_008;
            case RD: state = state.POP; goto B053_008;
        }

        B076_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.SWI; goto B073_000;
            case RL: state = state.SWI; goto B073_000;
        }

        B142_013: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B142_010;
            case RT: state = state.PSH(1); goto B142_010;
        }

        B053_008: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.POP; goto B053_011;
            case RD: state = state.POP; goto B053_011;
        }

        B142_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.PSH(1); goto B142_007;
            case RT: state = state.PSH(1); goto B142_007;
        }

        B053_011: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.SUB; goto B053_014;
            case RD: state = state.SUB; goto B053_014;
        }

        B142_007: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.SUB; goto B142_004;
            case RT: state = state.SUB; goto B142_004;
        }

        B142_004: switch (state.PT) // Size = 1, Colour = green
        {
            case LT: state = state.RR.MUL; goto B143_000;
            case RT: state = state.LR.MUL; goto B143_000;
        }
    }
}
