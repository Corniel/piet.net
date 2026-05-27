#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class FizzBuzz
{
    private const bool Exit = true;

    public static bool Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.INi; goto B001_000;
            case LL: state = state.LR.INi; goto B001_000;
            case RL: state = state.RR.INi; goto B001_000;
            default: return Exit;
        }

        B001_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B002_000;
            case LL: state = state.MOD; goto B000_000;
            case RR: state = state.DUP; goto B002_000;
            case RL: state = state.MOD; goto B000_000;
            default: return Exit;
        }

        B002_000: switch (state.PT) // Size = 3, Colour = green
        {
            case LR: state = state.PSH(3); goto B005_000;
            case LL: state = state.DIV; goto B001_000;
            case RR: state = state.PSH(3); goto B005_000;
            case RL: state = state.DIV; goto B001_000;
            default: return Exit;
        }

        B005_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.MOD; goto B006_000;
            case LL: state = state.POP; goto B002_000;
            case RR: state = state.MOD; goto B006_000;
            case RL: state = state.POP; goto B002_000;
            default: return Exit;
        }

        B006_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B007_000;
            case LL: state = state.INi; goto B005_000;
            case RR: state = state.NOT; goto B007_000;
            case RL: state = state.INi; goto B005_000;
            default: return Exit;
        }

        B007_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B008_000;
            case LL: state = state.ROL; goto B006_000;
            case RR: state = state.ROT; goto B008_000;
            case RL: state = state.ROL; goto B006_000;
            default: return Exit;
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
            default: return Exit;
        }

        B026_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(2); goto B057_000;
            case RR: state = state.PSH(2); goto B057_000;
            default: return Exit;
        }

        B008_007: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B006_008;
            default: return Exit;
        }

        B057_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(1); goto B058_000;
            case LL: state = state.POP; goto B055_000;
            case RR: state = state.PSH(1); goto B058_000;
            case RL: state = state.POP; goto B055_000;
            default: return Exit;
        }

        B006_008: switch (state.PT) // Size = 70, Colour = red
        {
            case LR: state = state.PSH(70); goto B006_025;
            case LD: state = state.PSH(70); goto B006_025;
            case LL: state = state.PSH(70); goto B005_022;
            case LT: state = state.ROT; goto B006_006;
            case RD: state = state.PSH(70); goto B006_025;
            default: return Exit;
        }

        B058_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B059_000;
            case LL: state = state.POP; goto B057_000;
            case RR: state = state.ROL; goto B059_000;
            case RL: state = state.POP; goto B057_000;
            default: return Exit;
        }

        B006_025: switch (state.PT) // Size = 29, Colour = dark red
        {
            case LR: state = state.OUTc; goto B018_020;
            case LD: state = state.POP; goto B007_027;
            case RD: state = state.POP; goto B007_027;
            default: return Exit;
        }

        B005_022: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LL: state = state.POP; goto B004_022;
            default: return Exit;
        }

        B006_006: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.RD.GT_; goto B006_007;
            case LD: state = state.PSH(3); goto B008_007;
            case LL: state = state.LR.PSH(1); goto B026_000;
            default: return Exit;
        }

        B059_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DUP; goto B060_000;
            case LL: state = state.NOT; goto B058_000;
            case RR: state = state.DUP; goto B060_000;
            case RL: state = state.NOT; goto B058_000;
            default: return Exit;
        }

        B007_027: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_028;
            case RD: state = state.PSH(1); goto B007_028;
            default: return Exit;
        }

        B004_022: switch (state.PT) // Size = 1, Colour = red
        {
            case LL: state = state.PSH(1); goto B002_007;
            default: return Exit;
        }

        B006_007: switch (state.PT) // Size = 1, Colour = dark red
        {
            case RD: state = state.POP; goto B006_008;
            default: return Exit;
        }

        B018_020: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(105); goto B029_015;
            default: return Exit;
        }

        B060_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(5); goto B069_000;
            case RR: state = state.PSH(5); goto B069_000;
            default: return Exit;
        }

        B007_028: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_029;
            case RD: state = state.POP; goto B007_029;
            default: return Exit;
        }

        B002_007: switch (state.PT) // Size = 54, Colour = dark red
        {
            default: return Exit;
        }

        B029_015: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.OUTc; goto B030_015;
            default: return Exit;
        }

        B069_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MOD; goto B072_000;
            case RR: state = state.MOD; goto B072_000;
            default: return Exit;
        }

        B007_029: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_030;
            case RD: state = state.PSH(1); goto B007_030;
            default: return Exit;
        }

        B030_015: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(122); goto B033_032;
            default: return Exit;
        }

        B072_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.NOT; goto B073_000;
            case LL: state = state.INi; goto B071_000;
            case RR: state = state.NOT; goto B073_000;
            case RL: state = state.INi; goto B071_000;
            default: return Exit;
        }

        B007_030: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_031;
            case RD: state = state.POP; goto B007_031;
            default: return Exit;
        }

        B033_032: switch (state.PT) // Size = 76, Colour = dark red
        {
            case LR: state = state.OUTc; goto B051_031;
            default: return Exit;
        }

        B073_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROT; goto B074_000;
            case LL: state = state.ROL; goto B072_000;
            case RR: state = state.ROT; goto B074_000;
            case RL: state = state.ROL; goto B072_000;
            default: return Exit;
        }

        B007_031: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B007_032;
            case RD: state = state.PSH(1); goto B007_032;
            default: return Exit;
        }

        B051_031: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(3); goto B054_031;
            default: return Exit;
        }

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
            default: return Exit;
        }

        B007_032: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B007_033;
            case RD: state = state.POP; goto B007_033;
            default: return Exit;
        }

        B054_031: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B053_015;
            default: return Exit;
        }

        B077_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B143_000;
            case RR: state = state.MUL; goto B143_000;
            default: return Exit;
        }

        B076_007: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.ROT; goto B076_008;
            default: return Exit;
        }

        B007_033: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B002_007;
            case RD: state = state.PSH(1); goto B002_007;
            default: return Exit;
        }

        B053_015: switch (state.PT) // Size = 122, Colour = red
        {
            case LR: state = state.PSH(122); goto B054_015;
            case LD: state = state.PSH(122); goto B052_033;
            case LL: state = state.RT.PSH(122); goto B053_014;
            case LT: state = state.PSH(122); goto B053_014;
            case RD: state = state.PSH(122); goto B052_033;
            default: return Exit;
        }

        B074_007: switch (state.PT) // Size = 101, Colour = dark yellow
        {
            case LL: state = state.RT.GT_; goto B074_006;
            case RD: state = state.RT.GT_; goto B074_006;
            default: return Exit;
        }

        B143_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.MUL; goto B144_000;
            case LL: state = state.OUTi; goto B142_000;
            case RR: state = state.MUL; goto B144_000;
            case RL: state = state.OUTi; goto B142_000;
            default: return Exit;
        }

        B076_008: switch (state.PT) // Size = 66, Colour = yellow
        {
            case LR: state = state.RR.PSH(66); goto B094_015;
            case LD: state = state.PSH(66); goto B092_018;
            case LL: state = state.PSH(66); goto B074_007;
            case LT: state = state.RR.PSH(66); goto B094_015;
            default: return Exit;
        }

        B054_015: switch (state.PT) // Size = 19, Colour = dark red
        {
            case LR: state = state.LL.POP; goto B053_015;
            default: return Exit;
        }

        B052_033: switch (state.PT) // Size = 58, Colour = dark red
        {
            default: return Exit;
        }

        B053_014: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.POP; goto B053_015;
            case LT: state = state.OUTc; goto B053_013;
            case RD: state = state.POP; goto B053_015;
            case RT: state = state.OUTc; goto B053_013;
            default: return Exit;
        }

        B074_006: switch (state.PT) // Size = 3, Colour = dark blue
        {
            default: return Exit;
        }

        B144_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DUP; goto B151_000;
            case RR: state = state.DUP; goto B151_000;
            default: return Exit;
        }

        B092_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.RL.POP; goto B091_018;
            case RR: state = state.RL.POP; goto B091_018;
            default: return Exit;
        }

        B094_015: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.OUTc; goto B095_015;
            default: return Exit;
        }

        B071_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.POP; goto B064_000;
            case RL: state = state.POP; goto B064_000;
            default: return Exit;
        }

        B053_013: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.PSH(1); goto B053_010;
            case RT: state = state.PSH(1); goto B053_010;
            default: return Exit;
        }

        B151_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.NOT; goto B152_000;
            case LL: state = state.DIV; goto B150_000;
            case RR: state = state.NOT; goto B152_000;
            case RL: state = state.DIV; goto B150_000;
            default: return Exit;
        }

        B091_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B092_018;
            case RL: state = state.PSH(1); goto B090_018;
            default: return Exit;
        }

        B095_015: switch (state.PT) // Size = 1, Colour = red
        {
            case RR: state = state.PSH(117); goto B119_015;
            default: return Exit;
        }

        B064_000: switch (state.PT) // Size = 5, Colour = light yellow
        {
            case LL: state = state.DIV; goto B059_000;
            case RL: state = state.DIV; goto B059_000;
            default: return Exit;
        }

        B053_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.PSH(1); goto B053_007;
            case RT: state = state.PSH(1); goto B053_007;
            default: return Exit;
        }

        B152_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROT; goto B164_000;
            case RR: state = state.ROT; goto B164_000;
            default: return Exit;
        }

        B090_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.POP; goto B091_018;
            case RL: state = state.POP; goto B089_018;
            default: return Exit;
        }

        B119_015: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.OUTc; goto B120_015;
            default: return Exit;
        }

        B053_007: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.SUB; goto B053_004;
            case RT: state = state.SUB; goto B053_004;
            default: return Exit;
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
            default: return Exit;
        }

        B089_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B090_018;
            case RL: state = state.PSH(1); goto B088_018;
            default: return Exit;
        }

        B120_015: switch (state.PT) // Size = 1, Colour = red
        {
            case RR: state = state.PSH(122); goto B122_032;
            default: return Exit;
        }

        B053_004: switch (state.PT) // Size = 1, Colour = green
        {
            case LT: state = state.PSH(1); goto B053_001;
            case RT: state = state.PSH(1); goto B053_001;
            default: return Exit;
        }

        B165_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B166_000;
            case LL: state = state.MUL; goto B164_000;
            case RR: state = state.PSH(1); goto B166_000;
            case RL: state = state.MUL; goto B164_000;
            default: return Exit;
        }

        B163_008: switch (state.PT) // Size = 37, Colour = dark blue
        {
            case LD: state = state.OUTc; goto B165_026;
            case RD: state = state.OUTc; goto B165_026;
            default: return Exit;
        }

        B163_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.ROL; goto B151_000;
            case RL: state = state.ROL; goto B151_000;
            default: return Exit;
        }

        B088_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RR: state = state.POP; goto B089_018;
            case RL: state = state.POP; goto B087_018;
            default: return Exit;
        }

        B122_032: switch (state.PT) // Size = 76, Colour = dark yellow
        {
            case RR: state = state.LR.OUTc; goto B140_031;
            default: return Exit;
        }

        B053_001: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.POP; goto B053_002;
            case LT: state = state.ROT; goto B053_000;
            case RD: state = state.POP; goto B053_002;
            case RT: state = state.ROT; goto B053_000;
            default: return Exit;
        }

        B166_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B167_000;
            case LL: state = state.POP; goto B165_000;
            case RR: state = state.ROT; goto B167_000;
            case RL: state = state.POP; goto B165_000;
            default: return Exit;
        }

        B165_026: switch (state.PT) // Size = 1, Colour = cyan
        {
            default: return Exit;
        }

        B087_018: switch (state.PT) // Size = 1, Colour = yellow
        {
            case RR: state = state.PSH(1); goto B088_018;
            case RL: state = state.PSH(1); goto B086_018;
            default: return Exit;
        }

        B140_031: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(3); goto B143_031;
            default: return Exit;
        }

        B055_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LL: state = state.POP; goto B025_000;
            case RL: state = state.POP; goto B025_000;
            default: return Exit;
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
            default: return Exit;
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
            default: return Exit;
        }

        B150_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.OUTi; goto B143_000;
            case RL: state = state.OUTi; goto B143_000;
            default: return Exit;
        }

        B086_018: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case RL: state = state.RR.POP; goto B087_018;
            default: return Exit;
        }

        B143_031: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROT; goto B142_015;
            default: return Exit;
        }

        B025_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.SWI; goto B007_000;
            case RL: state = state.SWI; goto B007_000;
            default: return Exit;
        }

        B142_015: switch (state.PT) // Size = 122, Colour = yellow
        {
            case LR: state = state.PSH(122); goto B143_015;
            case LD: state = state.PSH(122); goto B141_033;
            case LL: state = state.RT.PSH(122); goto B142_014;
            case LT: state = state.PSH(122); goto B142_014;
            default: return Exit;
        }

        B053_002: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.OUTc; goto B053_005;
            case RD: state = state.OUTc; goto B053_005;
            default: return Exit;
        }

        B142_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LL: state = state.POP; goto B076_000;
            case RL: state = state.POP; goto B076_000;
            default: return Exit;
        }

        B143_015: switch (state.PT) // Size = 19, Colour = dark yellow
        {
            case LR: state = state.LL.POP; goto B142_015;
            default: return Exit;
        }

        B141_033: switch (state.PT) // Size = 58, Colour = dark yellow
        {
            default: return Exit;
        }

        B142_014: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.OUTc; goto B142_013;
            case RT: state = state.OUTc; goto B142_013;
            default: return Exit;
        }

        B053_005: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.POP; goto B053_008;
            case RD: state = state.POP; goto B053_008;
            default: return Exit;
        }

        B076_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LL: state = state.SWI; goto B073_000;
            case RL: state = state.SWI; goto B073_000;
            default: return Exit;
        }

        B142_013: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B142_010;
            case RT: state = state.PSH(1); goto B142_010;
            default: return Exit;
        }

        B053_008: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.POP; goto B053_011;
            case RD: state = state.POP; goto B053_011;
            default: return Exit;
        }

        B142_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.PSH(1); goto B142_007;
            case RT: state = state.PSH(1); goto B142_007;
            default: return Exit;
        }

        B053_011: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.SUB; goto B053_014;
            case RD: state = state.SUB; goto B053_014;
            default: return Exit;
        }

        B142_007: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.SUB; goto B142_004;
            case RT: state = state.SUB; goto B142_004;
            default: return Exit;
        }

        B142_004: switch (state.PT) // Size = 1, Colour = green
        {
            case LT: state = state.RR.MUL; goto B143_000;
            case RT: state = state.LR.MUL; goto B143_000;
            default: return Exit;
        }
    }
}
