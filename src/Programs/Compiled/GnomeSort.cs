#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class GnomeSort
{
    private const bool Exit = true;

    public static bool Execute(State state)
    {
        B000_000: switch (state.PT) // Size = 10, Colour = light red
        {
            case LR: state = state.PSH(10); goto B001_000;
            default: return Exit;
        }

        B001_000: switch (state.PT) // Size = 22, Colour = red
        {
            case LR: state = state.PSH(22); goto B002_000;
            default: return Exit;
        }

        B002_000: switch (state.PT) // Size = 23, Colour = dark red
        {
            case LR: state = state.PSH(23); goto B003_000;
            default: return Exit;
        }

        B003_000: switch (state.PT) // Size = 4, Colour = light red
        {
            case LR: state = state.PSH(4); goto B004_000;
            default: return Exit;
        }

        B004_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.MUL; goto B005_000;
            default: return Exit;
        }

        B005_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ADD; goto B006_000;
            default: return Exit;
        }

        B006_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B007_000;
            default: return Exit;
        }

        B007_000: switch (state.PT) // Size = 13, Colour = light red
        {
            case LR: state = state.PSH(13); goto B008_000;
            default: return Exit;
        }

        B008_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B009_000;
            default: return Exit;
        }

        B009_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.DUP; goto B010_000;
            default: return Exit;
        }

        B010_000: switch (state.PT) // Size = 15, Colour = dark magenta
        {
            case LR: state = state.PSH(15); goto B011_000;
            default: return Exit;
        }

        B011_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ADD; goto B012_000;
            default: return Exit;
        }

        B012_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.RD.DUP; goto B013_010;
            default: return Exit;
        }

        B013_010: switch (state.PT) // Size = 8, Colour = light blue
        {
            case RD: state = state.PSH(8); goto B013_018;
            default: return Exit;
        }

        B013_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B013_019;
            default: return Exit;
        }

        B013_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B013_021;
            default: return Exit;
        }

        B013_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B013_022;
            default: return Exit;
        }

        B013_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B015_010;
            case RD: state = state.RT.DUP; goto B015_010;
            case RL: state = state.LT.DUP; goto B015_010;
            case RT: state = state.DUP; goto B015_010;
            default: return Exit;
        }

        B015_010: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B015_009;
            case RT: state = state.PSH(9); goto B015_009;
            default: return Exit;
        }

        B015_009: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B015_008;
            case RT: state = state.ADD; goto B015_008;
            default: return Exit;
        }

        B015_008: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B017_005;
            case RT: state = state.RD.DUP; goto B017_005;
            default: return Exit;
        }

        B017_005: switch (state.PT) // Size = 13, Colour = light blue
        {
            case LD: state = state.PSH(13); goto B017_018;
            case RD: state = state.PSH(13); goto B017_018;
            default: return Exit;
        }

        B017_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B017_019;
            case RD: state = state.SUB; goto B017_019;
            default: return Exit;
        }

        B017_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B017_021;
            case RD: state = state.PSH(2); goto B017_021;
            default: return Exit;
        }

        B017_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B017_022;
            case RD: state = state.ROT; goto B017_022;
            default: return Exit;
        }

        B017_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B019_014;
            case LD: state = state.LT.DUP; goto B019_014;
            case LL: state = state.RT.DUP; goto B019_014;
            case LT: state = state.DUP; goto B019_014;
            case RR: state = state.LT.DUP; goto B019_014;
            case RD: state = state.RT.DUP; goto B019_014;
            case RL: state = state.LT.DUP; goto B019_014;
            case RT: state = state.DUP; goto B019_014;
            default: return Exit;
        }

        B019_014: switch (state.PT) // Size = 5, Colour = red
        {
            case LT: state = state.PSH(5); goto B019_013;
            case RT: state = state.PSH(5); goto B019_013;
            default: return Exit;
        }

        B019_013: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B019_012;
            case RT: state = state.SUB; goto B019_012;
            default: return Exit;
        }

        B019_012: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.RR.DUP; goto B021_000;
            case RT: state = state.LR.DUP; goto B021_000;
            default: return Exit;
        }

        B021_000: switch (state.PT) // Size = 16, Colour = light blue
        {
            case LR: state = state.PSH(16); goto B022_000;
            case RR: state = state.LR.PSH(16); goto B022_000;
            default: return Exit;
        }

        B022_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.SUB; goto B023_000;
            default: return Exit;
        }

        B023_000: switch (state.PT) // Size = 9, Colour = dark magenta
        {
            case LR: state = state.PSH(9); goto B024_000;
            default: return Exit;
        }

        B024_000: switch (state.PT) // Size = 23, Colour = light magenta
        {
            case LR: state = state.PSH(23); goto B025_000;
            default: return Exit;
        }

        B025_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ADD; goto B026_000;
            default: return Exit;
        }

        B026_000: switch (state.PT) // Size = 5, Colour = red
        {
            case LR: state = state.PSH(5); goto B027_000;
            default: return Exit;
        }

        B027_000: switch (state.PT) // Size = 23, Colour = dark red
        {
            case LR: state = state.PSH(23); goto B028_000;
            default: return Exit;
        }

        B028_000: switch (state.PT) // Size = 4, Colour = light red
        {
            case LR: state = state.PSH(4); goto B029_000;
            default: return Exit;
        }

        B029_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.MUL; goto B030_000;
            default: return Exit;
        }

        B030_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ADD; goto B031_000;
            default: return Exit;
        }

        B031_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B032_000;
            default: return Exit;
        }

        B032_000: switch (state.PT) // Size = 20, Colour = light red
        {
            case LR: state = state.PSH(20); goto B033_000;
            default: return Exit;
        }

        B033_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ADD; goto B034_000;
            default: return Exit;
        }

        B034_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.RD.DUP; goto B035_005;
            default: return Exit;
        }

        B035_005: switch (state.PT) // Size = 13, Colour = light blue
        {
            case RD: state = state.PSH(13); goto B035_018;
            default: return Exit;
        }

        B035_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B035_019;
            default: return Exit;
        }

        B035_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B035_021;
            default: return Exit;
        }

        B035_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B035_022;
            default: return Exit;
        }

        B035_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B037_008;
            case RD: state = state.RT.DUP; goto B037_008;
            case RL: state = state.LT.DUP; goto B037_008;
            case RT: state = state.DUP; goto B037_008;
            default: return Exit;
        }

        B037_008: switch (state.PT) // Size = 11, Colour = red
        {
            case LT: state = state.PSH(11); goto B037_007;
            case RT: state = state.PSH(11); goto B037_007;
            default: return Exit;
        }

        B037_007: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B037_006;
            case RT: state = state.ADD; goto B037_006;
            default: return Exit;
        }

        B037_006: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.RR.DUP; goto B039_000;
            case RT: state = state.LR.DUP; goto B039_000;
            default: return Exit;
        }

        B039_000: switch (state.PT) // Size = 4, Colour = magenta
        {
            case LR: state = state.PSH(4); goto B040_000;
            case RR: state = state.LR.PSH(4); goto B040_000;
            default: return Exit;
        }

        B040_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.SUB; goto B041_000;
            default: return Exit;
        }

        B041_000: switch (state.PT) // Size = 5, Colour = light red
        {
            case LR: state = state.PSH(5); goto B042_000;
            default: return Exit;
        }

        B042_000: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B043_000;
            default: return Exit;
        }

        B043_000: switch (state.PT) // Size = 3, Colour = dark red
        {
            case LR: state = state.PSH(3); goto B044_000;
            default: return Exit;
        }

        B044_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.MUL; goto B045_000;
            default: return Exit;
        }

        B045_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B046_000;
            default: return Exit;
        }

        B046_000: switch (state.PT) // Size = 9, Colour = dark green
        {
            case LR: state = state.PSH(9); goto B047_000;
            default: return Exit;
        }

        B047_000: switch (state.PT) // Size = 23, Colour = light green
        {
            case LR: state = state.PSH(23); goto B048_000;
            default: return Exit;
        }

        B048_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B049_000;
            default: return Exit;
        }

        B049_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B050_000;
            default: return Exit;
        }

        B050_000: switch (state.PT) // Size = 16, Colour = yellow
        {
            case LR: state = state.PSH(16); goto B051_000;
            default: return Exit;
        }

        B051_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B052_000;
            default: return Exit;
        }

        B052_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.RD.DUP; goto B053_017;
            default: return Exit;
        }

        B053_017: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RD: state = state.PSH(1); goto B053_018;
            default: return Exit;
        }

        B053_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B053_019;
            default: return Exit;
        }

        B053_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B053_021;
            default: return Exit;
        }

        B053_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B053_022;
            default: return Exit;
        }

        B053_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B055_018;
            case RD: state = state.RT.DUP; goto B055_018;
            case RL: state = state.LT.DUP; goto B055_018;
            case RT: state = state.DUP; goto B055_018;
            default: return Exit;
        }

        B055_018: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state.PSH(1); goto B055_017;
            case RT: state = state.PSH(1); goto B055_017;
            default: return Exit;
        }

        B055_017: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B055_016;
            case RT: state = state.SUB; goto B055_016;
            default: return Exit;
        }

        B055_016: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B055_014;
            case RT: state = state.DUP; goto B055_014;
            default: return Exit;
        }

        B055_014: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LT: state = state.PSH(2); goto B055_013;
            case RT: state = state.PSH(2); goto B055_013;
            default: return Exit;
        }

        B055_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B055_012;
            case RT: state = state.ADD; goto B055_012;
            default: return Exit;
        }

        B055_012: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state.RR.DUP; goto B057_000;
            case RT: state = state.LR.DUP; goto B057_000;
            default: return Exit;
        }

        B057_000: switch (state.PT) // Size = 18, Colour = dark red
        {
            case LR: state = state.PSH(18); goto B058_000;
            case RR: state = state.LR.PSH(18); goto B058_000;
            default: return Exit;
        }

        B058_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.SUB; goto B059_000;
            default: return Exit;
        }

        B059_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B060_000;
            default: return Exit;
        }

        B060_000: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LR: state = state.PSH(23); goto B061_000;
            default: return Exit;
        }

        B061_000: switch (state.PT) // Size = 5, Colour = light yellow
        {
            case LR: state = state.PSH(5); goto B062_000;
            default: return Exit;
        }

        B062_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B063_000;
            default: return Exit;
        }

        B063_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ADD; goto B064_000;
            default: return Exit;
        }

        B064_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.RD.DUP; goto B065_006;
            default: return Exit;
        }

        B065_006: switch (state.PT) // Size = 12, Colour = light blue
        {
            case RD: state = state.PSH(12); goto B065_018;
            default: return Exit;
        }

        B065_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B065_019;
            default: return Exit;
        }

        B065_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B065_021;
            default: return Exit;
        }

        B065_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B065_022;
            default: return Exit;
        }

        B065_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B067_018;
            case RD: state = state.RT.DUP; goto B067_018;
            case RL: state = state.LT.DUP; goto B067_018;
            case RT: state = state.DUP; goto B067_018;
            default: return Exit;
        }

        B067_018: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B067_017;
            case RT: state = state.PSH(1); goto B067_017;
            default: return Exit;
        }

        B067_017: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B067_016;
            case RT: state = state.SUB; goto B067_016;
            default: return Exit;
        }

        B067_016: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B067_014;
            case RT: state = state.DUP; goto B067_014;
            default: return Exit;
        }

        B067_014: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LT: state = state.PSH(2); goto B067_013;
            case RT: state = state.PSH(2); goto B067_013;
            default: return Exit;
        }

        B067_013: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B067_012;
            case RT: state = state.ADD; goto B067_012;
            default: return Exit;
        }

        B067_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.LD.DUP; goto B069_009;
            case RT: state = state.RD.DUP; goto B069_009;
            default: return Exit;
        }

        B069_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B069_018;
            case RD: state = state.PSH(9); goto B069_018;
            default: return Exit;
        }

        B069_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B069_019;
            case RD: state = state.ADD; goto B069_019;
            default: return Exit;
        }

        B069_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LD: state = state.PSH(2); goto B069_021;
            case RD: state = state.PSH(2); goto B069_021;
            default: return Exit;
        }

        B069_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROT; goto B069_022;
            case RD: state = state.ROT; goto B069_022;
            default: return Exit;
        }

        B069_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.RT.DUP; goto B071_012;
            case LD: state = state.LT.DUP; goto B071_012;
            case LL: state = state.RT.DUP; goto B071_012;
            case LT: state = state.DUP; goto B071_012;
            case RR: state = state.LT.DUP; goto B071_012;
            case RD: state = state.RT.DUP; goto B071_012;
            case RL: state = state.LT.DUP; goto B071_012;
            case RT: state = state.DUP; goto B071_012;
            default: return Exit;
        }

        B071_012: switch (state.PT) // Size = 7, Colour = light red
        {
            case LT: state = state.PSH(7); goto B071_011;
            case RT: state = state.PSH(7); goto B071_011;
            default: return Exit;
        }

        B071_011: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.ADD; goto B071_010;
            case RT: state = state.ADD; goto B071_010;
            default: return Exit;
        }

        B071_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.LD.DUP; goto B073_009;
            case RT: state = state.RD.DUP; goto B073_009;
            default: return Exit;
        }

        B073_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B073_018;
            case RD: state = state.PSH(9); goto B073_018;
            default: return Exit;
        }

        B073_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B073_019;
            case RD: state = state.SUB; goto B073_019;
            default: return Exit;
        }

        B073_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B073_021;
            case RD: state = state.PSH(2); goto B073_021;
            default: return Exit;
        }

        B073_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B073_022;
            case RD: state = state.ROT; goto B073_022;
            default: return Exit;
        }

        B073_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B075_018;
            case LD: state = state.LT.DUP; goto B075_018;
            case LL: state = state.RT.DUP; goto B075_018;
            case LT: state = state.DUP; goto B075_018;
            case RR: state = state.LT.DUP; goto B075_018;
            case RD: state = state.RT.DUP; goto B075_018;
            case RL: state = state.LT.DUP; goto B075_018;
            case RT: state = state.DUP; goto B075_018;
            default: return Exit;
        }

        B075_018: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B075_017;
            case RT: state = state.PSH(1); goto B075_017;
            default: return Exit;
        }

        B075_017: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B075_016;
            case RT: state = state.SUB; goto B075_016;
            default: return Exit;
        }

        B075_016: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.RR.PSH(21); goto B078_000;
            case RT: state = state.LR.PSH(21); goto B078_000;
            default: return Exit;
        }

        B078_000: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B079_000;
            case RR: state = state.LR.PSH(23); goto B079_000;
            default: return Exit;
        }

        B079_000: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.PSH(2); goto B080_000;
            default: return Exit;
        }

        B080_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.MUL; goto B081_000;
            default: return Exit;
        }

        B081_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B082_000;
            default: return Exit;
        }

        B082_000: switch (state.PT) // Size = 10, Colour = dark magenta
        {
            case LR: state = state.PSH(10); goto B083_000;
            default: return Exit;
        }

        B083_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.PSH(1); goto B084_000;
            default: return Exit;
        }

        B084_000: switch (state.PT) // Size = 23, Colour = magenta
        {
            case LR: state = state.PSH(23); goto B085_000;
            default: return Exit;
        }

        B085_000: switch (state.PT) // Size = 5, Colour = dark magenta
        {
            case LR: state = state.PSH(5); goto B086_000;
            default: return Exit;
        }

        B086_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.MUL; goto B087_000;
            default: return Exit;
        }

        B087_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B088_000;
            default: return Exit;
        }

        B088_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.DUP; goto B089_000;
            default: return Exit;
        }

        B089_000: switch (state.PT) // Size = 15, Colour = dark magenta
        {
            case LR: state = state.PSH(15); goto B090_000;
            default: return Exit;
        }

        B090_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B091_000;
            default: return Exit;
        }

        B091_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.RD.DUP; goto B092_014;
            default: return Exit;
        }

        B092_014: switch (state.PT) // Size = 4, Colour = light blue
        {
            case RD: state = state.PSH(4); goto B092_018;
            default: return Exit;
        }

        B092_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B092_019;
            default: return Exit;
        }

        B092_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B092_021;
            default: return Exit;
        }

        B092_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B092_022;
            default: return Exit;
        }

        B092_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B094_012;
            case RD: state = state.RT.DUP; goto B094_012;
            case RL: state = state.LT.DUP; goto B094_012;
            case RT: state = state.DUP; goto B094_012;
            default: return Exit;
        }

        B094_012: switch (state.PT) // Size = 7, Colour = light red
        {
            case LT: state = state.PSH(7); goto B094_011;
            case RT: state = state.PSH(7); goto B094_011;
            default: return Exit;
        }

        B094_011: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.ADD; goto B094_010;
            case RT: state = state.ADD; goto B094_010;
            default: return Exit;
        }

        B094_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state.RR.PSH(9); goto B097_000;
            case RT: state = state.LR.PSH(9); goto B097_000;
            default: return Exit;
        }

        B097_000: switch (state.PT) // Size = 23, Colour = dark red
        {
            case LR: state = state.PSH(23); goto B098_000;
            case RR: state = state.LR.PSH(23); goto B098_000;
            default: return Exit;
        }

        B098_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ADD; goto B099_000;
            default: return Exit;
        }

        B099_000: switch (state.PT) // Size = 18, Colour = light yellow
        {
            case LR: state = state.PSH(18); goto B100_000;
            default: return Exit;
        }

        B100_000: switch (state.PT) // Size = 23, Colour = yellow
        {
            case LR: state = state.PSH(23); goto B101_000;
            default: return Exit;
        }

        B101_000: switch (state.PT) // Size = 4, Colour = dark yellow
        {
            case LR: state = state.PSH(4); goto B102_000;
            default: return Exit;
        }

        B102_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.MUL; goto B103_000;
            default: return Exit;
        }

        B103_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ADD; goto B104_000;
            default: return Exit;
        }

        B104_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B105_000;
            default: return Exit;
        }

        B105_000: switch (state.PT) // Size = 5, Colour = dark yellow
        {
            case LR: state = state.PSH(5); goto B106_000;
            default: return Exit;
        }

        B106_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.SUB; goto B107_000;
            default: return Exit;
        }

        B107_000: switch (state.PT) // Size = 9, Colour = green
        {
            case LR: state = state.PSH(9); goto B108_000;
            default: return Exit;
        }

        B108_000: switch (state.PT) // Size = 23, Colour = dark green
        {
            case LR: state = state.PSH(23); goto B109_000;
            default: return Exit;
        }

        B109_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ADD; goto B110_000;
            default: return Exit;
        }

        B110_000: switch (state.PT) // Size = 18, Colour = light cyan
        {
            case LR: state = state.PSH(18); goto B111_000;
            default: return Exit;
        }

        B111_000: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B112_000;
            default: return Exit;
        }

        B112_000: switch (state.PT) // Size = 4, Colour = dark cyan
        {
            case LR: state = state.PSH(4); goto B113_000;
            default: return Exit;
        }

        B113_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.MUL; goto B114_000;
            default: return Exit;
        }

        B114_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B115_000;
            default: return Exit;
        }

        B115_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B116_000;
            default: return Exit;
        }

        B116_000: switch (state.PT) // Size = 9, Colour = dark cyan
        {
            case LR: state = state.PSH(9); goto B117_000;
            default: return Exit;
        }

        B117_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.SUB; goto B118_000;
            default: return Exit;
        }

        B118_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B119_000;
            default: return Exit;
        }

        B119_000: switch (state.PT) // Size = 15, Colour = green
        {
            case LR: state = state.PSH(15); goto B120_000;
            default: return Exit;
        }

        B120_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ADD; goto B121_000;
            default: return Exit;
        }

        B121_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B122_000;
            default: return Exit;
        }

        B122_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.RD.DUP; goto B123_007;
            default: return Exit;
        }

        B123_007: switch (state.PT) // Size = 11, Colour = light blue
        {
            case RD: state = state.PSH(11); goto B123_018;
            default: return Exit;
        }

        B123_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B123_019;
            default: return Exit;
        }

        B123_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B123_021;
            default: return Exit;
        }

        B123_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B123_022;
            default: return Exit;
        }

        B123_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B125_010;
            case RD: state = state.RT.DUP; goto B125_010;
            case RL: state = state.LT.DUP; goto B125_010;
            case RT: state = state.DUP; goto B125_010;
            default: return Exit;
        }

        B125_010: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B125_009;
            case RT: state = state.PSH(9); goto B125_009;
            default: return Exit;
        }

        B125_009: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B125_008;
            case RT: state = state.ADD; goto B125_008;
            default: return Exit;
        }

        B125_008: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.RR.DUP; goto B127_000;
            case RT: state = state.LR.DUP; goto B127_000;
            default: return Exit;
        }

        B127_000: switch (state.PT) // Size = 5, Colour = dark magenta
        {
            case LR: state = state.PSH(5); goto B128_000;
            case RR: state = state.LR.PSH(5); goto B128_000;
            default: return Exit;
        }

        B128_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ADD; goto B129_000;
            default: return Exit;
        }

        B129_000: switch (state.PT) // Size = 9, Colour = light red
        {
            case LR: state = state.PSH(9); goto B130_000;
            default: return Exit;
        }

        B130_000: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B131_000;
            default: return Exit;
        }

        B131_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B132_000;
            default: return Exit;
        }

        B132_000: switch (state.PT) // Size = 17, Colour = dark yellow
        {
            case LR: state = state.PSH(17); goto B133_000;
            default: return Exit;
        }

        B133_000: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LR: state = state.PSH(23); goto B134_000;
            default: return Exit;
        }

        B134_000: switch (state.PT) // Size = 4, Colour = yellow
        {
            case LR: state = state.PSH(4); goto B135_000;
            default: return Exit;
        }

        B135_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.MUL; goto B136_000;
            default: return Exit;
        }

        B136_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B137_000;
            default: return Exit;
        }

        B137_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B138_000;
            default: return Exit;
        }

        B138_000: switch (state.PT) // Size = 12, Colour = yellow
        {
            case LR: state = state.PSH(12); goto B139_000;
            default: return Exit;
        }

        B139_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.SUB; goto B140_000;
            default: return Exit;
        }

        B140_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B141_000;
            default: return Exit;
        }

        B141_000: switch (state.PT) // Size = 17, Colour = light red
        {
            case LR: state = state.PSH(17); goto B142_000;
            default: return Exit;
        }

        B142_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ADD; goto B143_000;
            default: return Exit;
        }

        B143_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.RD.DUP; goto B144_007;
            default: return Exit;
        }

        B144_007: switch (state.PT) // Size = 11, Colour = light blue
        {
            case RD: state = state.PSH(11); goto B144_018;
            default: return Exit;
        }

        B144_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B144_019;
            default: return Exit;
        }

        B144_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B144_021;
            default: return Exit;
        }

        B144_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B144_022;
            default: return Exit;
        }

        B144_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B146_011;
            case RD: state = state.RT.DUP; goto B146_011;
            case RL: state = state.LT.DUP; goto B146_011;
            case RT: state = state.DUP; goto B146_011;
            default: return Exit;
        }

        B146_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B146_010;
            case RT: state = state.PSH(8); goto B146_010;
            default: return Exit;
        }

        B146_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B146_009;
            case RT: state = state.ADD; goto B146_009;
            default: return Exit;
        }

        B146_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B146_006;
            case RT: state = state.DUP; goto B146_006;
            default: return Exit;
        }

        B146_006: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LT: state = state.PSH(3); goto B146_005;
            case RT: state = state.PSH(3); goto B146_005;
            default: return Exit;
        }

        B146_005: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B146_004;
            case RT: state = state.ADD; goto B146_004;
            default: return Exit;
        }

        B146_004: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state.RR.DUP; goto B148_000;
            case RT: state = state.LR.DUP; goto B148_000;
            default: return Exit;
        }

        B148_000: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LR: state = state.PSH(2); goto B149_000;
            case RR: state = state.LR.PSH(2); goto B149_000;
            default: return Exit;
        }

        B149_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.SUB; goto B150_000;
            default: return Exit;
        }

        B150_000: switch (state.PT) // Size = 9, Colour = light red
        {
            case LR: state = state.PSH(9); goto B151_000;
            default: return Exit;
        }

        B151_000: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B152_000;
            default: return Exit;
        }

        B152_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B153_000;
            default: return Exit;
        }

        B153_000: switch (state.PT) // Size = 11, Colour = dark yellow
        {
            case LR: state = state.PSH(11); goto B154_000;
            default: return Exit;
        }

        B154_000: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LR: state = state.PSH(23); goto B155_000;
            default: return Exit;
        }

        B155_000: switch (state.PT) // Size = 4, Colour = yellow
        {
            case LR: state = state.PSH(4); goto B156_000;
            default: return Exit;
        }

        B156_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.MUL; goto B157_000;
            default: return Exit;
        }

        B157_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B158_000;
            default: return Exit;
        }

        B158_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.RD.DUP; goto B159_011;
            default: return Exit;
        }

        B159_011: switch (state.PT) // Size = 7, Colour = light blue
        {
            case RD: state = state.PSH(7); goto B159_018;
            default: return Exit;
        }

        B159_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B159_019;
            default: return Exit;
        }

        B159_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B159_021;
            default: return Exit;
        }

        B159_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B159_022;
            default: return Exit;
        }

        B159_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B161_014;
            case RD: state = state.RT.DUP; goto B161_014;
            case RL: state = state.LT.DUP; goto B161_014;
            case RT: state = state.DUP; goto B161_014;
            default: return Exit;
        }

        B161_014: switch (state.PT) // Size = 5, Colour = light red
        {
            case LT: state = state.PSH(5); goto B161_013;
            case RT: state = state.PSH(5); goto B161_013;
            default: return Exit;
        }

        B161_013: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B161_012;
            case RT: state = state.SUB; goto B161_012;
            default: return Exit;
        }

        B161_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B163_007;
            case RT: state = state.RD.DUP; goto B163_007;
            default: return Exit;
        }

        B163_007: switch (state.PT) // Size = 11, Colour = light blue
        {
            case LD: state = state.PSH(11); goto B163_018;
            case RD: state = state.PSH(11); goto B163_018;
            default: return Exit;
        }

        B163_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B163_019;
            case RD: state = state.ADD; goto B163_019;
            default: return Exit;
        }

        B163_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LD: state = state.PSH(2); goto B163_021;
            case RD: state = state.PSH(2); goto B163_021;
            default: return Exit;
        }

        B163_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROT; goto B163_022;
            case RD: state = state.ROT; goto B163_022;
            default: return Exit;
        }

        B163_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.RT.DUP; goto B165_017;
            case LD: state = state.LT.DUP; goto B165_017;
            case LL: state = state.RT.DUP; goto B165_017;
            case LT: state = state.DUP; goto B165_017;
            case RR: state = state.LT.DUP; goto B165_017;
            case RD: state = state.RT.DUP; goto B165_017;
            case RL: state = state.LT.DUP; goto B165_017;
            case RT: state = state.DUP; goto B165_017;
            default: return Exit;
        }

        B165_017: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.PSH(2); goto B165_016;
            case RT: state = state.PSH(2); goto B165_016;
            default: return Exit;
        }

        B165_016: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B165_015;
            case RT: state = state.SUB; goto B165_015;
            default: return Exit;
        }

        B165_015: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B165_012;
            case RT: state = state.DUP; goto B165_012;
            default: return Exit;
        }

        B165_012: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LT: state = state.PSH(3); goto B165_011;
            case RT: state = state.PSH(3); goto B165_011;
            default: return Exit;
        }

        B165_011: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.SUB; goto B165_010;
            case RT: state = state.SUB; goto B165_010;
            default: return Exit;
        }

        B165_010: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.DUP; goto B165_006;
            case RT: state = state.DUP; goto B165_006;
            default: return Exit;
        }

        B165_006: switch (state.PT) // Size = 4, Colour = blue
        {
            case LT: state = state.PSH(4); goto B165_005;
            case RT: state = state.PSH(4); goto B165_005;
            default: return Exit;
        }

        B165_005: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LT: state = state.ADD; goto B165_004;
            case RT: state = state.ADD; goto B165_004;
            default: return Exit;
        }

        B165_004: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state.RR.PSH(9); goto B168_000;
            case RT: state = state.LR.PSH(9); goto B168_000;
            default: return Exit;
        }

        B168_000: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LR: state = state.PSH(23); goto B169_000;
            case RR: state = state.LR.PSH(23); goto B169_000;
            default: return Exit;
        }

        B169_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B170_000;
            default: return Exit;
        }

        B170_000: switch (state.PT) // Size = 5, Colour = light blue
        {
            case LR: state = state.PSH(5); goto B171_000;
            default: return Exit;
        }

        B171_000: switch (state.PT) // Size = 23, Colour = blue
        {
            case LR: state = state.PSH(23); goto B172_000;
            default: return Exit;
        }

        B172_000: switch (state.PT) // Size = 4, Colour = dark blue
        {
            case LR: state = state.PSH(4); goto B173_000;
            default: return Exit;
        }

        B173_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.MUL; goto B174_000;
            default: return Exit;
        }

        B174_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.ADD; goto B175_000;
            default: return Exit;
        }

        B175_000: switch (state.PT) // Size = 9, Colour = dark red
        {
            case LR: state = state.PSH(9); goto B176_000;
            default: return Exit;
        }

        B176_000: switch (state.PT) // Size = 23, Colour = light red
        {
            case LR: state = state.PSH(23); goto B177_000;
            default: return Exit;
        }

        B177_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ADD; goto B178_000;
            default: return Exit;
        }

        B178_000: switch (state.PT) // Size = 12, Colour = yellow
        {
            case LR: state = state.PSH(12); goto B179_000;
            default: return Exit;
        }

        B179_000: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LR: state = state.PSH(23); goto B180_000;
            default: return Exit;
        }

        B180_000: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LR: state = state.PSH(2); goto B181_000;
            default: return Exit;
        }

        B181_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B182_000;
            default: return Exit;
        }

        B182_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ADD; goto B183_000;
            default: return Exit;
        }

        B183_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B184_000;
            default: return Exit;
        }

        B184_000: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B185_000;
            default: return Exit;
        }

        B185_000: switch (state.PT) // Size = 5, Colour = dark cyan
        {
            case LR: state = state.PSH(5); goto B186_000;
            default: return Exit;
        }

        B186_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.MUL; goto B187_000;
            default: return Exit;
        }

        B187_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B188_000;
            default: return Exit;
        }

        B188_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.RD.DUP; goto B189_016;
            default: return Exit;
        }

        B189_016: switch (state.PT) // Size = 2, Colour = light blue
        {
            case RD: state = state.PSH(2); goto B189_018;
            default: return Exit;
        }

        B189_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B189_019;
            default: return Exit;
        }

        B189_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B189_021;
            default: return Exit;
        }

        B189_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B189_022;
            default: return Exit;
        }

        B189_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B191_016;
            case RD: state = state.RT.DUP; goto B191_016;
            case RL: state = state.LT.DUP; goto B191_016;
            case RT: state = state.DUP; goto B191_016;
            default: return Exit;
        }

        B191_016: switch (state.PT) // Size = 3, Colour = red
        {
            case LT: state = state.PSH(3); goto B191_015;
            case RT: state = state.PSH(3); goto B191_015;
            default: return Exit;
        }

        B191_015: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B191_014;
            case RT: state = state.SUB; goto B191_014;
            default: return Exit;
        }

        B191_014: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B191_010;
            case RT: state = state.DUP; goto B191_010;
            default: return Exit;
        }

        B191_010: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LT: state = state.PSH(4); goto B191_009;
            case RT: state = state.PSH(4); goto B191_009;
            default: return Exit;
        }

        B191_009: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B191_008;
            case RT: state = state.ADD; goto B191_008;
            default: return Exit;
        }

        B191_008: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.DUP; goto B191_007;
            case RT: state = state.DUP; goto B191_007;
            default: return Exit;
        }

        B191_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LT: state = state.PSH(1); goto B191_006;
            case RT: state = state.PSH(1); goto B191_006;
            default: return Exit;
        }

        B191_006: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LT: state = state.ADD; goto B191_005;
            case RT: state = state.ADD; goto B191_005;
            default: return Exit;
        }

        B191_005: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state.RR.DUP; goto B193_000;
            case RT: state = state.LR.DUP; goto B193_000;
            default: return Exit;
        }

        B193_000: switch (state.PT) // Size = 15, Colour = dark cyan
        {
            case LR: state = state.PSH(15); goto B194_000;
            case RR: state = state.LR.PSH(15); goto B194_000;
            default: return Exit;
        }

        B194_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.SUB; goto B195_000;
            default: return Exit;
        }

        B195_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.DUP; goto B196_000;
            default: return Exit;
        }

        B196_000: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.PSH(4); goto B197_000;
            default: return Exit;
        }

        B197_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ADD; goto B198_000;
            default: return Exit;
        }

        B198_000: switch (state.PT) // Size = 11, Colour = dark cyan
        {
            case LR: state = state.PSH(11); goto B199_000;
            default: return Exit;
        }

        B199_000: switch (state.PT) // Size = 23, Colour = light cyan
        {
            case LR: state = state.PSH(23); goto B200_000;
            default: return Exit;
        }

        B200_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B201_000;
            default: return Exit;
        }

        B201_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.MUL; goto B202_000;
            default: return Exit;
        }

        B202_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.ADD; goto B203_000;
            default: return Exit;
        }

        B203_000: switch (state.PT) // Size = 6, Colour = magenta
        {
            case LR: state = state.PSH(6); goto B204_000;
            default: return Exit;
        }

        B204_000: switch (state.PT) // Size = 23, Colour = dark magenta
        {
            case LR: state = state.PSH(23); goto B205_000;
            default: return Exit;
        }

        B205_000: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state.PSH(3); goto B206_000;
            default: return Exit;
        }

        B206_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.MUL; goto B207_000;
            default: return Exit;
        }

        B207_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ADD; goto B208_000;
            default: return Exit;
        }

        B208_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.RD.PSH(2); goto B211_002;
            default: return Exit;
        }

        B211_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B211_003;
            case LT: state = state.POP; goto B211_000;
            case RD: state = state.PSH(1); goto B211_003;
            case RT: state = state.POP; goto B211_000;
            default: return Exit;
        }

        B211_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B211_004;
            case LT: state = state.POP; goto B211_002;
            case RD: state = state.ROL; goto B211_004;
            case RT: state = state.POP; goto B211_002;
            default: return Exit;
        }

        B211_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B211_005;
            case LT: state = state.NOT; goto B211_003;
            case RD: state = state.OUTc; goto B211_005;
            case RT: state = state.NOT; goto B211_003;
            default: return Exit;
        }

        B211_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B211_006;
            case LT: state = state.SUB; goto B211_004;
            case RD: state = state.PSH(1); goto B211_006;
            case RT: state = state.SUB; goto B211_004;
            default: return Exit;
        }

        B211_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B211_007;
            case LT: state = state.POP; goto B211_005;
            case RD: state = state.SUB; goto B211_007;
            case RT: state = state.POP; goto B211_005;
            default: return Exit;
        }

        B211_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B211_008;
            case LT: state = state.OUTc; goto B211_006;
            case RD: state = state.DUP; goto B211_008;
            case RT: state = state.OUTc; goto B211_006;
            default: return Exit;
        }

        B211_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B211_009;
            case LT: state = state.DIV; goto B211_007;
            case RD: state = state.NOT; goto B211_009;
            case RT: state = state.DIV; goto B211_007;
            default: return Exit;
        }

        B211_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B211_012;
            case LT: state = state.ROL; goto B211_008;
            case RD: state = state.PSH(3); goto B211_012;
            case RT: state = state.ROL; goto B211_008;
            default: return Exit;
        }

        B211_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B211_013;
            case LT: state = state.POP; goto B211_009;
            case RD: state = state.MUL; goto B211_013;
            case RT: state = state.POP; goto B211_009;
            default: return Exit;
        }

        B211_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B211_014;
            case LT: state = state.OUTi; goto B211_012;
            case RD: state = state.DUP; goto B211_014;
            case RT: state = state.OUTi; goto B211_012;
            default: return Exit;
        }

        B211_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B211_015;
            case LT: state = state.DIV; goto B211_013;
            case RD: state = state.ROT; goto B211_015;
            case RT: state = state.DIV; goto B211_013;
            default: return Exit;
        }

        B211_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B212_015;
            case LD: state = state.POP; goto B211_016;
            case LL: state = state.RT.SWI; goto B211_014;
            case LT: state = state.SWI; goto B211_014;
            case RR: state = state.ROT; goto B212_015;
            case RD: state = state.POP; goto B211_016;
            case RL: state = state.LT.SWI; goto B211_014;
            case RT: state = state.SWI; goto B211_014;
            default: return Exit;
        }

        B211_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B211_002;
            case RD: state = state.PSH(2); goto B211_002;
            default: return Exit;
        }

        B212_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.LL.SWI; goto B211_015;
            case LD: state = state.RL.SWI; goto B211_015;
            case LL: state = state.SWI; goto B211_015;
            case LT: state = state.RT.POP; goto B213_014;
            case RR: state = state.RL.SWI; goto B211_015;
            case RD: state = state.LL.SWI; goto B211_015;
            case RL: state = state.SWI; goto B211_015;
            case RT: state = state.POP; goto B213_014;
            default: return Exit;
        }

        B213_014: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RT: state = state.LR.PSH(10); goto B215_000;
            default: return Exit;
        }

        B215_000: switch (state.PT) // Size = 17, Colour = yellow
        {
            case LR: state = state.PSH(17); goto B216_000;
            default: return Exit;
        }

        B216_000: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LR: state = state.PSH(23); goto B217_000;
            default: return Exit;
        }

        B217_000: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LR: state = state.PSH(2); goto B218_000;
            default: return Exit;
        }

        B218_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B219_000;
            default: return Exit;
        }

        B219_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ADD; goto B220_000;
            default: return Exit;
        }

        B220_000: switch (state.PT) // Size = 8, Colour = light cyan
        {
            case LR: state = state.PSH(8); goto B221_000;
            default: return Exit;
        }

        B221_000: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B222_000;
            default: return Exit;
        }

        B222_000: switch (state.PT) // Size = 4, Colour = dark cyan
        {
            case LR: state = state.PSH(4); goto B223_000;
            default: return Exit;
        }

        B223_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.MUL; goto B224_000;
            default: return Exit;
        }

        B211_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.LD.PSH(2); goto B211_002;
            case RT: state = state.RD.PSH(2); goto B211_002;
            default: return Exit;
        }

        B224_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B225_000;
            default: return Exit;
        }

        B225_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B226_000;
            default: return Exit;
        }

        B226_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B227_000;
            default: return Exit;
        }

        B227_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B228_000;
            default: return Exit;
        }

        B228_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.DUP; goto B229_000;
            default: return Exit;
        }

        B229_000: switch (state.PT) // Size = 15, Colour = light green
        {
            case LR: state = state.PSH(15); goto B230_000;
            default: return Exit;
        }

        B230_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B231_000;
            default: return Exit;
        }

        B231_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.RD.DUP; goto B232_016;
            default: return Exit;
        }

        B232_016: switch (state.PT) // Size = 2, Colour = light blue
        {
            case RD: state = state.PSH(2); goto B232_018;
            default: return Exit;
        }

        B232_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B232_019;
            default: return Exit;
        }

        B232_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B232_021;
            default: return Exit;
        }

        B232_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B232_022;
            default: return Exit;
        }

        B232_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B234_016;
            case RD: state = state.RT.DUP; goto B234_016;
            case RL: state = state.LT.DUP; goto B234_016;
            case RT: state = state.DUP; goto B234_016;
            default: return Exit;
        }

        B234_016: switch (state.PT) // Size = 3, Colour = red
        {
            case LT: state = state.PSH(3); goto B234_015;
            case RT: state = state.PSH(3); goto B234_015;
            default: return Exit;
        }

        B234_015: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B234_014;
            case RT: state = state.SUB; goto B234_014;
            default: return Exit;
        }

        B234_014: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B234_010;
            case RT: state = state.DUP; goto B234_010;
            default: return Exit;
        }

        B234_010: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LT: state = state.PSH(4); goto B234_009;
            case RT: state = state.PSH(4); goto B234_009;
            default: return Exit;
        }

        B234_009: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B234_008;
            case RT: state = state.ADD; goto B234_008;
            default: return Exit;
        }

        B234_008: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.RR.PSH(9); goto B237_000;
            case RT: state = state.LR.PSH(9); goto B237_000;
            default: return Exit;
        }

        B237_000: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LR: state = state.PSH(23); goto B238_000;
            case RR: state = state.LR.PSH(23); goto B238_000;
            default: return Exit;
        }

        B238_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B239_000;
            default: return Exit;
        }

        B239_000: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LR: state = state.PSH(9); goto B240_000;
            default: return Exit;
        }

        B240_000: switch (state.PT) // Size = 23, Colour = blue
        {
            case LR: state = state.PSH(23); goto B241_000;
            default: return Exit;
        }

        B241_000: switch (state.PT) // Size = 4, Colour = dark blue
        {
            case LR: state = state.PSH(4); goto B242_000;
            default: return Exit;
        }

        B242_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.MUL; goto B243_000;
            default: return Exit;
        }

        B243_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.ADD; goto B244_000;
            default: return Exit;
        }

        B244_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.DUP; goto B245_000;
            default: return Exit;
        }

        B245_000: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LR: state = state.PSH(3); goto B246_000;
            default: return Exit;
        }

        B246_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.SUB; goto B247_000;
            default: return Exit;
        }

        B247_000: switch (state.PT) // Size = 9, Colour = magenta
        {
            case LR: state = state.PSH(9); goto B248_000;
            default: return Exit;
        }

        B248_000: switch (state.PT) // Size = 23, Colour = dark magenta
        {
            case LR: state = state.PSH(23); goto B249_000;
            default: return Exit;
        }

        B249_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ADD; goto B250_000;
            default: return Exit;
        }

        B250_000: switch (state.PT) // Size = 19, Colour = light red
        {
            case LR: state = state.PSH(19); goto B251_000;
            default: return Exit;
        }

        B251_000: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B252_000;
            default: return Exit;
        }

        B252_000: switch (state.PT) // Size = 4, Colour = dark red
        {
            case LR: state = state.PSH(4); goto B253_000;
            default: return Exit;
        }

        B253_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.MUL; goto B254_000;
            default: return Exit;
        }

        B254_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B255_000;
            default: return Exit;
        }

        B255_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.DUP; goto B256_000;
            default: return Exit;
        }

        B256_000: switch (state.PT) // Size = 5, Colour = dark red
        {
            case LR: state = state.PSH(5); goto B257_000;
            default: return Exit;
        }

        B257_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ADD; goto B258_000;
            default: return Exit;
        }

        B258_000: switch (state.PT) // Size = 9, Colour = light yellow
        {
            case LR: state = state.PSH(9); goto B259_000;
            default: return Exit;
        }

        B259_000: switch (state.PT) // Size = 23, Colour = yellow
        {
            case LR: state = state.PSH(23); goto B260_000;
            default: return Exit;
        }

        B260_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B261_000;
            default: return Exit;
        }

        B261_000: switch (state.PT) // Size = 23, Colour = dark green
        {
            case LR: state = state.PSH(23); goto B262_000;
            default: return Exit;
        }

        B262_000: switch (state.PT) // Size = 5, Colour = light green
        {
            case LR: state = state.PSH(5); goto B263_000;
            default: return Exit;
        }

        B263_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.MUL; goto B264_000;
            default: return Exit;
        }

        B264_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.RD.DUP; goto B265_017;
            default: return Exit;
        }

        B265_017: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RD: state = state.PSH(1); goto B265_018;
            default: return Exit;
        }

        B265_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B265_019;
            default: return Exit;
        }

        B265_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B265_021;
            default: return Exit;
        }

        B265_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B265_022;
            default: return Exit;
        }

        B265_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B267_013;
            case RD: state = state.RT.DUP; goto B267_013;
            case RL: state = state.LT.DUP; goto B267_013;
            case RT: state = state.DUP; goto B267_013;
            default: return Exit;
        }

        B267_013: switch (state.PT) // Size = 6, Colour = light red
        {
            case LT: state = state.PSH(6); goto B267_012;
            case RT: state = state.PSH(6); goto B267_012;
            default: return Exit;
        }

        B267_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B267_011;
            case RT: state = state.SUB; goto B267_011;
            default: return Exit;
        }

        B267_011: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B269_009;
            case RT: state = state.RD.DUP; goto B269_009;
            default: return Exit;
        }

        B269_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B269_018;
            case RD: state = state.PSH(9); goto B269_018;
            default: return Exit;
        }

        B269_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B269_019;
            case RD: state = state.SUB; goto B269_019;
            default: return Exit;
        }

        B269_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B269_021;
            case RD: state = state.PSH(2); goto B269_021;
            default: return Exit;
        }

        B269_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B269_022;
            case RD: state = state.ROT; goto B269_022;
            default: return Exit;
        }

        B269_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B271_011;
            case LD: state = state.LT.DUP; goto B271_011;
            case LL: state = state.RT.DUP; goto B271_011;
            case LT: state = state.DUP; goto B271_011;
            case RR: state = state.LT.DUP; goto B271_011;
            case RD: state = state.RT.DUP; goto B271_011;
            case RL: state = state.LT.DUP; goto B271_011;
            case RT: state = state.DUP; goto B271_011;
            default: return Exit;
        }

        B271_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B271_010;
            case RT: state = state.PSH(8); goto B271_010;
            default: return Exit;
        }

        B271_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B271_009;
            case RT: state = state.ADD; goto B271_009;
            default: return Exit;
        }

        B271_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B273_010;
            case RT: state = state.RD.DUP; goto B273_010;
            default: return Exit;
        }

        B273_010: switch (state.PT) // Size = 8, Colour = light blue
        {
            case LD: state = state.PSH(8); goto B273_018;
            case RD: state = state.PSH(8); goto B273_018;
            default: return Exit;
        }

        B273_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B273_019;
            case RD: state = state.SUB; goto B273_019;
            default: return Exit;
        }

        B273_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B273_021;
            case RD: state = state.PSH(2); goto B273_021;
            default: return Exit;
        }

        B273_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B273_022;
            case RD: state = state.ROT; goto B273_022;
            default: return Exit;
        }

        B273_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B275_012;
            case LD: state = state.LT.DUP; goto B275_012;
            case LL: state = state.RT.DUP; goto B275_012;
            case LT: state = state.DUP; goto B275_012;
            case RR: state = state.LT.DUP; goto B275_012;
            case RD: state = state.RT.DUP; goto B275_012;
            case RL: state = state.LT.DUP; goto B275_012;
            case RT: state = state.DUP; goto B275_012;
            default: return Exit;
        }

        B275_012: switch (state.PT) // Size = 7, Colour = red
        {
            case LT: state = state.PSH(7); goto B275_011;
            case RT: state = state.PSH(7); goto B275_011;
            default: return Exit;
        }

        B275_011: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B275_010;
            case RT: state = state.ADD; goto B275_010;
            default: return Exit;
        }

        B275_010: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.RR.DUP; goto B277_000;
            case RT: state = state.LR.DUP; goto B277_000;
            default: return Exit;
        }

        B277_000: switch (state.PT) // Size = 7, Colour = light yellow
        {
            case LR: state = state.PSH(7); goto B278_000;
            case RR: state = state.LR.PSH(7); goto B278_000;
            default: return Exit;
        }

        B278_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.SUB; goto B279_000;
            default: return Exit;
        }

        B279_000: switch (state.PT) // Size = 9, Colour = dark green
        {
            case LR: state = state.PSH(9); goto B280_000;
            default: return Exit;
        }

        B280_000: switch (state.PT) // Size = 23, Colour = light green
        {
            case LR: state = state.PSH(23); goto B281_000;
            default: return Exit;
        }

        B281_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B282_000;
            default: return Exit;
        }

        B282_000: switch (state.PT) // Size = 6, Colour = cyan
        {
            case LR: state = state.PSH(6); goto B283_000;
            default: return Exit;
        }

        B283_000: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LR: state = state.PSH(23); goto B284_000;
            default: return Exit;
        }

        B284_000: switch (state.PT) // Size = 5, Colour = light cyan
        {
            case LR: state = state.PSH(5); goto B285_000;
            default: return Exit;
        }

        B285_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.MUL; goto B286_000;
            default: return Exit;
        }

        B286_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ADD; goto B287_000;
            default: return Exit;
        }

        B287_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.RD.DUP; goto B288_007;
            default: return Exit;
        }

        B288_007: switch (state.PT) // Size = 11, Colour = light blue
        {
            case RD: state = state.PSH(11); goto B288_018;
            default: return Exit;
        }

        B288_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B288_019;
            default: return Exit;
        }

        B288_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B288_021;
            default: return Exit;
        }

        B288_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B288_022;
            default: return Exit;
        }

        B288_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B290_006;
            case RD: state = state.RT.DUP; goto B290_006;
            case RL: state = state.LT.DUP; goto B290_006;
            case RT: state = state.DUP; goto B290_006;
            default: return Exit;
        }

        B290_006: switch (state.PT) // Size = 13, Colour = red
        {
            case LT: state = state.PSH(13); goto B290_005;
            case RT: state = state.PSH(13); goto B290_005;
            default: return Exit;
        }

        B290_005: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B290_004;
            case RT: state = state.SUB; goto B290_004;
            default: return Exit;
        }

        B290_004: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.RR.DUP; goto B292_000;
            case RT: state = state.LR.DUP; goto B292_000;
            default: return Exit;
        }

        B292_000: switch (state.PT) // Size = 12, Colour = light cyan
        {
            case LR: state = state.PSH(12); goto B293_000;
            case RR: state = state.LR.PSH(12); goto B293_000;
            default: return Exit;
        }

        B293_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.ADD; goto B294_000;
            default: return Exit;
        }

        B294_000: switch (state.PT) // Size = 9, Colour = blue
        {
            case LR: state = state.PSH(9); goto B295_000;
            default: return Exit;
        }

        B295_000: switch (state.PT) // Size = 23, Colour = dark blue
        {
            case LR: state = state.PSH(23); goto B296_000;
            default: return Exit;
        }

        B296_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ADD; goto B297_000;
            default: return Exit;
        }

        B297_000: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LR: state = state.PSH(4); goto B298_000;
            default: return Exit;
        }

        B298_000: switch (state.PT) // Size = 23, Colour = magenta
        {
            case LR: state = state.PSH(23); goto B299_000;
            default: return Exit;
        }

        B299_000: switch (state.PT) // Size = 5, Colour = dark magenta
        {
            case LR: state = state.PSH(5); goto B300_000;
            default: return Exit;
        }

        B300_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.MUL; goto B301_000;
            default: return Exit;
        }

        B301_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B302_000;
            default: return Exit;
        }

        B302_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.DUP; goto B303_000;
            default: return Exit;
        }

        B303_000: switch (state.PT) // Size = 8, Colour = dark magenta
        {
            case LR: state = state.PSH(8); goto B304_000;
            default: return Exit;
        }

        B304_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B305_000;
            default: return Exit;
        }

        B305_000: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B306_000;
            default: return Exit;
        }

        B306_000: switch (state.PT) // Size = 23, Colour = dark red
        {
            case LR: state = state.PSH(23); goto B307_000;
            default: return Exit;
        }

        B307_000: switch (state.PT) // Size = 3, Colour = light red
        {
            case LR: state = state.PSH(3); goto B308_000;
            default: return Exit;
        }

        B308_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.MUL; goto B309_000;
            default: return Exit;
        }

        B309_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ADD; goto B310_000;
            default: return Exit;
        }

        B310_000: switch (state.PT) // Size = 9, Colour = light green
        {
            case LR: state = state.PSH(9); goto B311_000;
            default: return Exit;
        }

        B311_000: switch (state.PT) // Size = 23, Colour = green
        {
            case LR: state = state.PSH(23); goto B312_000;
            default: return Exit;
        }

        B312_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ADD; goto B313_000;
            default: return Exit;
        }

        B313_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.RD.PSH(2); goto B316_002;
            default: return Exit;
        }

        B316_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B316_003;
            case LT: state = state.POP; goto B316_000;
            case RD: state = state.PSH(1); goto B316_003;
            case RT: state = state.POP; goto B316_000;
            default: return Exit;
        }

        B316_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B316_004;
            case LT: state = state.POP; goto B316_002;
            case RD: state = state.ROL; goto B316_004;
            case RT: state = state.POP; goto B316_002;
            default: return Exit;
        }

        B316_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B316_005;
            case LT: state = state.NOT; goto B316_003;
            case RD: state = state.OUTc; goto B316_005;
            case RT: state = state.NOT; goto B316_003;
            default: return Exit;
        }

        B316_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B316_006;
            case LT: state = state.SUB; goto B316_004;
            case RD: state = state.PSH(1); goto B316_006;
            case RT: state = state.SUB; goto B316_004;
            default: return Exit;
        }

        B316_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B316_007;
            case LT: state = state.POP; goto B316_005;
            case RD: state = state.SUB; goto B316_007;
            case RT: state = state.POP; goto B316_005;
            default: return Exit;
        }

        B316_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B316_008;
            case LT: state = state.OUTc; goto B316_006;
            case RD: state = state.DUP; goto B316_008;
            case RT: state = state.OUTc; goto B316_006;
            default: return Exit;
        }

        B316_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B316_009;
            case LT: state = state.DIV; goto B316_007;
            case RD: state = state.NOT; goto B316_009;
            case RT: state = state.DIV; goto B316_007;
            default: return Exit;
        }

        B316_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B316_012;
            case LT: state = state.ROL; goto B316_008;
            case RD: state = state.PSH(3); goto B316_012;
            case RT: state = state.ROL; goto B316_008;
            default: return Exit;
        }

        B316_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B316_013;
            case LT: state = state.POP; goto B316_009;
            case RD: state = state.MUL; goto B316_013;
            case RT: state = state.POP; goto B316_009;
            default: return Exit;
        }

        B316_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B316_014;
            case LT: state = state.OUTi; goto B316_012;
            case RD: state = state.DUP; goto B316_014;
            case RT: state = state.OUTi; goto B316_012;
            default: return Exit;
        }

        B316_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B316_015;
            case LT: state = state.DIV; goto B316_013;
            case RD: state = state.ROT; goto B316_015;
            case RT: state = state.DIV; goto B316_013;
            default: return Exit;
        }

        B316_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B317_015;
            case LD: state = state.POP; goto B316_016;
            case LL: state = state.RT.SWI; goto B316_014;
            case LT: state = state.SWI; goto B316_014;
            case RR: state = state.ROT; goto B317_015;
            case RD: state = state.POP; goto B316_016;
            case RL: state = state.LT.SWI; goto B316_014;
            case RT: state = state.SWI; goto B316_014;
            default: return Exit;
        }

        B316_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B316_002;
            case RD: state = state.PSH(2); goto B316_002;
            default: return Exit;
        }

        B317_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.LL.SWI; goto B316_015;
            case LD: state = state.RL.SWI; goto B316_015;
            case LL: state = state.SWI; goto B316_015;
            case LT: state = state.RT.POP; goto B318_014;
            case RR: state = state.RL.SWI; goto B316_015;
            case RD: state = state.LL.SWI; goto B316_015;
            case RL: state = state.SWI; goto B316_015;
            case RT: state = state.POP; goto B318_014;
            default: return Exit;
        }

        B318_014: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RT: state = state.LR.INi; goto B320_000;
            default: return Exit;
        }

        B320_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B321_000;
            default: return Exit;
        }

        B321_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.NOT; goto B322_000;
            default: return Exit;
        }

        B322_000: switch (state.PT) // Size = 10, Colour = cyan
        {
            case LR: state = state.PSH(10); goto B323_000;
            default: return Exit;
        }

        B323_000: switch (state.PT) // Size = 12, Colour = dark cyan
        {
            case LR: state = state.PSH(12); goto B324_000;
            default: return Exit;
        }

        B324_000: switch (state.PT) // Size = 23, Colour = light cyan
        {
            case LR: state = state.PSH(23); goto B325_000;
            default: return Exit;
        }

        B325_000: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LR: state = state.PSH(2); goto B326_000;
            default: return Exit;
        }

        B326_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.MUL; goto B327_000;
            default: return Exit;
        }

        B327_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.ADD; goto B328_000;
            default: return Exit;
        }

        B328_000: switch (state.PT) // Size = 23, Colour = magenta
        {
            case LR: state = state.PSH(23); goto B329_000;
            default: return Exit;
        }

        B316_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.LD.PSH(2); goto B316_002;
            case RT: state = state.RD.PSH(2); goto B316_002;
            default: return Exit;
        }

        B329_000: switch (state.PT) // Size = 5, Colour = dark magenta
        {
            case LR: state = state.PSH(5); goto B330_000;
            default: return Exit;
        }

        B330_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.MUL; goto B331_000;
            default: return Exit;
        }

        B331_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.RD.DUP; goto B332_017;
            default: return Exit;
        }

        B332_017: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RD: state = state.PSH(1); goto B332_018;
            default: return Exit;
        }

        B332_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B332_019;
            default: return Exit;
        }

        B332_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B332_021;
            default: return Exit;
        }

        B332_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B332_022;
            default: return Exit;
        }

        B332_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B334_013;
            case RD: state = state.RT.DUP; goto B334_013;
            case RL: state = state.LT.DUP; goto B334_013;
            case RT: state = state.DUP; goto B334_013;
            default: return Exit;
        }

        B334_013: switch (state.PT) // Size = 6, Colour = light red
        {
            case LT: state = state.PSH(6); goto B334_012;
            case RT: state = state.PSH(6); goto B334_012;
            default: return Exit;
        }

        B334_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B334_011;
            case RT: state = state.SUB; goto B334_011;
            default: return Exit;
        }

        B334_011: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B336_009;
            case RT: state = state.RD.DUP; goto B336_009;
            default: return Exit;
        }

        B336_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B336_018;
            case RD: state = state.PSH(9); goto B336_018;
            default: return Exit;
        }

        B336_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B336_019;
            case RD: state = state.SUB; goto B336_019;
            default: return Exit;
        }

        B336_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B336_021;
            case RD: state = state.PSH(2); goto B336_021;
            default: return Exit;
        }

        B336_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B336_022;
            case RD: state = state.ROT; goto B336_022;
            default: return Exit;
        }

        B336_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B338_011;
            case LD: state = state.LT.DUP; goto B338_011;
            case LL: state = state.RT.DUP; goto B338_011;
            case LT: state = state.DUP; goto B338_011;
            case RR: state = state.LT.DUP; goto B338_011;
            case RD: state = state.RT.DUP; goto B338_011;
            case RL: state = state.LT.DUP; goto B338_011;
            case RT: state = state.DUP; goto B338_011;
            default: return Exit;
        }

        B338_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B338_010;
            case RT: state = state.PSH(8); goto B338_010;
            default: return Exit;
        }

        B338_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B338_009;
            case RT: state = state.ADD; goto B338_009;
            default: return Exit;
        }

        B338_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B340_010;
            case RT: state = state.RD.DUP; goto B340_010;
            default: return Exit;
        }

        B340_010: switch (state.PT) // Size = 8, Colour = light blue
        {
            case LD: state = state.PSH(8); goto B340_018;
            case RD: state = state.PSH(8); goto B340_018;
            default: return Exit;
        }

        B340_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B340_019;
            case RD: state = state.SUB; goto B340_019;
            default: return Exit;
        }

        B340_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B340_021;
            case RD: state = state.PSH(2); goto B340_021;
            default: return Exit;
        }

        B340_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B340_022;
            case RD: state = state.ROT; goto B340_022;
            default: return Exit;
        }

        B340_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B342_012;
            case LD: state = state.LT.DUP; goto B342_012;
            case LL: state = state.RT.DUP; goto B342_012;
            case LT: state = state.DUP; goto B342_012;
            case RR: state = state.LT.DUP; goto B342_012;
            case RD: state = state.RT.DUP; goto B342_012;
            case RL: state = state.LT.DUP; goto B342_012;
            case RT: state = state.DUP; goto B342_012;
            default: return Exit;
        }

        B342_012: switch (state.PT) // Size = 7, Colour = red
        {
            case LT: state = state.PSH(7); goto B342_011;
            case RT: state = state.PSH(7); goto B342_011;
            default: return Exit;
        }

        B342_011: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B342_010;
            case RT: state = state.ADD; goto B342_010;
            default: return Exit;
        }

        B342_010: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.RR.DUP; goto B344_000;
            case RT: state = state.LR.DUP; goto B344_000;
            default: return Exit;
        }

        B344_000: switch (state.PT) // Size = 7, Colour = dark blue
        {
            case LR: state = state.PSH(7); goto B345_000;
            case RR: state = state.LR.PSH(7); goto B345_000;
            default: return Exit;
        }

        B345_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.SUB; goto B346_000;
            default: return Exit;
        }

        B346_000: switch (state.PT) // Size = 10, Colour = magenta
        {
            case LR: state = state.PSH(10); goto B347_000;
            default: return Exit;
        }

        B347_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.RD.PSH(2); goto B350_002;
            default: return Exit;
        }

        B350_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B350_003;
            case LT: state = state.POP; goto B350_000;
            case RD: state = state.PSH(1); goto B350_003;
            case RT: state = state.POP; goto B350_000;
            default: return Exit;
        }

        B350_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B350_004;
            case LT: state = state.POP; goto B350_002;
            case RD: state = state.ROL; goto B350_004;
            case RT: state = state.POP; goto B350_002;
            default: return Exit;
        }

        B350_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B350_005;
            case LT: state = state.NOT; goto B350_003;
            case RD: state = state.OUTc; goto B350_005;
            case RT: state = state.NOT; goto B350_003;
            default: return Exit;
        }

        B350_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B350_006;
            case LT: state = state.SUB; goto B350_004;
            case RD: state = state.PSH(1); goto B350_006;
            case RT: state = state.SUB; goto B350_004;
            default: return Exit;
        }

        B350_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B350_007;
            case LT: state = state.POP; goto B350_005;
            case RD: state = state.SUB; goto B350_007;
            case RT: state = state.POP; goto B350_005;
            default: return Exit;
        }

        B350_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B350_008;
            case LT: state = state.OUTc; goto B350_006;
            case RD: state = state.DUP; goto B350_008;
            case RT: state = state.OUTc; goto B350_006;
            default: return Exit;
        }

        B350_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B350_009;
            case LT: state = state.DIV; goto B350_007;
            case RD: state = state.NOT; goto B350_009;
            case RT: state = state.DIV; goto B350_007;
            default: return Exit;
        }

        B350_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B350_012;
            case LT: state = state.ROL; goto B350_008;
            case RD: state = state.PSH(3); goto B350_012;
            case RT: state = state.ROL; goto B350_008;
            default: return Exit;
        }

        B350_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B350_013;
            case LT: state = state.POP; goto B350_009;
            case RD: state = state.MUL; goto B350_013;
            case RT: state = state.POP; goto B350_009;
            default: return Exit;
        }

        B350_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B350_014;
            case LT: state = state.OUTi; goto B350_012;
            case RD: state = state.DUP; goto B350_014;
            case RT: state = state.OUTi; goto B350_012;
            default: return Exit;
        }

        B350_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B350_015;
            case LT: state = state.DIV; goto B350_013;
            case RD: state = state.ROT; goto B350_015;
            case RT: state = state.DIV; goto B350_013;
            default: return Exit;
        }

        B350_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B351_015;
            case LD: state = state.POP; goto B350_016;
            case LL: state = state.RT.SWI; goto B350_014;
            case LT: state = state.SWI; goto B350_014;
            case RR: state = state.ROT; goto B351_015;
            case RD: state = state.POP; goto B350_016;
            case RL: state = state.LT.SWI; goto B350_014;
            case RT: state = state.SWI; goto B350_014;
            default: return Exit;
        }

        B350_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B350_002;
            case RD: state = state.PSH(2); goto B350_002;
            default: return Exit;
        }

        B351_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.LL.SWI; goto B350_015;
            case LD: state = state.RL.SWI; goto B350_015;
            case LL: state = state.SWI; goto B350_015;
            case LT: state = state.RT.POP; goto B352_014;
            case RR: state = state.RL.SWI; goto B350_015;
            case RD: state = state.LL.SWI; goto B350_015;
            case RL: state = state.SWI; goto B350_015;
            case RT: state = state.POP; goto B352_014;
            default: return Exit;
        }

        B352_014: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RT: state = state.LR.INi; goto B356_000;
            default: return Exit;
        }

        B356_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B357_000;
            case RR: state = state.LR.PSH(3); goto B357_000;
            case RL: state = state.MOD; goto B355_000;
            default: return Exit;
        }

        B357_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B358_000;
            case RL: state = state.POP; goto B356_000;
            default: return Exit;
        }

        B358_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROL; goto B359_000;
            case RL: state = state.POP; goto B357_000;
            default: return Exit;
        }

        B359_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B360_000;
            case RL: state = state.NOT; goto B358_000;
            default: return Exit;
        }

        B360_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B361_000;
            case RL: state = state.POP; goto B359_000;
            default: return Exit;
        }

        B361_000: switch (state.PT) // Size = 2, Colour = dark green
        {
            case LR: state = state.PSH(2); goto B362_000;
            case RL: state = state.INc; goto B360_000;
            default: return Exit;
        }

        B362_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B363_000;
            case RL: state = state.POP; goto B361_000;
            default: return Exit;
        }

        B363_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ROL; goto B364_000;
            case RL: state = state.POP; goto B362_000;
            default: return Exit;
        }

        B364_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.DUP; goto B365_000;
            case RL: state = state.NOT; goto B363_000;
            default: return Exit;
        }

        B350_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.LD.PSH(2); goto B350_002;
            case RT: state = state.RD.PSH(2); goto B350_002;
            default: return Exit;
        }

        B365_000: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LR: state = state.PSH(3); goto B366_000;
            case RL: state = state.DIV; goto B364_000;
            default: return Exit;
        }

        B366_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B367_000;
            case RL: state = state.POP; goto B365_000;
            default: return Exit;
        }

        B367_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B368_000;
            case RL: state = state.POP; goto B366_000;
            default: return Exit;
        }

        B368_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.SUB; goto B369_000;
            case RL: state = state.POP; goto B367_000;
            default: return Exit;
        }

        B369_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B370_000;
            case RL: state = state.OUTc; goto B368_000;
            default: return Exit;
        }

        B370_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B371_000;
            case RL: state = state.NOT; goto B369_000;
            default: return Exit;
        }

        B371_000: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LR: state = state.PSH(3); goto B372_000;
            case LL: state = state.RL.DIV; goto B370_000;
            case RL: state = state.DIV; goto B370_000;
            default: return Exit;
        }

        B372_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.PSH(1); goto B373_000;
            case LL: state = state.POP; goto B371_000;
            case RL: state = state.POP; goto B371_000;
            default: return Exit;
        }

        B373_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B374_000;
            case LL: state = state.POP; goto B372_000;
            case RL: state = state.POP; goto B372_000;
            default: return Exit;
        }

        B374_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.GT_; goto B375_000;
            case LL: state = state.NOT; goto B373_000;
            case RL: state = state.NOT; goto B373_000;
            default: return Exit;
        }

        B375_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.NOT; goto B376_000;
            case LL: state = state.GT_; goto B374_000;
            case RL: state = state.GT_; goto B374_000;
            default: return Exit;
        }

        B376_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B377_000;
            case LL: state = state.ROL; goto B375_000;
            case RL: state = state.ROL; goto B375_000;
            default: return Exit;
        }

        B377_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B378_000;
            case LL: state = state.ROL; goto B376_000;
            case RL: state = state.ROL; goto B376_000;
            default: return Exit;
        }

        B378_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B381_000;
            case LD: state = state.RR.INi; goto B356_000;
            case LL: state = state.SWI; goto B377_000;
            case LT: state = state.RR.POP; goto B381_000;
            default: return Exit;
        }

        B381_000: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.PSH(2); goto B382_000;
            case RR: state = state.LR.PSH(2); goto B382_000;
            case RL: state = state.PSH(2); goto B380_000;
            default: return Exit;
        }

        B382_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B383_000;
            case RL: state = state.POP; goto B381_000;
            default: return Exit;
        }

        B383_000: switch (state.PT) // Size = 2, Colour = light blue
        {
            case LR: state = state.PSH(2); goto B384_000;
            case RL: state = state.INc; goto B382_000;
            default: return Exit;
        }

        B384_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(1); goto B385_000;
            case RL: state = state.POP; goto B383_000;
            default: return Exit;
        }

        B385_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B386_000;
            case RL: state = state.POP; goto B384_000;
            default: return Exit;
        }

        B386_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B387_000;
            case RL: state = state.NOT; goto B385_000;
            default: return Exit;
        }

        B387_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.NOT; goto B388_000;
            case RL: state = state.POP; goto B386_000;
            default: return Exit;
        }

        B388_000: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.PSH(3); goto B389_000;
            case RL: state = state.ROL; goto B387_000;
            default: return Exit;
        }

        B389_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(1); goto B390_000;
            case RL: state = state.POP; goto B388_000;
            default: return Exit;
        }

        B390_000: switch (state.PT) // Size = 2, Colour = dark blue
        {
            case LR: state = state.PSH(2); goto B391_000;
            case RL: state = state.POP; goto B389_000;
            default: return Exit;
        }

        B391_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.SUB; goto B392_000;
            case RL: state = state.POP; goto B390_000;
            default: return Exit;
        }

        B392_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROL; goto B393_000;
            case RL: state = state.OUTc; goto B391_000;
            default: return Exit;
        }

        B393_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B394_000;
            case RL: state = state.NOT; goto B392_000;
            default: return Exit;
        }

        B394_000: switch (state.PT) // Size = 5, Colour = dark yellow
        {
            case LR: state = state.PSH(5); goto B395_000;
            case RL: state = state.DIV; goto B393_000;
            default: return Exit;
        }

        B395_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B396_000;
            case RL: state = state.POP; goto B394_000;
            default: return Exit;
        }

        B396_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B397_000;
            case RL: state = state.POP; goto B395_000;
            default: return Exit;
        }

        B397_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B398_000;
            case RL: state = state.NOT; goto B396_000;
            default: return Exit;
        }

        B398_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B399_000;
            case RL: state = state.POP; goto B397_000;
            default: return Exit;
        }

        B399_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B402_000;
            default: return Exit;
        }

        B402_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B403_000;
            case RL: state = state.POP; goto B401_000;
            default: return Exit;
        }

        B403_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B404_000;
            case RL: state = state.POP; goto B402_000;
            default: return Exit;
        }

        B404_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.SUB; goto B405_000;
            case RL: state = state.POP; goto B403_000;
            default: return Exit;
        }

        B405_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B406_000;
            case RL: state = state.OUTc; goto B404_000;
            default: return Exit;
        }

        B355_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RL: state = state.RR.INi; goto B356_000;
            default: return Exit;
        }

        B406_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B407_000;
            case RL: state = state.NOT; goto B405_000;
            default: return Exit;
        }

        B407_000: switch (state.PT) // Size = 3, Colour = light red
        {
            case LR: state = state.PSH(3); goto B408_000;
            case RL: state = state.DIV; goto B406_000;
            default: return Exit;
        }

        B408_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B409_000;
            case RL: state = state.POP; goto B407_000;
            default: return Exit;
        }

        B409_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROL; goto B410_000;
            case RL: state = state.POP; goto B408_000;
            default: return Exit;
        }

        B410_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B411_000;
            case RL: state = state.NOT; goto B409_000;
            default: return Exit;
        }

        B411_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B412_000;
            case RL: state = state.POP; goto B410_000;
            default: return Exit;
        }

        B412_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.SUB; goto B413_000;
            case RL: state = state.POP; goto B411_000;
            default: return Exit;
        }

        B413_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B414_000;
            case RL: state = state.OUTc; goto B412_000;
            default: return Exit;
        }

        B414_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B415_000;
            case RL: state = state.NOT; goto B413_000;
            default: return Exit;
        }

        B415_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B416_000;
            case RL: state = state.POP; goto B414_000;
            default: return Exit;
        }

        B416_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B417_000;
            case RL: state = state.POP; goto B415_000;
            default: return Exit;
        }

        B417_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.SUB; goto B418_000;
            case RL: state = state.POP; goto B416_000;
            default: return Exit;
        }

        B418_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B419_000;
            case RL: state = state.OUTc; goto B417_000;
            default: return Exit;
        }

        B419_000: switch (state.PT) // Size = 2, Colour = light green
        {
            case LR: state = state.PSH(2); goto B420_000;
            case RL: state = state.NOT; goto B418_000;
            default: return Exit;
        }

        B420_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.SUB; goto B421_000;
            case RL: state = state.POP; goto B419_000;
            default: return Exit;
        }

        B421_000: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.PSH(2); goto B422_000;
            case RL: state = state.OUTc; goto B420_000;
            default: return Exit;
        }

        B422_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B423_000;
            case RL: state = state.POP; goto B421_000;
            default: return Exit;
        }

        B423_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.ROL; goto B424_000;
            case RL: state = state.POP; goto B422_000;
            default: return Exit;
        }

        B424_000: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(2); goto B425_000;
            case RL: state = state.NOT; goto B423_000;
            default: return Exit;
        }

        B425_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B426_000;
            case RL: state = state.POP; goto B424_000;
            default: return Exit;
        }

        B426_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B427_000;
            case RL: state = state.POP; goto B425_000;
            default: return Exit;
        }

        B427_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B428_000;
            case RL: state = state.NOT; goto B426_000;
            default: return Exit;
        }

        B428_000: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.PSH(3); goto B429_000;
            case RL: state = state.DIV; goto B427_000;
            default: return Exit;
        }

        B429_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B430_000;
            case RL: state = state.POP; goto B428_000;
            default: return Exit;
        }

        B430_000: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LR: state = state.PSH(2); goto B431_000;
            case RL: state = state.POP; goto B429_000;
            default: return Exit;
        }

        B431_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B432_000;
            case RL: state = state.POP; goto B430_000;
            default: return Exit;
        }

        B432_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B433_000;
            case RL: state = state.OUTc; goto B431_000;
            default: return Exit;
        }

        B433_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DUP; goto B434_000;
            case RL: state = state.NOT; goto B432_000;
            default: return Exit;
        }

        B434_000: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B435_000;
            case LL: state = state.RL.DIV; goto B433_000;
            case RL: state = state.DIV; goto B433_000;
            default: return Exit;
        }

        B435_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B436_000;
            case LL: state = state.POP; goto B434_000;
            case RL: state = state.POP; goto B434_000;
            default: return Exit;
        }

        B436_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ROL; goto B437_000;
            case LL: state = state.POP; goto B435_000;
            case RL: state = state.POP; goto B435_000;
            default: return Exit;
        }

        B437_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.GT_; goto B438_000;
            case LL: state = state.NOT; goto B436_000;
            case RL: state = state.NOT; goto B436_000;
            default: return Exit;
        }

        B438_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B439_000;
            case LL: state = state.GT_; goto B437_000;
            case RL: state = state.GT_; goto B437_000;
            default: return Exit;
        }

        B439_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B440_000;
            case LL: state = state.ROL; goto B438_000;
            case RL: state = state.ROL; goto B438_000;
            default: return Exit;
        }

        B440_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(2); goto B443_000;
            case LD: state = state.PSH(3); goto B059_046;
            case LL: state = state.SWI; goto B439_000;
            case LT: state = state.LR.PSH(2); goto B443_000;
            default: return Exit;
        }

        B443_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B444_000;
            case RL: state = state.POP; goto B442_000;
            default: return Exit;
        }

        B059_046: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B058_047;
            default: return Exit;
        }

        B444_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ROL; goto B445_000;
            case RL: state = state.POP; goto B443_000;
            default: return Exit;
        }

        B058_047: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B059_048;
            default: return Exit;
        }

        B445_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B446_000;
            case RL: state = state.NOT; goto B444_000;
            default: return Exit;
        }

        B059_048: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B059_049;
            default: return Exit;
        }

        B446_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B447_000;
            case RL: state = state.POP; goto B445_000;
            default: return Exit;
        }

        B059_049: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROL; goto B058_050;
            default: return Exit;
        }

        B447_000: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LR: state = state.PSH(3); goto B448_000;
            case LL: state = state.RL.INc; goto B446_000;
            case RL: state = state.INc; goto B446_000;
            default: return Exit;
        }

        B058_050: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B059_051;
            default: return Exit;
        }

        B448_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.PSH(1); goto B449_000;
            case LL: state = state.POP; goto B447_000;
            case RL: state = state.POP; goto B447_000;
            default: return Exit;
        }

        B059_051: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.PSH(1); goto B059_052;
            default: return Exit;
        }

        B449_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROL; goto B450_000;
            case LL: state = state.POP; goto B448_000;
            case RL: state = state.POP; goto B448_000;
            default: return Exit;
        }

        B059_052: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ROL; goto B059_053;
            default: return Exit;
        }

        B450_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B451_000;
            case LL: state = state.NOT; goto B449_000;
            case RL: state = state.NOT; goto B449_000;
            default: return Exit;
        }

        B059_053: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B059_054;
            default: return Exit;
        }

        B451_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.NOT; goto B452_000;
            case LL: state = state.DIV; goto B450_000;
            case RL: state = state.DIV; goto B450_000;
            default: return Exit;
        }

        B059_054: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ADD; goto B059_055;
            default: return Exit;
        }

        B452_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.ROT; goto B453_000;
            case LL: state = state.ROL; goto B451_000;
            case RL: state = state.ROL; goto B451_000;
            default: return Exit;
        }

        B059_055: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B059_056;
            default: return Exit;
        }

        B453_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(3); goto B456_000;
            case LD: state = state.RR.PSH(1); goto B497_000;
            case LL: state = state.SWI; goto B452_000;
            case LT: state = state.LR.PSH(3); goto B456_000;
            default: return Exit;
        }

        B059_056: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B059_057;
            default: return Exit;
        }

        B456_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.PSH(1); goto B457_000;
            case RL: state = state.POP; goto B455_000;
            default: return Exit;
        }

        B497_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case RR: state = state.ADD; goto B498_000;
            case RL: state = state.POP; goto B496_000;
            default: return Exit;
        }

        B059_057: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.PSH(1); goto B059_058;
            default: return Exit;
        }

        B457_000: switch (state.PT) // Size = 2, Colour = red
        {
            case LR: state = state.PSH(2); goto B458_000;
            case RL: state = state.POP; goto B456_000;
            default: return Exit;
        }

        B498_000: switch (state.PT) // Size = 3, Colour = red
        {
            case RR: state = state.LR.PSH(3); goto B499_000;
            case RL: state = state.INc; goto B497_000;
            default: return Exit;
        }

        B059_058: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.NOT; goto B050_059;
            default: return Exit;
        }

        B458_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B459_000;
            case RL: state = state.POP; goto B457_000;
            default: return Exit;
        }

        B499_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B500_000;
            case RL: state = state.POP; goto B498_000;
            default: return Exit;
        }

        B050_059: switch (state.PT) // Size = 10, Colour = dark blue
        {
            case LD: state = state.PSH(10); goto B048_060;
            default: return Exit;
        }

        B459_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B460_000;
            case RL: state = state.OUTc; goto B458_000;
            default: return Exit;
        }

        B500_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.PSH(2); goto B501_000;
            case RL: state = state.POP; goto B499_000;
            default: return Exit;
        }

        B048_060: switch (state.PT) // Size = 12, Colour = light blue
        {
            case LD: state = state.PSH(12); goto B037_061;
            default: return Exit;
        }

        B460_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.DUP; goto B461_000;
            case RL: state = state.NOT; goto B459_000;
            default: return Exit;
        }

        B501_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B502_000;
            case RL: state = state.POP; goto B500_000;
            default: return Exit;
        }

        B037_061: switch (state.PT) // Size = 23, Colour = blue
        {
            case LD: state = state.PSH(23); goto B058_062;
            default: return Exit;
        }

        B461_000: switch (state.PT) // Size = 5, Colour = cyan
        {
            case LR: state = state.PSH(5); goto B462_000;
            case RL: state = state.DIV; goto B460_000;
            default: return Exit;
        }

        B502_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROL; goto B503_000;
            case RL: state = state.OUTc; goto B501_000;
            default: return Exit;
        }

        B058_062: switch (state.PT) // Size = 2, Colour = dark blue
        {
            case LD: state = state.PSH(2); goto B059_063;
            default: return Exit;
        }

        B462_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B463_000;
            case RL: state = state.POP; goto B461_000;
            default: return Exit;
        }

        B503_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.DUP; goto B504_000;
            case RL: state = state.NOT; goto B502_000;
            default: return Exit;
        }

        B059_063: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.MUL; goto B059_064;
            default: return Exit;
        }

        B463_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROL; goto B464_000;
            case RL: state = state.POP; goto B462_000;
            default: return Exit;
        }

        B504_000: switch (state.PT) // Size = 5, Colour = light cyan
        {
            case LR: state = state.PSH(5); goto B505_000;
            case LL: state = state.RL.DIV; goto B503_000;
            case RL: state = state.DIV; goto B503_000;
            default: return Exit;
        }

        B059_064: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ADD; goto B059_065;
            default: return Exit;
        }

        B464_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B465_000;
            case RL: state = state.NOT; goto B463_000;
            default: return Exit;
        }

        B505_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B506_000;
            case LL: state = state.POP; goto B504_000;
            case RL: state = state.POP; goto B504_000;
            default: return Exit;
        }

        B059_065: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.PSH(1); goto B037_066;
            default: return Exit;
        }

        B465_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROL; goto B466_000;
            case RL: state = state.POP; goto B464_000;
            default: return Exit;
        }

        B506_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROL; goto B507_000;
            case LL: state = state.POP; goto B505_000;
            case RL: state = state.POP; goto B505_000;
            default: return Exit;
        }

        B037_066: switch (state.PT) // Size = 23, Colour = light red
        {
            case LD: state = state.PSH(23); goto B055_067;
            default: return Exit;
        }

        B466_000: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LR: state = state.PSH(2); goto B467_000;
            case RL: state = state.NOT; goto B465_000;
            default: return Exit;
        }

        B507_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B508_000;
            case LL: state = state.NOT; goto B506_000;
            case RL: state = state.NOT; goto B506_000;
            default: return Exit;
        }

        B442_000: switch (state.PT) // Size = 2, Colour = red
        {
            case RL: state = state.SWI; goto B439_000;
            default: return Exit;
        }

        B055_067: switch (state.PT) // Size = 5, Colour = red
        {
            case LD: state = state.PSH(5); goto B059_068;
            default: return Exit;
        }

        B467_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(1); goto B468_000;
            case RL: state = state.POP; goto B466_000;
            default: return Exit;
        }

        B508_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B509_000;
            case LL: state = state.POP; goto B507_000;
            case RL: state = state.POP; goto B507_000;
            default: return Exit;
        }

        B059_068: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.MUL; goto B059_069;
            default: return Exit;
        }

        B468_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.ROL; goto B469_000;
            case RL: state = state.POP; goto B467_000;
            default: return Exit;
        }

        B509_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B510_000;
            case LL: state = state.NOT; goto B508_000;
            case RL: state = state.NOT; goto B508_000;
            default: return Exit;
        }

        B059_069: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ADD; goto B059_070;
            default: return Exit;
        }

        B469_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B470_000;
            case RL: state = state.NOT; goto B468_000;
            default: return Exit;
        }

        B510_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROT; goto B511_000;
            case LL: state = state.POP; goto B509_000;
            case RL: state = state.POP; goto B509_000;
            default: return Exit;
        }

        B059_070: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.RL.DUP; goto B042_071;
            default: return Exit;
        }

        B470_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B471_000;
            case RL: state = state.POP; goto B469_000;
            default: return Exit;
        }

        B511_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state.LR.PSH(3); goto B402_000;
            case LL: state = state.SWI; goto B510_000;
            case LT: state = state.LR.PSH(3); goto B402_000;
            default: return Exit;
        }

        B042_071: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RL: state = state.PSH(1); goto B041_071;
            default: return Exit;
        }

        B471_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROL; goto B472_000;
            case RL: state = state.POP; goto B470_000;
            default: return Exit;
        }

        B041_071: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B039_071;
            default: return Exit;
        }

        B472_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B473_000;
            case RL: state = state.NOT; goto B471_000;
            default: return Exit;
        }

        B039_071: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B038_071;
            default: return Exit;
        }

        B473_000: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state.PSH(3); goto B474_000;
            case RL: state = state.DIV; goto B472_000;
            default: return Exit;
        }

        B038_071: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B037_071;
            default: return Exit;
        }

        B474_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(1); goto B475_000;
            case RL: state = state.POP; goto B473_000;
            default: return Exit;
        }

        B037_071: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B041_073;
            case RD: state = state.LR.DUP; goto B041_073;
            case RL: state = state.RR.DUP; goto B041_073;
            case RT: state = state.LR.DUP; goto B041_073;
            default: return Exit;
        }

        B475_000: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LR: state = state.PSH(2); goto B476_000;
            case RL: state = state.POP; goto B474_000;
            default: return Exit;
        }

        B041_073: switch (state.PT) // Size = 10, Colour = red
        {
            case LR: state = state.PSH(10); goto B051_073;
            case RR: state = state.PSH(10); goto B051_073;
            default: return Exit;
        }

        B476_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B477_000;
            case RL: state = state.POP; goto B475_000;
            default: return Exit;
        }

        B051_073: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B052_073;
            case RR: state = state.SUB; goto B052_073;
            default: return Exit;
        }

        B477_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROL; goto B478_000;
            case RL: state = state.OUTc; goto B476_000;
            default: return Exit;
        }

        B052_073: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.RD.DUP; goto B057_075;
            case RR: state = state.LD.DUP; goto B057_075;
            default: return Exit;
        }

        B478_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.DUP; goto B479_000;
            case RL: state = state.NOT; goto B477_000;
            default: return Exit;
        }

        B057_075: switch (state.PT) // Size = 3, Colour = red
        {
            case LD: state = state.PSH(3); goto B059_076;
            case RD: state = state.LD.PSH(3); goto B059_076;
            default: return Exit;
        }

        B479_000: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LR: state = state.PSH(3); goto B480_000;
            case LL: state = state.RL.DIV; goto B478_000;
            case RL: state = state.DIV; goto B478_000;
            default: return Exit;
        }

        B059_076: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ADD; goto B051_077;
            default: return Exit;
        }

        B480_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B481_000;
            case LL: state = state.POP; goto B479_000;
            case RL: state = state.POP; goto B479_000;
            default: return Exit;
        }

        B051_077: switch (state.PT) // Size = 9, Colour = dark yellow
        {
            case LD: state = state.PSH(9); goto B037_078;
            default: return Exit;
        }

        B481_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ROL; goto B482_000;
            case LL: state = state.POP; goto B480_000;
            case RL: state = state.POP; goto B480_000;
            default: return Exit;
        }

        B037_078: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LD: state = state.PSH(23); goto B059_079;
            default: return Exit;
        }

        B482_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.GT_; goto B483_000;
            case LL: state = state.NOT; goto B481_000;
            case RL: state = state.NOT; goto B481_000;
            default: return Exit;
        }

        B059_079: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ADD; goto B052_080;
            default: return Exit;
        }

        B483_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B484_000;
            case LL: state = state.GT_; goto B482_000;
            case RL: state = state.GT_; goto B482_000;
            default: return Exit;
        }

        B052_080: switch (state.PT) // Size = 8, Colour = green
        {
            case LD: state = state.PSH(8); goto B037_081;
            default: return Exit;
        }

        B401_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case RL: state = state.NOT; goto B398_000;
            default: return Exit;
        }

        B484_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.NOT; goto B485_000;
            case LL: state = state.ROL; goto B483_000;
            case RL: state = state.ROL; goto B483_000;
            default: return Exit;
        }

        B037_081: switch (state.PT) // Size = 23, Colour = dark green
        {
            case LD: state = state.PSH(23); goto B056_082;
            default: return Exit;
        }

        B485_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROT; goto B486_000;
            case LL: state = state.ROL; goto B484_000;
            case RL: state = state.ROL; goto B484_000;
            default: return Exit;
        }

        B496_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.RR.PSH(1); goto B497_000;
            default: return Exit;
        }

        B056_082: switch (state.PT) // Size = 4, Colour = light green
        {
            case LD: state = state.PSH(4); goto B059_083;
            default: return Exit;
        }

        B486_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(2); goto B489_000;
            case LD: state = state.PSH(3); goto B015_046;
            case LL: state = state.SWI; goto B485_000;
            case LT: state = state.LR.PSH(2); goto B489_000;
            default: return Exit;
        }

        B059_083: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.MUL; goto B059_084;
            default: return Exit;
        }

        B489_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(1); goto B490_000;
            case LL: state = state.POP; goto B488_000;
            case RL: state = state.POP; goto B488_000;
            default: return Exit;
        }

        B015_046: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B014_047;
            case RT: state = state.POP; goto B013_045;
            default: return Exit;
        }

        B059_084: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ADD; goto B059_085;
            default: return Exit;
        }

        B490_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B491_000;
            case LL: state = state.POP; goto B489_000;
            case RL: state = state.POP; goto B489_000;
            default: return Exit;
        }

        B014_047: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B015_048;
            case RT: state = state.POP; goto B015_046;
            default: return Exit;
        }

        B059_085: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.DUP; goto B059_086;
            default: return Exit;
        }

        B491_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B492_000;
            case LL: state = state.NOT; goto B490_000;
            case RL: state = state.NOT; goto B490_000;
            default: return Exit;
        }

        B015_048: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B015_049;
            case RT: state = state.POP; goto B014_047;
            default: return Exit;
        }

        B059_086: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.PSH(1); goto B059_087;
            default: return Exit;
        }

        B492_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ROT; goto B493_000;
            case LL: state = state.POP; goto B491_000;
            case RL: state = state.POP; goto B491_000;
            default: return Exit;
        }

        B015_049: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROL; goto B015_050;
            case RT: state = state.OUTc; goto B015_048;
            default: return Exit;
        }

        B059_087: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.ADD; goto B059_088;
            default: return Exit;
        }

        B493_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.LD.PSH(3); goto B025_046;
            case LD: state = state.PSH(3); goto B025_046;
            case LL: state = state.SWI; goto B492_000;
            case LT: state = state.LD.PSH(3); goto B025_046;
            default: return Exit;
        }

        B015_050: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.DUP; goto B013_051;
            case RT: state = state.NOT; goto B015_049;
            default: return Exit;
        }

        B059_088: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B045_089;
            default: return Exit;
        }

        B025_046: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B024_047;
            case RT: state = state.POP; goto B023_045;
            default: return Exit;
        }

        B013_051: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LD: state = state.PSH(3); goto B015_052;
            case RT: state = state.DIV; goto B015_050;
            default: return Exit;
        }

        B045_089: switch (state.PT) // Size = 15, Colour = yellow
        {
            case LD: state = state.PSH(15); goto B059_090;
            default: return Exit;
        }

        B024_047: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B025_048;
            case RT: state = state.POP; goto B025_046;
            default: return Exit;
        }

        B015_052: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B015_053;
            case RT: state = state.POP; goto B013_051;
            default: return Exit;
        }

        B059_090: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.ADD; goto B059_091;
            default: return Exit;
        }

        B025_048: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B025_049;
            case RT: state = state.POP; goto B024_047;
            default: return Exit;
        }

        B015_053: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROL; goto B015_054;
            case RT: state = state.POP; goto B015_052;
            default: return Exit;
        }

        B059_091: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.RL.DUP; goto B042_092;
            default: return Exit;
        }

        B025_049: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROL; goto B025_050;
            case RT: state = state.OUTc; goto B025_048;
            default: return Exit;
        }

        B015_054: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B014_055;
            case RT: state = state.NOT; goto B015_053;
            default: return Exit;
        }

        B042_092: switch (state.PT) // Size = 2, Colour = light blue
        {
            case RL: state = state.PSH(2); goto B041_092;
            default: return Exit;
        }

        B025_050: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.DUP; goto B023_051;
            case RT: state = state.NOT; goto B025_049;
            default: return Exit;
        }

        B488_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LL: state = state.RL.SWI; goto B485_000;
            case RL: state = state.SWI; goto B485_000;
            default: return Exit;
        }

        B014_055: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LD: state = state.PSH(2); goto B015_056;
            case LT: state = state.RT.POP; goto B015_054;
            case RT: state = state.POP; goto B015_054;
            default: return Exit;
        }

        B041_092: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B039_092;
            default: return Exit;
        }

        B023_051: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LD: state = state.PSH(3); goto B025_052;
            case RT: state = state.DIV; goto B025_050;
            default: return Exit;
        }

        B015_056: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.SUB; goto B015_057;
            case LT: state = state.POP; goto B014_055;
            case RT: state = state.POP; goto B014_055;
            default: return Exit;
        }

        B039_092: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B038_092;
            default: return Exit;
        }

        B025_052: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B025_053;
            case RT: state = state.POP; goto B023_051;
            default: return Exit;
        }

        B015_057: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B015_058;
            case LT: state = state.OUTc; goto B015_056;
            case RT: state = state.OUTc; goto B015_056;
            default: return Exit;
        }

        B038_092: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B037_092;
            default: return Exit;
        }

        B025_053: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROL; goto B025_054;
            case RT: state = state.POP; goto B025_052;
            default: return Exit;
        }

        B015_058: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B015_059;
            case LT: state = state.NOT; goto B015_057;
            case RT: state = state.NOT; goto B015_057;
            default: return Exit;
        }

        B037_092: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B041_094;
            case RD: state = state.LR.DUP; goto B041_094;
            case RL: state = state.RR.DUP; goto B041_094;
            case RT: state = state.LR.DUP; goto B041_094;
            default: return Exit;
        }

        B025_054: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B024_055;
            case RT: state = state.NOT; goto B025_053;
            default: return Exit;
        }

        B015_059: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.SUB; goto B015_060;
            case LT: state = state.POP; goto B015_058;
            case RT: state = state.POP; goto B015_058;
            default: return Exit;
        }

        B041_094: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B044_094;
            case RR: state = state.PSH(3); goto B044_094;
            default: return Exit;
        }

        B024_055: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LD: state = state.PSH(2); goto B025_056;
            case RT: state = state.POP; goto B025_054;
            default: return Exit;
        }

        B015_060: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.DUP; goto B015_061;
            case LT: state = state.OUTc; goto B015_059;
            case RT: state = state.OUTc; goto B015_059;
            default: return Exit;
        }

        B044_094: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B045_094;
            case RR: state = state.SUB; goto B045_094;
            default: return Exit;
        }

        B025_056: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.SUB; goto B025_057;
            case RT: state = state.POP; goto B024_055;
            default: return Exit;
        }

        B015_061: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.NOT; goto B015_062;
            case LT: state = state.DIV; goto B015_060;
            case RT: state = state.DIV; goto B015_060;
            default: return Exit;
        }

        B045_094: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B046_094;
            case RR: state = state.DUP; goto B046_094;
            default: return Exit;
        }

        B380_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case RL: state = state.SWI; goto B377_000;
            default: return Exit;
        }

        B025_057: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B025_058;
            case RT: state = state.OUTc; goto B025_056;
            default: return Exit;
        }

        B015_062: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROT; goto B015_063;
            case LT: state = state.ROL; goto B015_061;
            case RT: state = state.ROL; goto B015_061;
            default: return Exit;
        }

        B046_094: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LR: state = state.PSH(4); goto B050_094;
            case RR: state = state.PSH(4); goto B050_094;
            default: return Exit;
        }

        B025_058: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B025_059;
            case RT: state = state.NOT; goto B025_057;
            default: return Exit;
        }

        B015_063: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.LD.PSH(3); goto B015_066;
            case LD: state = state.PSH(3); goto B015_066;
            case LL: state = state.LD.PSH(3); goto B015_100;
            case LT: state = state.SWI; goto B015_062;
            default: return Exit;
        }

        B050_094: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ADD; goto B051_094;
            case RR: state = state.ADD; goto B051_094;
            default: return Exit;
        }

        B025_059: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B024_060;
            case RT: state = state.POP; goto B025_058;
            default: return Exit;
        }

        B015_066: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B014_067;
            case RT: state = state.POP; goto B013_065;
            default: return Exit;
        }

        B015_100: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B014_101;
            case RT: state = state.POP; goto B013_099;
            default: return Exit;
        }

        B051_094: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.RD.PSH(9); goto B037_097;
            case RR: state = state.LD.PSH(9); goto B037_097;
            default: return Exit;
        }

        B024_060: switch (state.PT) // Size = 2, Colour = yellow
        {
            case LD: state = state.PSH(2); goto B025_061;
            case RT: state = state.INc; goto B025_059;
            default: return Exit;
        }

        B014_067: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B015_068;
            case RT: state = state.POP; goto B015_066;
            default: return Exit;
        }

        B014_101: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B015_102;
            case RT: state = state.POP; goto B015_100;
            default: return Exit;
        }

        B037_097: switch (state.PT) // Size = 23, Colour = light green
        {
            case LD: state = state.PSH(23); goto B059_098;
            case RD: state = state.LD.PSH(23); goto B059_098;
            default: return Exit;
        }

        B025_061: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B025_062;
            case RT: state = state.POP; goto B024_060;
            default: return Exit;
        }

        B015_068: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B015_069;
            case RT: state = state.POP; goto B014_067;
            default: return Exit;
        }

        B015_102: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B015_103;
            case RT: state = state.POP; goto B014_101;
            default: return Exit;
        }

        B059_098: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.ADD; goto B051_099;
            default: return Exit;
        }

        B025_062: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B023_063;
            case RT: state = state.POP; goto B025_061;
            default: return Exit;
        }

        B015_069: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_070;
            case RT: state = state.OUTc; goto B015_068;
            default: return Exit;
        }

        B015_103: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_104;
            case RT: state = state.OUTc; goto B015_102;
            default: return Exit;
        }

        B051_099: switch (state.PT) // Size = 9, Colour = cyan
        {
            case LD: state = state.PSH(9); goto B037_100;
            default: return Exit;
        }

        B023_063: switch (state.PT) // Size = 3, Colour = magenta
        {
            case LD: state = state.PSH(3); goto B025_064;
            case RT: state = state.NOT; goto B025_062;
            default: return Exit;
        }

        B015_070: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B013_071;
            case RT: state = state.NOT; goto B015_069;
            default: return Exit;
        }

        B015_104: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B011_105;
            case RT: state = state.NOT; goto B015_103;
            default: return Exit;
        }

        B037_100: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LD: state = state.PSH(23); goto B056_101;
            default: return Exit;
        }

        B025_064: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.PSH(1); goto B024_065;
            case RT: state = state.POP; goto B023_063;
            default: return Exit;
        }

        B013_071: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LD: state = state.PSH(3); goto B015_072;
            case RT: state = state.DIV; goto B015_070;
            default: return Exit;
        }

        B011_105: switch (state.PT) // Size = 5, Colour = yellow
        {
            case LD: state = state.PSH(5); goto B015_106;
            case LT: state = state.RT.DIV; goto B015_104;
            case RT: state = state.DIV; goto B015_104;
            default: return Exit;
        }

        B056_101: switch (state.PT) // Size = 4, Colour = light cyan
        {
            case LD: state = state.PSH(4); goto B059_102;
            default: return Exit;
        }

        B024_065: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LD: state = state.PSH(2); goto B025_066;
            case RT: state = state.POP; goto B025_064;
            default: return Exit;
        }

        B015_072: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B015_073;
            case RT: state = state.POP; goto B013_071;
            default: return Exit;
        }

        B015_106: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B015_107;
            case LT: state = state.POP; goto B011_105;
            case RT: state = state.POP; goto B011_105;
            default: return Exit;
        }

        B059_102: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.MUL; goto B059_103;
            default: return Exit;
        }

        B025_066: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.SUB; goto B025_067;
            case RT: state = state.POP; goto B024_065;
            default: return Exit;
        }

        B015_073: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B015_074;
            case RT: state = state.POP; goto B015_072;
            default: return Exit;
        }

        B015_107: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B015_108;
            case LT: state = state.POP; goto B015_106;
            case RT: state = state.POP; goto B015_106;
            default: return Exit;
        }

        B059_103: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.ADD; goto B059_104;
            default: return Exit;
        }

        B025_067: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B025_068;
            case RT: state = state.OUTc; goto B025_066;
            default: return Exit;
        }

        B015_074: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B014_075;
            case RT: state = state.NOT; goto B015_073;
            default: return Exit;
        }

        B015_108: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B015_109;
            case LT: state = state.NOT; goto B015_107;
            case RT: state = state.NOT; goto B015_107;
            default: return Exit;
        }

        B059_104: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B057_105;
            default: return Exit;
        }

        B025_068: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.DUP; goto B021_069;
            case RT: state = state.NOT; goto B025_067;
            default: return Exit;
        }

        B014_075: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B015_076;
            case RT: state = state.POP; goto B015_074;
            default: return Exit;
        }

        B015_109: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROL; goto B015_110;
            case LT: state = state.POP; goto B015_108;
            case RT: state = state.POP; goto B015_108;
            default: return Exit;
        }

        B057_105: switch (state.PT) // Size = 3, Colour = light cyan
        {
            case LD: state = state.PSH(3); goto B059_106;
            default: return Exit;
        }

        B021_069: switch (state.PT) // Size = 5, Colour = light green
        {
            case LD: state = state.PSH(5); goto B025_070;
            case RT: state = state.DIV; goto B025_068;
            default: return Exit;
        }

        B015_076: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.SUB; goto B015_077;
            case RT: state = state.POP; goto B014_075;
            default: return Exit;
        }

        B015_110: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B015_111;
            case LT: state = state.NOT; goto B015_109;
            case RT: state = state.NOT; goto B015_109;
            default: return Exit;
        }

        B059_106: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ADD; goto B059_107;
            default: return Exit;
        }

        B025_070: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(1); goto B025_071;
            case RT: state = state.POP; goto B021_069;
            default: return Exit;
        }

        B015_077: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ROL; goto B014_078;
            case RT: state = state.OUTc; goto B015_076;
            default: return Exit;
        }

        B015_111: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROT; goto B015_112;
            case LT: state = state.POP; goto B015_110;
            case RT: state = state.POP; goto B015_110;
            default: return Exit;
        }

        B059_107: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B048_108;
            default: return Exit;
        }

        B025_071: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B025_072;
            case RT: state = state.POP; goto B025_070;
            default: return Exit;
        }

        B014_078: switch (state.PT) // Size = 2, Colour = dark blue
        {
            case LD: state = state.PSH(2); goto B015_079;
            case RT: state = state.NOT; goto B015_077;
            default: return Exit;
        }

        B015_112: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.RD.PSH(1); goto B015_095;
            case LD: state = state.PSH(1); goto B015_095;
            case LL: state = state.RD.PSH(1); goto B015_095;
            case LT: state = state.SWI; goto B015_111;
            default: return Exit;
        }

        B455_000: switch (state.PT) // Size = 3, Colour = dark red
        {
            case RL: state = state.SWI; goto B452_000;
            default: return Exit;
        }

        B048_108: switch (state.PT) // Size = 12, Colour = green
        {
            case LD: state = state.PSH(12); goto B059_109;
            default: return Exit;
        }

        B025_072: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B025_073;
            case RT: state = state.NOT; goto B025_071;
            default: return Exit;
        }

        B015_079: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B015_080;
            case RT: state = state.POP; goto B014_078;
            default: return Exit;
        }

        B015_095: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROT; goto B015_096;
            case LT: state = state.POP; goto B015_094;
            case RD: state = state.ROT; goto B015_096;
            case RT: state = state.POP; goto B015_094;
            default: return Exit;
        }

        B059_109: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ADD; goto B043_110;
            default: return Exit;
        }

        B025_073: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ROL; goto B023_074;
            case RT: state = state.POP; goto B025_072;
            default: return Exit;
        }

        B015_080: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B013_081;
            case RT: state = state.POP; goto B015_079;
            default: return Exit;
        }

        B015_096: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state.LR.PSH(3); goto B402_000;
            case LL: state = state.LR.PSH(3); goto B402_000;
            case LT: state = state.SWI; goto B015_095;
            case RR: state = state.LR.PSH(3); goto B402_000;
            case RD: state = state.LR.PSH(3); goto B402_000;
            case RL: state = state.LR.PSH(3); goto B402_000;
            case RT: state = state.SWI; goto B015_095;
            default: return Exit;
        }

        B043_110: switch (state.PT) // Size = 17, Colour = dark cyan
        {
            case LD: state = state.PSH(17); goto B059_111;
            default: return Exit;
        }

        B023_074: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LD: state = state.PSH(3); goto B025_075;
            case RT: state = state.NOT; goto B025_073;
            default: return Exit;
        }

        B013_081: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LD: state = state.PSH(3); goto B015_082;
            case RT: state = state.NOT; goto B015_080;
            default: return Exit;
        }

        B059_111: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.RL.PSH(2); goto B057_114;
            default: return Exit;
        }

        B025_075: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B024_076;
            case RT: state = state.POP; goto B023_074;
            default: return Exit;
        }

        B015_082: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.PSH(1); goto B014_083;
            case RT: state = state.POP; goto B013_081;
            default: return Exit;
        }

        B015_094: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.NOT; goto B015_091;
            case RT: state = state.NOT; goto B015_091;
            default: return Exit;
        }

        B057_114: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B058_114;
            case LL: state = state.PSH(1); goto B056_114;
            case RR: state = state.POP; goto B058_114;
            case RL: state = state.PSH(1); goto B056_114;
            default: return Exit;
        }

        B024_076: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B025_077;
            case RT: state = state.POP; goto B025_075;
            default: return Exit;
        }

        B014_083: switch (state.PT) // Size = 2, Colour = green
        {
            case LD: state = state.PSH(2); goto B015_084;
            case RT: state = state.POP; goto B015_082;
            default: return Exit;
        }

        B015_091: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.ROL; goto B015_092;
            case LT: state = state.POP; goto B015_090;
            case RT: state = state.POP; goto B015_090;
            default: return Exit;
        }

        B013_045: switch (state.PT) // Size = 3, Colour = light red
        {
            case RT: state = state.LD.PSH(3); goto B015_046;
            default: return Exit;
        }

        B056_114: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B057_114;
            case LL: state = state.ROL; goto B055_114;
            case RR: state = state.POP; goto B057_114;
            case RL: state = state.ROL; goto B055_114;
            default: return Exit;
        }

        B025_077: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B025_078;
            case RT: state = state.POP; goto B024_076;
            default: return Exit;
        }

        B015_084: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.SUB; goto B015_085;
            case RT: state = state.POP; goto B014_083;
            default: return Exit;
        }

        B015_090: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.PSH(1); goto B015_091;
            case LT: state = state.NOT; goto B015_089;
            case RT: state = state.NOT; goto B015_089;
            default: return Exit;
        }

        B055_114: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B056_114;
            case LL: state = state.OUTc; goto B054_114;
            case RR: state = state.NOT; goto B056_114;
            case RL: state = state.OUTc; goto B054_114;
            default: return Exit;
        }

        B025_078: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B025_079;
            case RT: state = state.OUTc; goto B025_077;
            default: return Exit;
        }

        B015_085: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROL; goto B015_086;
            case RT: state = state.OUTc; goto B015_084;
            default: return Exit;
        }

        B015_089: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_090;
            case LT: state = state.POP; goto B015_088;
            case RT: state = state.POP; goto B015_088;
            default: return Exit;
        }

        B054_114: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B055_114;
            case LL: state = state.PSH(1); goto B053_114;
            case RR: state = state.SUB; goto B055_114;
            case RL: state = state.PSH(1); goto B053_114;
            default: return Exit;
        }

        B025_079: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B021_080;
            case RT: state = state.NOT; goto B025_078;
            default: return Exit;
        }

        B015_086: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.DUP; goto B011_087;
            case RT: state = state.NOT; goto B015_085;
            default: return Exit;
        }

        B015_088: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.PSH(1); goto B015_089;
            case LT: state = state.POP; goto B011_087;
            case RT: state = state.POP; goto B011_087;
            default: return Exit;
        }

        B053_114: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B054_114;
            case LL: state = state.SUB; goto B052_114;
            case RR: state = state.POP; goto B054_114;
            case RL: state = state.SUB; goto B052_114;
            default: return Exit;
        }

        B021_080: switch (state.PT) // Size = 5, Colour = yellow
        {
            case LD: state = state.PSH(5); goto B025_081;
            case LT: state = state.RT.DIV; goto B025_079;
            case RT: state = state.DIV; goto B025_079;
            default: return Exit;
        }

        B011_087: switch (state.PT) // Size = 5, Colour = magenta
        {
            case LD: state = state.PSH(5); goto B015_088;
            case LT: state = state.RT.DIV; goto B015_086;
            case RT: state = state.DIV; goto B015_086;
            default: return Exit;
        }

        B052_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B053_114;
            case LL: state = state.DUP; goto B051_114;
            case RR: state = state.OUTc; goto B053_114;
            case RL: state = state.DUP; goto B051_114;
            default: return Exit;
        }

        B025_081: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B025_082;
            case LT: state = state.POP; goto B021_080;
            case RT: state = state.POP; goto B021_080;
            default: return Exit;
        }

        B051_114: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B052_114;
            case LL: state = state.NOT; goto B048_114;
            case RR: state = state.DIV; goto B052_114;
            case RL: state = state.NOT; goto B048_114;
            default: return Exit;
        }

        B025_082: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B025_083;
            case LT: state = state.POP; goto B025_081;
            case RT: state = state.POP; goto B025_081;
            default: return Exit;
        }

        B048_114: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B051_114;
            case LL: state = state.PSH(3); goto B047_114;
            case RR: state = state.ROL; goto B051_114;
            case RL: state = state.PSH(3); goto B047_114;
            default: return Exit;
        }

        B025_083: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B025_084;
            case LT: state = state.NOT; goto B025_082;
            case RT: state = state.NOT; goto B025_082;
            default: return Exit;
        }

        B047_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B048_114;
            case LL: state = state.MUL; goto B046_114;
            case RR: state = state.POP; goto B048_114;
            case RL: state = state.MUL; goto B046_114;
            default: return Exit;
        }

        B025_084: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROL; goto B025_085;
            case LT: state = state.POP; goto B025_083;
            case RT: state = state.POP; goto B025_083;
            default: return Exit;
        }

        B013_099: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case RT: state = state.LD.PSH(3); goto B015_100;
            default: return Exit;
        }

        B046_114: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B047_114;
            case LL: state = state.DUP; goto B045_114;
            case RR: state = state.OUTi; goto B047_114;
            case RL: state = state.DUP; goto B045_114;
            default: return Exit;
        }

        B025_085: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B025_086;
            case LT: state = state.NOT; goto B025_084;
            case RT: state = state.NOT; goto B025_084;
            default: return Exit;
        }

        B015_092: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.PSH(1); goto B015_095;
            default: return Exit;
        }

        B045_114: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B046_114;
            case LL: state = state.ROT; goto B044_114;
            case RR: state = state.DIV; goto B046_114;
            case RL: state = state.ROT; goto B044_114;
            default: return Exit;
        }

        B025_086: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROT; goto B025_087;
            case LT: state = state.POP; goto B025_085;
            case RT: state = state.POP; goto B025_085;
            default: return Exit;
        }

        B044_114: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B045_114;
            case LD: state = state.ROT; goto B044_115;
            case LL: state = state.POP; goto B043_114;
            case LT: state = state.RR.SWI; goto B045_114;
            case RR: state = state.SWI; goto B045_114;
            case RD: state = state.ROT; goto B044_115;
            case RL: state = state.POP; goto B043_114;
            case RT: state = state.LR.SWI; goto B045_114;
            default: return Exit;
        }

        B025_087: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state.LR.PSH(3); goto B402_000;
            case LL: state = state.LR.PSH(3); goto B402_000;
            case LT: state = state.SWI; goto B025_086;
            default: return Exit;
        }

        B043_114: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B057_114;
            case RL: state = state.PSH(2); goto B057_114;
            default: return Exit;
        }

        B044_115: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.RR.POP; goto B045_116;
            case LD: state = state.LT.SWI; goto B044_114;
            case LL: state = state.RT.SWI; goto B044_114;
            case LT: state = state.SWI; goto B044_114;
            case RR: state = state.POP; goto B045_116;
            case RD: state = state.RT.SWI; goto B044_114;
            case RL: state = state.LT.SWI; goto B044_114;
            case RT: state = state.SWI; goto B044_114;
            default: return Exit;
        }

        B045_116: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RR: state = state.LD.PSH(3); goto B059_120;
            default: return Exit;
        }

        B059_120: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.PSH(1); goto B058_121;
            case RT: state = state.POP; goto B057_119;
            default: return Exit;
        }

        B058_121: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LD: state = state.PSH(2); goto B059_122;
            case RT: state = state.POP; goto B059_120;
            default: return Exit;
        }

        B059_122: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B059_123;
            case RT: state = state.POP; goto B058_121;
            default: return Exit;
        }

        B059_123: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B059_124;
            case RT: state = state.OUTc; goto B059_122;
            default: return Exit;
        }

        B059_124: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.OUTi; goto B050_125;
            case RT: state = state.NOT; goto B059_123;
            default: return Exit;
        }

        B050_125: switch (state.PT) // Size = 10, Colour = light yellow
        {
            case LD: state = state.PSH(10); goto B059_126;
            case RT: state = state.MUL; goto B059_124;
            default: return Exit;
        }

        B059_126: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.OUTc; goto B059_127;
            case RT: state = state.POP; goto B050_125;
            default: return Exit;
        }

        B059_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B059_128;
            case RT: state = state.SUB; goto B059_126;
            default: return Exit;
        }

        B059_128: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B058_129;
            case RT: state = state.POP; goto B059_127;
            default: return Exit;
        }

        B058_114: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.LL.PSH(2); goto B057_114;
            case RR: state = state.RL.PSH(2); goto B057_114;
            default: return Exit;
        }

        B058_129: switch (state.PT) // Size = 2, Colour = yellow
        {
            case LD: state = state.PSH(2); goto B059_130;
            case RT: state = state.INc; goto B059_128;
            default: return Exit;
        }

        B059_130: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B059_131;
            case RT: state = state.POP; goto B058_129;
            default: return Exit;
        }

        B059_131: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B059_132;
            case RT: state = state.POP; goto B059_130;
            default: return Exit;
        }

        B059_132: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.DUP; goto B057_133;
            case RT: state = state.NOT; goto B059_131;
            default: return Exit;
        }

        B013_065: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case RT: state = state.SWI; goto B015_062;
            default: return Exit;
        }

        B057_133: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LD: state = state.PSH(3); goto B059_134;
            case RT: state = state.DIV; goto B059_132;
            default: return Exit;
        }

        B059_134: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B058_135;
            case RT: state = state.POP; goto B057_133;
            default: return Exit;
        }

        B058_135: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LD: state = state.PSH(2); goto B059_136;
            case RT: state = state.POP; goto B059_134;
            default: return Exit;
        }

        B059_136: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.SUB; goto B059_137;
            case RT: state = state.POP; goto B058_135;
            default: return Exit;
        }

        B059_137: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.ROL; goto B059_138;
            case RT: state = state.OUTc; goto B059_136;
            default: return Exit;
        }

        B059_138: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.DUP; goto B057_139;
            case RT: state = state.NOT; goto B059_137;
            default: return Exit;
        }

        B057_139: switch (state.PT) // Size = 3, Colour = light red
        {
            case LD: state = state.PSH(3); goto B059_140;
            case LT: state = state.RT.DIV; goto B059_138;
            case RT: state = state.DIV; goto B059_138;
            default: return Exit;
        }

        B059_140: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B059_141;
            case LT: state = state.POP; goto B057_139;
            case RT: state = state.POP; goto B057_139;
            default: return Exit;
        }

        B059_141: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B059_142;
            case LT: state = state.POP; goto B059_140;
            case RT: state = state.POP; goto B059_140;
            default: return Exit;
        }

        B059_142: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.GT_; goto B059_143;
            case LT: state = state.NOT; goto B059_141;
            case RT: state = state.NOT; goto B059_141;
            default: return Exit;
        }

        B059_143: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.NOT; goto B059_144;
            case LT: state = state.GT_; goto B059_142;
            case RT: state = state.GT_; goto B059_142;
            default: return Exit;
        }

        B059_144: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.NOT; goto B059_145;
            case LT: state = state.ROL; goto B059_143;
            case RT: state = state.ROL; goto B059_143;
            default: return Exit;
        }

        B059_145: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ROT; goto B059_146;
            case LT: state = state.ROL; goto B059_144;
            case RT: state = state.ROL; goto B059_144;
            default: return Exit;
        }

        B059_146: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(3); goto B063_153;
            case LD: state = state.RR.PSH(3); goto B063_153;
            case LL: state = state.LD.PSH(3); goto B059_120;
            case LT: state = state.SWI; goto B059_145;
            default: return Exit;
        }

        B063_153: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROT; goto B064_153;
            case LL: state = state.POP; goto B060_153;
            case RR: state = state.ROT; goto B064_153;
            case RL: state = state.POP; goto B060_153;
            default: return Exit;
        }

        B064_153: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.LL.SWI; goto B063_153;
            case LD: state = state.RL.SWI; goto B063_153;
            case LL: state = state.SWI; goto B063_153;
            case LT: state = state.RR.PSH(3); goto B248_150;
            case RR: state = state.RL.SWI; goto B063_153;
            case RD: state = state.LL.SWI; goto B063_153;
            case RL: state = state.SWI; goto B063_153;
            case RT: state = state.LR.PSH(3); goto B248_150;
            default: return Exit;
        }

        B248_150: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROT; goto B249_150;
            case LL: state = state.POP; goto B245_150;
            case RR: state = state.ROT; goto B249_150;
            case RL: state = state.POP; goto B245_150;
            default: return Exit;
        }

        B060_153: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LL: state = state.LR.PSH(3); goto B063_153;
            case RL: state = state.RR.PSH(3); goto B063_153;
            default: return Exit;
        }

        B249_150: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.LL.SWI; goto B248_150;
            case LD: state = state.RL.SWI; goto B248_150;
            case LL: state = state.SWI; goto B248_150;
            case LT: state = state.RR.PSH(9); goto B301_045;
            case RR: state = state.RL.SWI; goto B248_150;
            case RD: state = state.LL.SWI; goto B248_150;
            case RL: state = state.SWI; goto B248_150;
            case RT: state = state.LR.PSH(9); goto B301_045;
            default: return Exit;
        }

        B301_045: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B302_045;
            case RR: state = state.LR.PSH(23); goto B302_045;
            default: return Exit;
        }

        B245_150: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LL: state = state.LR.PSH(3); goto B248_150;
            case RL: state = state.RR.PSH(3); goto B248_150;
            default: return Exit;
        }

        B302_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B303_045;
            default: return Exit;
        }

        B303_045: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LR: state = state.PSH(23); goto B304_045;
            default: return Exit;
        }

        B304_045: switch (state.PT) // Size = 5, Colour = light yellow
        {
            case LR: state = state.PSH(5); goto B305_045;
            default: return Exit;
        }

        B305_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B306_045;
            default: return Exit;
        }

        B306_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B307_045;
            default: return Exit;
        }

        B307_045: switch (state.PT) // Size = 10, Colour = light red
        {
            case LR: state = state.PSH(10); goto B308_045;
            default: return Exit;
        }

        B308_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B309_045;
            default: return Exit;
        }

        B309_045: switch (state.PT) // Size = 9, Colour = dark yellow
        {
            case LR: state = state.PSH(9); goto B310_045;
            default: return Exit;
        }

        B023_045: switch (state.PT) // Size = 3, Colour = light red
        {
            case RT: state = state.LD.PSH(3); goto B025_046;
            default: return Exit;
        }

        B310_045: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LR: state = state.PSH(23); goto B311_045;
            default: return Exit;
        }

        B311_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ADD; goto B312_045;
            default: return Exit;
        }

        B312_045: switch (state.PT) // Size = 22, Colour = green
        {
            case LR: state = state.PSH(22); goto B313_045;
            default: return Exit;
        }

        B313_045: switch (state.PT) // Size = 23, Colour = dark green
        {
            case LR: state = state.PSH(23); goto B314_045;
            default: return Exit;
        }

        B314_045: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.PSH(4); goto B315_045;
            default: return Exit;
        }

        B315_045: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.MUL; goto B316_045;
            default: return Exit;
        }

        B316_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B317_045;
            default: return Exit;
        }

        B317_045: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.DUP; goto B318_045;
            default: return Exit;
        }

        B318_045: switch (state.PT) // Size = 13, Colour = light green
        {
            case LR: state = state.PSH(13); goto B319_045;
            default: return Exit;
        }

        B319_045: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.SUB; goto B320_045;
            default: return Exit;
        }

        B320_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B321_045;
            default: return Exit;
        }

        B321_045: switch (state.PT) // Size = 15, Colour = dark yellow
        {
            case LR: state = state.PSH(15); goto B322_045;
            default: return Exit;
        }

        B322_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ADD; goto B323_045;
            default: return Exit;
        }

        B323_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.RD.DUP; goto B324_055;
            default: return Exit;
        }

        B057_119: switch (state.PT) // Size = 3, Colour = light cyan
        {
            case RT: state = state.LD.PSH(3); goto B059_120;
            default: return Exit;
        }

        B324_055: switch (state.PT) // Size = 8, Colour = light blue
        {
            case RD: state = state.PSH(8); goto B324_063;
            default: return Exit;
        }

        B324_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B324_064;
            default: return Exit;
        }

        B324_064: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B324_066;
            default: return Exit;
        }

        B324_066: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B324_067;
            default: return Exit;
        }

        B324_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B326_055;
            case RD: state = state.RT.DUP; goto B326_055;
            case RL: state = state.LT.DUP; goto B326_055;
            case RT: state = state.DUP; goto B326_055;
            default: return Exit;
        }

        B326_055: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B326_054;
            case RT: state = state.PSH(9); goto B326_054;
            default: return Exit;
        }

        B326_054: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B326_053;
            case RT: state = state.ADD; goto B326_053;
            default: return Exit;
        }

        B326_053: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.LD.DUP; goto B328_050;
            case RT: state = state.RD.DUP; goto B328_050;
            default: return Exit;
        }

        B328_050: switch (state.PT) // Size = 13, Colour = light blue
        {
            case LD: state = state.PSH(13); goto B328_063;
            case RD: state = state.PSH(13); goto B328_063;
            default: return Exit;
        }

        B328_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B328_064;
            case RD: state = state.SUB; goto B328_064;
            default: return Exit;
        }

        B328_064: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B328_066;
            case RD: state = state.PSH(2); goto B328_066;
            default: return Exit;
        }

        B328_066: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B328_067;
            case RD: state = state.ROT; goto B328_067;
            default: return Exit;
        }

        B328_067: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state.RT.DUP; goto B330_059;
            case LD: state = state.LT.DUP; goto B330_059;
            case LL: state = state.RT.DUP; goto B330_059;
            case LT: state = state.DUP; goto B330_059;
            case RR: state = state.LT.DUP; goto B330_059;
            case RD: state = state.RT.DUP; goto B330_059;
            case RL: state = state.LT.DUP; goto B330_059;
            case RT: state = state.DUP; goto B330_059;
            default: return Exit;
        }

        B330_059: switch (state.PT) // Size = 5, Colour = red
        {
            case LT: state = state.PSH(5); goto B330_058;
            case RT: state = state.PSH(5); goto B330_058;
            default: return Exit;
        }

        B330_058: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B330_057;
            case RT: state = state.SUB; goto B330_057;
            default: return Exit;
        }

        B330_057: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.RR.DUP; goto B332_045;
            case RT: state = state.LR.DUP; goto B332_045;
            default: return Exit;
        }

        B332_045: switch (state.PT) // Size = 16, Colour = light red
        {
            case LR: state = state.PSH(16); goto B333_045;
            case RR: state = state.LR.PSH(16); goto B333_045;
            default: return Exit;
        }

        B333_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B334_045;
            default: return Exit;
        }

        B334_045: switch (state.PT) // Size = 9, Colour = dark yellow
        {
            case LR: state = state.PSH(9); goto B335_045;
            default: return Exit;
        }

        B335_045: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LR: state = state.PSH(23); goto B336_045;
            default: return Exit;
        }

        B336_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ADD; goto B337_045;
            default: return Exit;
        }

        B337_045: switch (state.PT) // Size = 5, Colour = green
        {
            case LR: state = state.PSH(5); goto B338_045;
            default: return Exit;
        }

        B338_045: switch (state.PT) // Size = 23, Colour = dark green
        {
            case LR: state = state.PSH(23); goto B339_045;
            default: return Exit;
        }

        B339_045: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.PSH(4); goto B340_045;
            default: return Exit;
        }

        B340_045: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.MUL; goto B341_045;
            default: return Exit;
        }

        B341_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B342_045;
            default: return Exit;
        }

        B342_045: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.DUP; goto B343_045;
            default: return Exit;
        }

        B343_045: switch (state.PT) // Size = 20, Colour = light green
        {
            case LR: state = state.PSH(20); goto B344_045;
            default: return Exit;
        }

        B344_045: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ADD; goto B345_045;
            default: return Exit;
        }

        B345_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.RD.DUP; goto B346_050;
            default: return Exit;
        }

        B346_050: switch (state.PT) // Size = 13, Colour = light blue
        {
            case RD: state = state.PSH(13); goto B346_063;
            default: return Exit;
        }

        B346_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B346_064;
            default: return Exit;
        }

        B346_064: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B346_066;
            default: return Exit;
        }

        B346_066: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B346_067;
            default: return Exit;
        }

        B346_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B348_053;
            case RD: state = state.RT.DUP; goto B348_053;
            case RL: state = state.LT.DUP; goto B348_053;
            case RT: state = state.DUP; goto B348_053;
            default: return Exit;
        }

        B348_053: switch (state.PT) // Size = 11, Colour = red
        {
            case LT: state = state.PSH(11); goto B348_052;
            case RT: state = state.PSH(11); goto B348_052;
            default: return Exit;
        }

        B348_052: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B348_051;
            case RT: state = state.ADD; goto B348_051;
            default: return Exit;
        }

        B348_051: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.RR.DUP; goto B350_045;
            case RT: state = state.LR.DUP; goto B350_045;
            default: return Exit;
        }

        B350_045: switch (state.PT) // Size = 4, Colour = yellow
        {
            case LR: state = state.PSH(4); goto B351_045;
            case RR: state = state.LR.PSH(4); goto B351_045;
            default: return Exit;
        }

        B351_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.SUB; goto B352_045;
            default: return Exit;
        }

        B352_045: switch (state.PT) // Size = 5, Colour = light green
        {
            case LR: state = state.PSH(5); goto B353_045;
            default: return Exit;
        }

        B353_045: switch (state.PT) // Size = 23, Colour = green
        {
            case LR: state = state.PSH(23); goto B354_045;
            default: return Exit;
        }

        B354_045: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LR: state = state.PSH(3); goto B355_045;
            default: return Exit;
        }

        B355_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.MUL; goto B356_045;
            default: return Exit;
        }

        B356_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ADD; goto B357_045;
            default: return Exit;
        }

        B357_045: switch (state.PT) // Size = 9, Colour = dark blue
        {
            case LR: state = state.PSH(9); goto B358_045;
            default: return Exit;
        }

        B358_045: switch (state.PT) // Size = 23, Colour = light blue
        {
            case LR: state = state.PSH(23); goto B359_045;
            default: return Exit;
        }

        B359_045: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.ADD; goto B360_045;
            default: return Exit;
        }

        B360_045: switch (state.PT) // Size = 6, Colour = magenta
        {
            case LR: state = state.PSH(6); goto B361_045;
            default: return Exit;
        }

        B361_045: switch (state.PT) // Size = 23, Colour = dark magenta
        {
            case LR: state = state.PSH(23); goto B362_045;
            default: return Exit;
        }

        B362_045: switch (state.PT) // Size = 5, Colour = light magenta
        {
            case LR: state = state.PSH(5); goto B363_045;
            default: return Exit;
        }

        B363_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.MUL; goto B364_045;
            default: return Exit;
        }

        B364_045: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ADD; goto B365_045;
            default: return Exit;
        }

        B365_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B366_045;
            default: return Exit;
        }

        B366_045: switch (state.PT) // Size = 23, Colour = light magenta
        {
            case LR: state = state.PSH(23); goto B367_045;
            default: return Exit;
        }

        B367_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.SUB; goto B368_045;
            default: return Exit;
        }

        B368_045: switch (state.PT) // Size = 9, Colour = dark red
        {
            case LR: state = state.PSH(9); goto B369_045;
            default: return Exit;
        }

        B369_045: switch (state.PT) // Size = 23, Colour = light red
        {
            case LR: state = state.PSH(23); goto B370_045;
            default: return Exit;
        }

        B370_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ADD; goto B371_045;
            default: return Exit;
        }

        B371_045: switch (state.PT) // Size = 15, Colour = yellow
        {
            case LR: state = state.PSH(15); goto B372_045;
            default: return Exit;
        }

        B372_045: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LR: state = state.PSH(23); goto B373_045;
            default: return Exit;
        }

        B373_045: switch (state.PT) // Size = 4, Colour = light yellow
        {
            case LR: state = state.PSH(4); goto B374_045;
            default: return Exit;
        }

        B374_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.MUL; goto B375_045;
            default: return Exit;
        }

        B375_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.ADD; goto B376_045;
            default: return Exit;
        }

        B376_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.RD.DUP; goto B377_056;
            default: return Exit;
        }

        B377_056: switch (state.PT) // Size = 7, Colour = light blue
        {
            case RD: state = state.PSH(7); goto B377_063;
            default: return Exit;
        }

        B377_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.ADD; goto B377_064;
            default: return Exit;
        }

        B377_064: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RD: state = state.PSH(2); goto B377_066;
            default: return Exit;
        }

        B377_066: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RD: state = state.ROT; goto B377_067;
            default: return Exit;
        }

        B377_067: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.LT.DUP; goto B379_061;
            case RD: state = state.RT.DUP; goto B379_061;
            case RL: state = state.LT.DUP; goto B379_061;
            case RT: state = state.DUP; goto B379_061;
            default: return Exit;
        }

        B379_061: switch (state.PT) // Size = 3, Colour = light red
        {
            case LT: state = state.PSH(3); goto B379_060;
            case RT: state = state.PSH(3); goto B379_060;
            default: return Exit;
        }

        B379_060: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B379_059;
            case RT: state = state.SUB; goto B379_059;
            default: return Exit;
        }

        B379_059: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B379_051;
            case RT: state = state.DUP; goto B379_051;
            default: return Exit;
        }

        B379_051: switch (state.PT) // Size = 8, Colour = dark magenta
        {
            case LT: state = state.PSH(8); goto B379_050;
            case RT: state = state.PSH(8); goto B379_050;
            default: return Exit;
        }

        B379_050: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B379_049;
            case RT: state = state.ADD; goto B379_049;
            default: return Exit;
        }

        B379_049: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state.RR.PSH(9); goto B382_045;
            case RT: state = state.LR.PSH(9); goto B382_045;
            default: return Exit;
        }

        B382_045: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B383_045;
            case RR: state = state.LR.PSH(23); goto B383_045;
            default: return Exit;
        }

        B383_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ADD; goto B384_045;
            default: return Exit;
        }

        B384_045: switch (state.PT) // Size = 23, Colour = dark blue
        {
            case LR: state = state.PSH(23); goto B385_045;
            default: return Exit;
        }

        B385_045: switch (state.PT) // Size = 5, Colour = light blue
        {
            case LR: state = state.PSH(5); goto B386_045;
            default: return Exit;
        }

        B386_045: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.MUL; goto B387_045;
            default: return Exit;
        }

        B387_045: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.RD.DUP; goto B388_053;
            default: return Exit;
        }

        B388_053: switch (state.PT) // Size = 10, Colour = light blue
        {
            case RD: state = state.PSH(10); goto B388_063;
            default: return Exit;
        }

        B388_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case RD: state = state.SUB; goto B388_064;
            default: return Exit;
        }

        B388_064: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RD: state = state.PSH(2); goto B388_066;
            default: return Exit;
        }

        B388_066: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RD: state = state.ROT; goto B388_067;
            default: return Exit;
        }

        B388_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.LT.DUP; goto B390_063;
            case RD: state = state.RT.DUP; goto B390_063;
            case RL: state = state.LT.DUP; goto B390_063;
            case RT: state = state.DUP; goto B390_063;
            default: return Exit;
        }

        B390_063: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B390_062;
            case RT: state = state.PSH(1); goto B390_062;
            default: return Exit;
        }

        B390_062: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B390_061;
            case RT: state = state.SUB; goto B390_061;
            default: return Exit;
        }

        B390_061: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.RR.DUP; goto B392_045;
            case RT: state = state.LR.DUP; goto B392_045;
            default: return Exit;
        }

        B392_045: switch (state.PT) // Size = 20, Colour = light cyan
        {
            case LR: state = state.PSH(20); goto B393_045;
            case RR: state = state.LR.PSH(20); goto B393_045;
            default: return Exit;
        }

        B393_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.SUB; goto B394_045;
            default: return Exit;
        }

        B394_045: switch (state.PT) // Size = 9, Colour = dark blue
        {
            case LR: state = state.PSH(9); goto B395_045;
            default: return Exit;
        }

        B395_045: switch (state.PT) // Size = 23, Colour = light blue
        {
            case LR: state = state.PSH(23); goto B396_045;
            default: return Exit;
        }

        B396_045: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.ADD; goto B397_045;
            default: return Exit;
        }

        B397_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.RD.PSH(2); goto B400_047;
            default: return Exit;
        }

        B400_047: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B400_048;
            case LT: state = state.POP; goto B400_045;
            case RD: state = state.PSH(1); goto B400_048;
            case RT: state = state.POP; goto B400_045;
            default: return Exit;
        }

        B400_048: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B400_049;
            case LT: state = state.POP; goto B400_047;
            case RD: state = state.ROL; goto B400_049;
            case RT: state = state.POP; goto B400_047;
            default: return Exit;
        }

        B400_049: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B400_050;
            case LT: state = state.NOT; goto B400_048;
            case RD: state = state.OUTc; goto B400_050;
            case RT: state = state.NOT; goto B400_048;
            default: return Exit;
        }

        B400_050: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B400_051;
            case LT: state = state.SUB; goto B400_049;
            case RD: state = state.PSH(1); goto B400_051;
            case RT: state = state.SUB; goto B400_049;
            default: return Exit;
        }

        B400_051: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B400_052;
            case LT: state = state.POP; goto B400_050;
            case RD: state = state.SUB; goto B400_052;
            case RT: state = state.POP; goto B400_050;
            default: return Exit;
        }

        B400_052: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B400_053;
            case LT: state = state.OUTc; goto B400_051;
            case RD: state = state.DUP; goto B400_053;
            case RT: state = state.OUTc; goto B400_051;
            default: return Exit;
        }

        B400_053: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B400_054;
            case LT: state = state.DIV; goto B400_052;
            case RD: state = state.NOT; goto B400_054;
            case RT: state = state.DIV; goto B400_052;
            default: return Exit;
        }

        B400_054: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B400_057;
            case LT: state = state.ROL; goto B400_053;
            case RD: state = state.PSH(3); goto B400_057;
            case RT: state = state.ROL; goto B400_053;
            default: return Exit;
        }

        B400_057: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B400_058;
            case LT: state = state.POP; goto B400_054;
            case RD: state = state.MUL; goto B400_058;
            case RT: state = state.POP; goto B400_054;
            default: return Exit;
        }

        B400_058: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B400_059;
            case LT: state = state.OUTi; goto B400_057;
            case RD: state = state.DUP; goto B400_059;
            case RT: state = state.OUTi; goto B400_057;
            default: return Exit;
        }

        B400_059: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B400_060;
            case LT: state = state.DIV; goto B400_058;
            case RD: state = state.ROT; goto B400_060;
            case RT: state = state.DIV; goto B400_058;
            default: return Exit;
        }

        B400_060: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B401_060;
            case LD: state = state.POP; goto B400_061;
            case LL: state = state.RT.SWI; goto B400_059;
            case LT: state = state.SWI; goto B400_059;
            case RR: state = state.ROT; goto B401_060;
            case RD: state = state.POP; goto B400_061;
            case RL: state = state.LT.SWI; goto B400_059;
            case RT: state = state.SWI; goto B400_059;
            default: return Exit;
        }

        B400_061: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B400_047;
            case RD: state = state.PSH(2); goto B400_047;
            default: return Exit;
        }

        B401_060: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.LL.SWI; goto B400_060;
            case LD: state = state.RL.SWI; goto B400_060;
            case LL: state = state.SWI; goto B400_060;
            case LT: state = state.RT.POP; goto B402_059;
            case RR: state = state.RL.SWI; goto B400_060;
            case RD: state = state.LL.SWI; goto B400_060;
            case RL: state = state.SWI; goto B400_060;
            case RT: state = state.POP; goto B402_059;
            default: return Exit;
        }

        B402_059: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RT: state = state.LR.PSH(1); goto B404_045;
            default: return Exit;
        }

        B404_045: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LR: state = state.PSH(2); goto B405_045;
            case LL: state = state.RL.POP; goto B403_045;
            case RR: state = state.LR.PSH(2); goto B405_045;
            case RL: state = state.POP; goto B403_045;
            default: return Exit;
        }

        B405_045: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B406_045;
            case LL: state = state.POP; goto B404_045;
            case RL: state = state.POP; goto B404_045;
            default: return Exit;
        }

        B406_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B409_045;
            default: return Exit;
        }

        B409_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B410_045;
            case LL: state = state.POP; goto B408_045;
            case RR: state = state.ADD; goto B410_045;
            case RL: state = state.POP; goto B408_045;
            default: return Exit;
        }

        B410_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.DUP; goto B411_045;
            case LL: state = state.INc; goto B409_045;
            case RR: state = state.DUP; goto B411_045;
            case RL: state = state.INc; goto B409_045;
            default: return Exit;
        }

        B411_045: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B412_045;
            case LL: state = state.DIV; goto B410_045;
            case RR: state = state.DUP; goto B412_045;
            case RL: state = state.DIV; goto B410_045;
            default: return Exit;
        }

        B412_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B413_045;
            case LL: state = state.DIV; goto B411_045;
            case RR: state = state.NOT; goto B413_045;
            case RL: state = state.DIV; goto B411_045;
            default: return Exit;
        }

        B413_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROT; goto B414_045;
            case LL: state = state.ROL; goto B412_045;
            case RR: state = state.ROT; goto B414_045;
            case RL: state = state.ROL; goto B412_045;
            default: return Exit;
        }

        B414_045: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B415_045;
            case LD: state = state.POP; goto B414_046;
            case LL: state = state.SWI; goto B413_045;
            case LT: state = state.RR.PSH(1); goto B415_045;
            case RR: state = state.PSH(1); goto B415_045;
            case RD: state = state.POP; goto B414_046;
            case RL: state = state.SWI; goto B413_045;
            case RT: state = state.LR.PSH(1); goto B415_045;
            default: return Exit;
        }

        B400_045: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.LD.PSH(2); goto B400_047;
            case RT: state = state.RD.PSH(2); goto B400_047;
            default: return Exit;
        }

        B415_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B416_045;
            case LL: state = state.POP; goto B414_045;
            case RR: state = state.SUB; goto B416_045;
            case RL: state = state.POP; goto B414_045;
            default: return Exit;
        }

        B414_046: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(10); goto B329_092;
            case RD: state = state.LD.PSH(10); goto B329_092;
            default: return Exit;
        }

        B416_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B417_045;
            case LL: state = state.OUTc; goto B415_045;
            case RR: state = state.DUP; goto B417_045;
            case RL: state = state.OUTc; goto B415_045;
            default: return Exit;
        }

        B329_092: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.DUP; goto B308_093;
            default: return Exit;
        }

        B417_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B418_045;
            case LL: state = state.DIV; goto B416_045;
            case RR: state = state.NOT; goto B418_045;
            case RL: state = state.DIV; goto B416_045;
            default: return Exit;
        }

        B308_093: switch (state.PT) // Size = 22, Colour = blue
        {
            case LD: state = state.PSH(22); goto B329_094;
            default: return Exit;
        }

        B418_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B419_045;
            case LL: state = state.ROL; goto B417_045;
            case RR: state = state.ROT; goto B419_045;
            case RL: state = state.ROL; goto B417_045;
            default: return Exit;
        }

        B329_094: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.ADD; goto B308_095;
            default: return Exit;
        }

        B419_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B420_045;
            case LD: state = state.POP; goto B419_046;
            case LL: state = state.SWI; goto B418_045;
            case LT: state = state.RR.PSH(1); goto B420_045;
            case RR: state = state.PSH(1); goto B420_045;
            case RD: state = state.POP; goto B419_046;
            case RL: state = state.SWI; goto B418_045;
            case RT: state = state.LR.PSH(1); goto B420_045;
            default: return Exit;
        }

        B308_095: switch (state.PT) // Size = 22, Colour = dark magenta
        {
            case LD: state = state.PSH(22); goto B307_096;
            default: return Exit;
        }

        B420_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B421_045;
            case LL: state = state.POP; goto B419_045;
            case RR: state = state.SUB; goto B421_045;
            case RL: state = state.POP; goto B419_045;
            default: return Exit;
        }

        B419_046: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(9); goto B338_092;
            case RD: state = state.PSH(9); goto B338_092;
            default: return Exit;
        }

        B307_096: switch (state.PT) // Size = 23, Colour = light magenta
        {
            case LD: state = state.PSH(23); goto B326_097;
            default: return Exit;
        }

        B408_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LL: state = state.OUTc; goto B405_045;
            case RL: state = state.OUTc; goto B405_045;
            default: return Exit;
        }

        B421_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B422_045;
            case LL: state = state.OUTc; goto B420_045;
            case RR: state = state.DUP; goto B422_045;
            case RL: state = state.OUTc; goto B420_045;
            default: return Exit;
        }

        B338_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B360_093;
            case RD: state = state.LD.PSH(23); goto B360_093;
            default: return Exit;
        }

        B326_097: switch (state.PT) // Size = 4, Colour = magenta
        {
            case LD: state = state.PSH(4); goto B329_098;
            default: return Exit;
        }

        B422_045: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.NOT; goto B423_045;
            case LL: state = state.DIV; goto B421_045;
            case RR: state = state.NOT; goto B423_045;
            case RL: state = state.DIV; goto B421_045;
            default: return Exit;
        }

        B360_093: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ADD; goto B354_094;
            default: return Exit;
        }

        B329_098: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.MUL; goto B329_099;
            default: return Exit;
        }

        B423_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROT; goto B424_045;
            case LL: state = state.ROL; goto B422_045;
            case RR: state = state.ROT; goto B424_045;
            case RL: state = state.ROL; goto B422_045;
            default: return Exit;
        }

        B354_094: switch (state.PT) // Size = 7, Colour = dark yellow
        {
            case LD: state = state.PSH(7); goto B338_095;
            default: return Exit;
        }

        B329_099: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B329_100;
            default: return Exit;
        }

        B403_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case RL: state = state.RR.PSH(1); goto B404_045;
            default: return Exit;
        }

        B424_045: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B425_045;
            case LD: state = state.POP; goto B424_046;
            case LL: state = state.SWI; goto B423_045;
            case LT: state = state.RR.PSH(1); goto B425_045;
            case RR: state = state.PSH(1); goto B425_045;
            case RD: state = state.POP; goto B424_046;
            case RL: state = state.SWI; goto B423_045;
            case RT: state = state.LR.PSH(1); goto B425_045;
            default: return Exit;
        }

        B338_095: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LD: state = state.PSH(23); goto B358_096;
            default: return Exit;
        }

        B329_100: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.RL.DUP; goto B312_101;
            default: return Exit;
        }

        B425_045: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.SUB; goto B426_045;
            case LL: state = state.POP; goto B424_045;
            case RR: state = state.SUB; goto B426_045;
            case RL: state = state.POP; goto B424_045;
            default: return Exit;
        }

        B424_046: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.PSH(9); goto B369_092;
            case RD: state = state.PSH(9); goto B369_092;
            default: return Exit;
        }

        B358_096: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LD: state = state.PSH(3); goto B360_097;
            default: return Exit;
        }

        B312_101: switch (state.PT) // Size = 13, Colour = light blue
        {
            case RL: state = state.PSH(13); goto B311_101;
            default: return Exit;
        }

        B426_045: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B427_045;
            case LL: state = state.OUTc; goto B425_045;
            case RR: state = state.DUP; goto B427_045;
            case RL: state = state.OUTc; goto B425_045;
            default: return Exit;
        }

        B369_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B391_093;
            case RD: state = state.LD.PSH(23); goto B391_093;
            default: return Exit;
        }

        B360_097: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.MUL; goto B360_098;
            default: return Exit;
        }

        B311_101: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B309_101;
            default: return Exit;
        }

        B427_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B428_045;
            case LL: state = state.DIV; goto B426_045;
            case RR: state = state.NOT; goto B428_045;
            case RL: state = state.DIV; goto B426_045;
            default: return Exit;
        }

        B391_093: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ADD; goto B391_094;
            default: return Exit;
        }

        B360_098: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.ADD; goto B360_099;
            default: return Exit;
        }

        B309_101: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B308_101;
            default: return Exit;
        }

        B428_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROT; goto B429_045;
            case LL: state = state.ROL; goto B427_045;
            case RR: state = state.ROT; goto B429_045;
            case RL: state = state.ROL; goto B427_045;
            default: return Exit;
        }

        B391_094: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.DUP; goto B376_095;
            default: return Exit;
        }

        B360_099: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.RL.DUP; goto B343_100;
            default: return Exit;
        }

        B308_101: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B307_101;
            default: return Exit;
        }

        B429_045: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B430_045;
            case LD: state = state.POP; goto B429_046;
            case LL: state = state.SWI; goto B428_045;
            case LT: state = state.RR.PSH(1); goto B430_045;
            case RR: state = state.PSH(1); goto B430_045;
            case RD: state = state.POP; goto B429_046;
            case RL: state = state.SWI; goto B428_045;
            case RT: state = state.LR.PSH(1); goto B430_045;
            default: return Exit;
        }

        B376_095: switch (state.PT) // Size = 16, Colour = dark magenta
        {
            case LD: state = state.PSH(16); goto B391_096;
            default: return Exit;
        }

        B343_100: switch (state.PT) // Size = 4, Colour = light blue
        {
            case RL: state = state.PSH(4); goto B342_100;
            default: return Exit;
        }

        B307_101: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B311_103;
            case RD: state = state.LR.DUP; goto B311_103;
            case RL: state = state.RR.DUP; goto B311_103;
            case RT: state = state.LR.DUP; goto B311_103;
            default: return Exit;
        }

        B430_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B431_045;
            case LL: state = state.POP; goto B429_045;
            case RR: state = state.SUB; goto B431_045;
            case RL: state = state.POP; goto B429_045;
            default: return Exit;
        }

        B429_046: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(10); goto B400_092;
            case RD: state = state.PSH(10); goto B400_092;
            default: return Exit;
        }

        B391_096: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ADD; goto B391_097;
            default: return Exit;
        }

        B342_100: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.ADD; goto B340_100;
            default: return Exit;
        }

        B311_103: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B312_103;
            case RR: state = state.PSH(1); goto B312_103;
            default: return Exit;
        }

        B431_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B432_045;
            case LL: state = state.OUTc; goto B430_045;
            case RR: state = state.DUP; goto B432_045;
            case RL: state = state.OUTc; goto B430_045;
            default: return Exit;
        }

        B400_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B421_093;
            case RD: state = state.LD.PSH(23); goto B421_093;
            default: return Exit;
        }

        B391_097: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.RL.DUP; goto B374_098;
            default: return Exit;
        }

        B340_100: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RL: state = state.PSH(2); goto B339_100;
            default: return Exit;
        }

        B312_103: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B313_103;
            case RR: state = state.SUB; goto B313_103;
            default: return Exit;
        }

        B432_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B433_045;
            case LL: state = state.DIV; goto B431_045;
            case RR: state = state.NOT; goto B433_045;
            case RL: state = state.DIV; goto B431_045;
            default: return Exit;
        }

        B421_093: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B422_094;
            default: return Exit;
        }

        B374_098: switch (state.PT) // Size = 2, Colour = light blue
        {
            case RL: state = state.PSH(2); goto B373_098;
            default: return Exit;
        }

        B339_100: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RL: state = state.ROT; goto B338_100;
            default: return Exit;
        }

        B313_103: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B314_103;
            case RR: state = state.DUP; goto B314_103;
            default: return Exit;
        }

        B433_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B434_045;
            case LL: state = state.ROL; goto B432_045;
            case RR: state = state.ROT; goto B434_045;
            case RL: state = state.ROL; goto B432_045;
            default: return Exit;
        }

        B422_094: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.MUL; goto B401_095;
            default: return Exit;
        }

        B373_098: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B371_098;
            default: return Exit;
        }

        B338_100: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.DUP; goto B342_102;
            case RD: state = state.LR.DUP; goto B342_102;
            case RL: state = state.RR.DUP; goto B342_102;
            case RT: state = state.LR.DUP; goto B342_102;
            default: return Exit;
        }

        B314_103: switch (state.PT) // Size = 10, Colour = light magenta
        {
            case LR: state = state.PSH(10); goto B324_103;
            case RR: state = state.PSH(10); goto B324_103;
            default: return Exit;
        }

        B434_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B435_045;
            case LD: state = state.POP; goto B434_046;
            case LL: state = state.SWI; goto B433_045;
            case LT: state = state.RR.PSH(1); goto B435_045;
            case RR: state = state.PSH(1); goto B435_045;
            case RD: state = state.POP; goto B434_046;
            case RL: state = state.SWI; goto B433_045;
            case RT: state = state.LR.PSH(1); goto B435_045;
            default: return Exit;
        }

        B401_095: switch (state.PT) // Size = 22, Colour = dark yellow
        {
            case LD: state = state.PSH(22); goto B400_096;
            default: return Exit;
        }

        B371_098: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B370_098;
            default: return Exit;
        }

        B342_102: switch (state.PT) // Size = 9, Colour = light red
        {
            case LR: state = state.PSH(9); goto B351_102;
            case RR: state = state.PSH(9); goto B351_102;
            default: return Exit;
        }

        B324_103: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ADD; goto B325_103;
            case RR: state = state.ADD; goto B325_103;
            default: return Exit;
        }

        B435_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B436_045;
            case LL: state = state.POP; goto B434_045;
            case RR: state = state.SUB; goto B436_045;
            case RL: state = state.POP; goto B434_045;
            default: return Exit;
        }

        B434_046: switch (state.PT) // Size = 1, Colour = light red
        {
            default: return Exit;
        }

        B400_096: switch (state.PT) // Size = 23, Colour = light yellow
        {
            case LD: state = state.PSH(23); goto B419_097;
            default: return Exit;
        }

        B370_098: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B369_098;
            default: return Exit;
        }

        B351_102: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B352_102;
            case RR: state = state.SUB; goto B352_102;
            default: return Exit;
        }

        B325_103: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.RD.DUP; goto B323_105;
            case RR: state = state.LD.DUP; goto B323_105;
            default: return Exit;
        }

        B436_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.POP; goto B437_045;
            case LL: state = state.OUTc; goto B435_045;
            case RR: state = state.POP; goto B437_045;
            case RL: state = state.OUTc; goto B435_045;
            default: return Exit;
        }

        B419_097: switch (state.PT) // Size = 4, Colour = yellow
        {
            case LD: state = state.PSH(4); goto B422_098;
            default: return Exit;
        }

        B369_098: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B373_100;
            case RD: state = state.LR.DUP; goto B373_100;
            case RL: state = state.RR.DUP; goto B373_100;
            case RT: state = state.LR.DUP; goto B373_100;
            default: return Exit;
        }

        B352_102: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.RD.PSH(9); goto B338_105;
            case RR: state = state.LD.PSH(9); goto B338_105;
            default: return Exit;
        }

        B323_105: switch (state.PT) // Size = 7, Colour = magenta
        {
            case LD: state = state.PSH(7); goto B329_106;
            case RD: state = state.LD.PSH(7); goto B329_106;
            default: return Exit;
        }

        B437_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.LL.PSH(1); goto B436_045;
            case RR: state = state.RL.PSH(1); goto B436_045;
            default: return Exit;
        }

        B422_098: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.MUL; goto B422_099;
            default: return Exit;
        }

        B373_100: switch (state.PT) // Size = 4, Colour = red
        {
            case LR: state = state.PSH(4); goto B377_100;
            case RR: state = state.PSH(4); goto B377_100;
            default: return Exit;
        }

        B338_105: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LD: state = state.PSH(23); goto B360_106;
            case RD: state = state.LD.PSH(23); goto B360_106;
            default: return Exit;
        }

        B329_106: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ADD; goto B321_107;
            default: return Exit;
        }

        B422_099: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.ADD; goto B422_100;
            default: return Exit;
        }

        B377_100: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B378_100;
            case RR: state = state.ADD; goto B378_100;
            default: return Exit;
        }

        B360_106: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ADD; goto B345_107;
            default: return Exit;
        }

        B321_107: switch (state.PT) // Size = 9, Colour = dark red
        {
            case LD: state = state.PSH(9); goto B307_108;
            default: return Exit;
        }

        B422_100: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B410_101;
            default: return Exit;
        }

        B378_100: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.RD.DUP; goto B374_102;
            case RR: state = state.LD.DUP; goto B374_102;
            default: return Exit;
        }

        B345_107: switch (state.PT) // Size = 16, Colour = light blue
        {
            case LD: state = state.PSH(16); goto B338_108;
            default: return Exit;
        }

        B307_108: switch (state.PT) // Size = 23, Colour = light red
        {
            case LD: state = state.PSH(23); goto B329_109;
            default: return Exit;
        }

        B410_101: switch (state.PT) // Size = 13, Colour = yellow
        {
            case LD: state = state.PSH(13); goto B422_102;
            default: return Exit;
        }

        B374_102: switch (state.PT) // Size = 18, Colour = light blue
        {
            case LD: state = state.PSH(18); goto B391_103;
            case RD: state = state.LD.PSH(18); goto B391_103;
            default: return Exit;
        }

        B338_108: switch (state.PT) // Size = 23, Colour = blue
        {
            case LD: state = state.PSH(23); goto B358_109;
            default: return Exit;
        }

        B329_109: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B322_110;
            default: return Exit;
        }

        B422_102: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.SUB; goto B422_103;
            default: return Exit;
        }

        B391_103: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B374_104;
            default: return Exit;
        }

        B358_109: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LD: state = state.PSH(3); goto B360_110;
            default: return Exit;
        }

        B322_110: switch (state.PT) // Size = 8, Colour = yellow
        {
            case LD: state = state.PSH(8); goto B307_111;
            default: return Exit;
        }

        B422_103: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.DUP; goto B408_104;
            default: return Exit;
        }

        B374_104: switch (state.PT) // Size = 18, Colour = dark magenta
        {
            case LD: state = state.PSH(18); goto B369_105;
            default: return Exit;
        }

        B360_110: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.MUL; goto B360_111;
            default: return Exit;
        }

        B307_111: switch (state.PT) // Size = 23, Colour = dark yellow
        {
            case LD: state = state.PSH(23); goto B326_112;
            default: return Exit;
        }

        B408_104: switch (state.PT) // Size = 15, Colour = light red
        {
            case LD: state = state.PSH(15); goto B422_105;
            default: return Exit;
        }

        B369_105: switch (state.PT) // Size = 23, Colour = light magenta
        {
            case LD: state = state.PSH(23); goto B388_106;
            default: return Exit;
        }

        B360_111: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ADD; goto B360_112;
            default: return Exit;
        }

        B326_112: switch (state.PT) // Size = 4, Colour = light yellow
        {
            case LD: state = state.PSH(4); goto B329_113;
            default: return Exit;
        }

        B422_105: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B422_106;
            default: return Exit;
        }

        B388_106: switch (state.PT) // Size = 4, Colour = magenta
        {
            case LD: state = state.PSH(4); goto B391_107;
            default: return Exit;
        }

        B360_112: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.RL.DUP; goto B343_113;
            default: return Exit;
        }

        B329_113: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.MUL; goto B329_114;
            default: return Exit;
        }

        B422_106: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.DUP; goto B404_107;
            default: return Exit;
        }

        B391_107: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.MUL; goto B391_108;
            default: return Exit;
        }

        B343_113: switch (state.PT) // Size = 7, Colour = light blue
        {
            case RL: state = state.PSH(7); goto B342_113;
            default: return Exit;
        }

        B329_114: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.ADD; goto B329_115;
            default: return Exit;
        }

        B404_107: switch (state.PT) // Size = 19, Colour = magenta
        {
            case LD: state = state.PSH(19); goto B422_108;
            default: return Exit;
        }

        B391_108: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B391_109;
            default: return Exit;
        }

        B342_113: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B340_113;
            default: return Exit;
        }

        B329_115: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.DUP; goto B329_116;
            default: return Exit;
        }

        B422_108: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.SUB; goto B422_109;
            default: return Exit;
        }

        B391_109: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.RL.DUP; goto B374_110;
            default: return Exit;
        }

        B340_113: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B339_113;
            default: return Exit;
        }

        B329_116: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.PSH(1); goto B329_117;
            default: return Exit;
        }

        B422_109: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.DUP; goto B412_110;
            default: return Exit;
        }

        B374_110: switch (state.PT) // Size = 1, Colour = light blue
        {
            case RL: state = state.PSH(1); goto B373_110;
            default: return Exit;
        }

        B339_113: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B338_113;
            default: return Exit;
        }

        B329_117: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ADD; goto B329_118;
            default: return Exit;
        }

        B412_110: switch (state.PT) // Size = 11, Colour = light blue
        {
            case LD: state = state.PSH(11); goto B422_111;
            default: return Exit;
        }

        B373_110: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.ADD; goto B371_110;
            default: return Exit;
        }

        B338_113: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B342_115;
            case RD: state = state.LR.DUP; goto B342_115;
            case RL: state = state.RR.DUP; goto B342_115;
            case RT: state = state.LR.DUP; goto B342_115;
            default: return Exit;
        }

        B329_118: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.DUP; goto B316_119;
            default: return Exit;
        }

        B422_111: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B414_112;
            default: return Exit;
        }

        B371_110: switch (state.PT) // Size = 2, Colour = magenta
        {
            case RL: state = state.PSH(2); goto B370_110;
            default: return Exit;
        }

        B342_115: switch (state.PT) // Size = 7, Colour = red
        {
            case LR: state = state.PSH(7); goto B349_115;
            case RR: state = state.PSH(7); goto B349_115;
            default: return Exit;
        }

        B316_119: switch (state.PT) // Size = 14, Colour = red
        {
            case LD: state = state.PSH(14); goto B329_120;
            default: return Exit;
        }

        B414_112: switch (state.PT) // Size = 9, Colour = magenta
        {
            case LD: state = state.PSH(9); goto B400_113;
            default: return Exit;
        }

        B370_110: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case RL: state = state.ROT; goto B369_110;
            default: return Exit;
        }

        B349_115: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B350_115;
            case RR: state = state.SUB; goto B350_115;
            default: return Exit;
        }

        B329_120: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ADD; goto B329_121;
            default: return Exit;
        }

        B400_113: switch (state.PT) // Size = 23, Colour = dark magenta
        {
            case LD: state = state.PSH(23); goto B422_114;
            default: return Exit;
        }

        B369_110: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.DUP; goto B373_112;
            case RD: state = state.LR.DUP; goto B373_112;
            case RL: state = state.RR.DUP; goto B373_112;
            case RT: state = state.LR.DUP; goto B373_112;
            default: return Exit;
        }

        B350_115: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.RD.PSH(22); goto B338_118;
            case RR: state = state.LD.PSH(22); goto B338_118;
            default: return Exit;
        }

        B329_121: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.RL.DUP; goto B312_122;
            default: return Exit;
        }

        B422_114: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ADD; goto B401_115;
            default: return Exit;
        }

        B373_112: switch (state.PT) // Size = 6, Colour = light red
        {
            case LR: state = state.PSH(6); goto B379_112;
            case RR: state = state.PSH(6); goto B379_112;
            default: return Exit;
        }

        B338_118: switch (state.PT) // Size = 23, Colour = light red
        {
            case LD: state = state.PSH(23); goto B360_119;
            case RD: state = state.LD.PSH(23); goto B360_119;
            default: return Exit;
        }

        B312_122: switch (state.PT) // Size = 5, Colour = light blue
        {
            case RL: state = state.PSH(5); goto B311_122;
            default: return Exit;
        }

        B401_115: switch (state.PT) // Size = 22, Colour = light red
        {
            case LD: state = state.PSH(22); goto B400_116;
            default: return Exit;
        }

        B379_112: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B380_112;
            case RR: state = state.SUB; goto B380_112;
            default: return Exit;
        }

        B360_119: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B360_120;
            default: return Exit;
        }

        B311_122: switch (state.PT) // Size = 1, Colour = blue
        {
            case RL: state = state.SUB; goto B309_122;
            default: return Exit;
        }

        B400_116: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B419_117;
            default: return Exit;
        }

        B380_112: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.LL.DUP; goto B374_114;
            case RR: state = state.RL.DUP; goto B374_114;
            default: return Exit;
        }

        B360_120: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.DUP; goto B339_121;
            default: return Exit;
        }

        B309_122: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case RL: state = state.PSH(2); goto B308_122;
            default: return Exit;
        }

        B419_117: switch (state.PT) // Size = 4, Colour = dark red
        {
            case LD: state = state.PSH(4); goto B422_118;
            default: return Exit;
        }

        B374_114: switch (state.PT) // Size = 10, Colour = light blue
        {
            case LL: state = state.PSH(10); goto B373_114;
            case RL: state = state.PSH(10); goto B373_114;
            default: return Exit;
        }

        B339_121: switch (state.PT) // Size = 22, Colour = magenta
        {
            case LD: state = state.PSH(22); goto B360_122;
            default: return Exit;
        }

        B308_122: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case RL: state = state.ROT; goto B307_122;
            default: return Exit;
        }

        B422_118: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.MUL; goto B422_119;
            default: return Exit;
        }

        B373_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LL: state = state.ADD; goto B371_114;
            case RL: state = state.ADD; goto B371_114;
            default: return Exit;
        }

        B360_122: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ADD; goto B360_123;
            default: return Exit;
        }

        B307_122: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B311_124;
            case RD: state = state.LR.DUP; goto B311_124;
            case RL: state = state.RR.DUP; goto B311_124;
            case RT: state = state.LR.DUP; goto B311_124;
            default: return Exit;
        }

        B422_119: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.ADD; goto B422_120;
            default: return Exit;
        }

        B371_114: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LL: state = state.PSH(2); goto B370_114;
            case RL: state = state.PSH(2); goto B370_114;
            default: return Exit;
        }

        B360_123: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.DUP; goto B352_124;
            default: return Exit;
        }

        B311_124: switch (state.PT) // Size = 9, Colour = red
        {
            case LR: state = state.PSH(9); goto B320_124;
            case RR: state = state.PSH(9); goto B320_124;
            default: return Exit;
        }

        B422_120: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.DUP; goto B420_121;
            default: return Exit;
        }

        B370_114: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LL: state = state.ROT; goto B369_114;
            case RL: state = state.ROT; goto B369_114;
            default: return Exit;
        }

        B352_124: switch (state.PT) // Size = 9, Colour = dark blue
        {
            case LD: state = state.PSH(9); goto B338_125;
            default: return Exit;
        }

        B320_124: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B321_124;
            case RR: state = state.SUB; goto B321_124;
            default: return Exit;
        }

        B420_121: switch (state.PT) // Size = 3, Colour = dark red
        {
            case LD: state = state.PSH(3); goto B422_122;
            default: return Exit;
        }

        B369_114: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.DUP; goto B373_116;
            case LD: state = state.RR.DUP; goto B373_116;
            case LL: state = state.LR.DUP; goto B373_116;
            case LT: state = state.RR.DUP; goto B373_116;
            case RR: state = state.DUP; goto B373_116;
            case RD: state = state.LR.DUP; goto B373_116;
            case RL: state = state.RR.DUP; goto B373_116;
            case RT: state = state.LR.DUP; goto B373_116;
            default: return Exit;
        }

        B338_125: switch (state.PT) // Size = 23, Colour = light blue
        {
            case LD: state = state.PSH(23); goto B360_126;
            default: return Exit;
        }

        B321_124: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B322_124;
            case RR: state = state.DUP; goto B322_124;
            default: return Exit;
        }

        B422_122: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B413_123;
            default: return Exit;
        }

        B373_116: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.PSH(1); goto B374_116;
            case RR: state = state.PSH(1); goto B374_116;
            default: return Exit;
        }

        B360_126: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B352_127;
            default: return Exit;
        }

        B322_124: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LR: state = state.PSH(2); goto B324_124;
            case RR: state = state.PSH(2); goto B324_124;
            default: return Exit;
        }

        B413_123: switch (state.PT) // Size = 10, Colour = yellow
        {
            case LD: state = state.PSH(10); goto B422_124;
            default: return Exit;
        }

        B374_116: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B375_116;
            case RR: state = state.SUB; goto B375_116;
            default: return Exit;
        }

        B352_127: switch (state.PT) // Size = 9, Colour = magenta
        {
            case LD: state = state.PSH(9); goto B338_128;
            default: return Exit;
        }

        B324_124: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.SUB; goto B325_124;
            case RR: state = state.SUB; goto B325_124;
            default: return Exit;
        }

        B422_124: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.RL.PSH(2); goto B420_127;
            default: return Exit;
        }

        B375_116: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.RD.DUP; goto B379_118;
            case RR: state = state.LD.DUP; goto B379_118;
            default: return Exit;
        }

        B338_128: switch (state.PT) // Size = 23, Colour = dark magenta
        {
            case LD: state = state.PSH(23); goto B357_129;
            default: return Exit;
        }

        B325_124: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.RD.DUP; goto B324_126;
            case RR: state = state.LD.DUP; goto B324_126;
            default: return Exit;
        }

        B420_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B421_127;
            case LL: state = state.PSH(1); goto B419_127;
            case RR: state = state.POP; goto B421_127;
            case RL: state = state.PSH(1); goto B419_127;
            default: return Exit;
        }

        B379_118: switch (state.PT) // Size = 13, Colour = magenta
        {
            case LD: state = state.PSH(13); goto B391_119;
            case RD: state = state.LD.PSH(13); goto B391_119;
            default: return Exit;
        }

        B357_129: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LD: state = state.PSH(4); goto B360_130;
            default: return Exit;
        }

        B324_126: switch (state.PT) // Size = 6, Colour = dark magenta
        {
            case LD: state = state.PSH(6); goto B329_127;
            case RD: state = state.LD.PSH(6); goto B329_127;
            default: return Exit;
        }

        B419_127: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B420_127;
            case LL: state = state.ROL; goto B418_127;
            case RR: state = state.POP; goto B420_127;
            case RL: state = state.ROL; goto B418_127;
            default: return Exit;
        }

        B391_119: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.SUB; goto B391_120;
            default: return Exit;
        }

        B360_130: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.MUL; goto B360_131;
            default: return Exit;
        }

        B329_127: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ADD; goto B329_128;
            default: return Exit;
        }

        B418_127: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B419_127;
            case LL: state = state.OUTc; goto B417_127;
            case RR: state = state.NOT; goto B419_127;
            case RL: state = state.OUTc; goto B417_127;
            default: return Exit;
        }

        B391_120: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.DUP; goto B375_121;
            default: return Exit;
        }

        B360_131: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.ADD; goto B360_132;
            default: return Exit;
        }

        B329_128: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.DUP; goto B327_129;
            default: return Exit;
        }

        B417_127: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B418_127;
            case LL: state = state.PSH(1); goto B416_127;
            case RR: state = state.SUB; goto B418_127;
            case RL: state = state.PSH(1); goto B416_127;
            default: return Exit;
        }

        B375_121: switch (state.PT) // Size = 17, Colour = light blue
        {
            case LD: state = state.PSH(17); goto B391_122;
            default: return Exit;
        }

        B360_132: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.DUP; goto B358_133;
            default: return Exit;
        }

        B327_129: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B329_130;
            default: return Exit;
        }

        B416_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B417_127;
            case LL: state = state.SUB; goto B415_127;
            case RR: state = state.POP; goto B417_127;
            case RL: state = state.SUB; goto B415_127;
            default: return Exit;
        }

        B391_122: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B380_123;
            default: return Exit;
        }

        B358_133: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LD: state = state.PSH(3); goto B360_134;
            default: return Exit;
        }

        B329_130: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B314_131;
            default: return Exit;
        }

        B415_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B416_127;
            case LL: state = state.DUP; goto B414_127;
            case RR: state = state.OUTc; goto B416_127;
            case RL: state = state.DUP; goto B414_127;
            default: return Exit;
        }

        B380_123: switch (state.PT) // Size = 12, Colour = magenta
        {
            case LD: state = state.PSH(12); goto B391_124;
            default: return Exit;
        }

        B360_134: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ADD; goto B360_135;
            default: return Exit;
        }

        B314_131: switch (state.PT) // Size = 16, Colour = magenta
        {
            case LD: state = state.PSH(16); goto B329_132;
            default: return Exit;
        }

        B414_127: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B415_127;
            case LL: state = state.NOT; goto B411_127;
            case RR: state = state.DIV; goto B415_127;
            case RL: state = state.NOT; goto B411_127;
            default: return Exit;
        }

        B391_124: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.RL.PSH(2); goto B389_127;
            default: return Exit;
        }

        B360_135: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.DUP; goto B349_136;
            default: return Exit;
        }

        B329_132: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.RL.PSH(2); goto B327_135;
            default: return Exit;
        }

        B411_127: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B414_127;
            case LL: state = state.PSH(3); goto B410_127;
            case RR: state = state.ROL; goto B414_127;
            case RL: state = state.PSH(3); goto B410_127;
            default: return Exit;
        }

        B389_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B390_127;
            case LL: state = state.PSH(1); goto B388_127;
            case RR: state = state.POP; goto B390_127;
            case RL: state = state.PSH(1); goto B388_127;
            default: return Exit;
        }

        B349_136: switch (state.PT) // Size = 12, Colour = blue
        {
            case LD: state = state.PSH(12); goto B360_137;
            default: return Exit;
        }

        B327_135: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B328_135;
            case LL: state = state.PSH(1); goto B326_135;
            case RR: state = state.POP; goto B328_135;
            case RL: state = state.PSH(1); goto B326_135;
            default: return Exit;
        }

        B410_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B411_127;
            case LL: state = state.MUL; goto B409_127;
            case RR: state = state.POP; goto B411_127;
            case RL: state = state.MUL; goto B409_127;
            default: return Exit;
        }

        B388_127: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B389_127;
            case LL: state = state.ROL; goto B387_127;
            case RR: state = state.POP; goto B389_127;
            case RL: state = state.ROL; goto B387_127;
            default: return Exit;
        }

        B360_137: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.ADD; goto B346_138;
            default: return Exit;
        }

        B326_135: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B327_135;
            case LL: state = state.ROL; goto B325_135;
            case RR: state = state.POP; goto B327_135;
            case RL: state = state.ROL; goto B325_135;
            default: return Exit;
        }

        B409_127: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B410_127;
            case LL: state = state.DUP; goto B408_127;
            case RR: state = state.OUTi; goto B410_127;
            case RL: state = state.DUP; goto B408_127;
            default: return Exit;
        }

        B387_127: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B388_127;
            case LL: state = state.OUTc; goto B386_127;
            case RR: state = state.NOT; goto B388_127;
            case RL: state = state.OUTc; goto B386_127;
            default: return Exit;
        }

        B346_138: switch (state.PT) // Size = 15, Colour = dark magenta
        {
            case LD: state = state.PSH(15); goto B360_139;
            default: return Exit;
        }

        B325_135: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B326_135;
            case LL: state = state.OUTc; goto B324_135;
            case RR: state = state.NOT; goto B326_135;
            case RL: state = state.OUTc; goto B324_135;
            default: return Exit;
        }

        B408_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B409_127;
            case LL: state = state.ROT; goto B407_127;
            case RR: state = state.DIV; goto B409_127;
            case RL: state = state.ROT; goto B407_127;
            default: return Exit;
        }

        B386_127: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B387_127;
            case LL: state = state.PSH(1); goto B385_127;
            case RR: state = state.SUB; goto B387_127;
            case RL: state = state.PSH(1); goto B385_127;
            default: return Exit;
        }

        B360_139: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.RL.PSH(2); goto B358_142;
            default: return Exit;
        }

        B324_135: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B325_135;
            case LL: state = state.PSH(1); goto B323_135;
            case RR: state = state.SUB; goto B325_135;
            case RL: state = state.PSH(1); goto B323_135;
            default: return Exit;
        }

        B407_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B408_127;
            case LD: state = state.ROT; goto B407_128;
            case LL: state = state.POP; goto B406_127;
            case LT: state = state.RR.SWI; goto B408_127;
            case RR: state = state.SWI; goto B408_127;
            case RD: state = state.ROT; goto B407_128;
            case RL: state = state.POP; goto B406_127;
            case RT: state = state.LR.SWI; goto B408_127;
            default: return Exit;
        }

        B385_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B386_127;
            case LL: state = state.SUB; goto B384_127;
            case RR: state = state.POP; goto B386_127;
            case RL: state = state.SUB; goto B384_127;
            default: return Exit;
        }

        B358_142: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B359_142;
            case LL: state = state.PSH(1); goto B357_142;
            case RR: state = state.POP; goto B359_142;
            case RL: state = state.PSH(1); goto B357_142;
            default: return Exit;
        }

        B323_135: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B324_135;
            case LL: state = state.SUB; goto B322_135;
            case RR: state = state.POP; goto B324_135;
            case RL: state = state.SUB; goto B322_135;
            default: return Exit;
        }

        B406_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B420_127;
            case RL: state = state.PSH(2); goto B420_127;
            default: return Exit;
        }

        B407_128: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.RR.POP; goto B408_129;
            case LD: state = state.LT.SWI; goto B407_127;
            case LL: state = state.RT.SWI; goto B407_127;
            case LT: state = state.SWI; goto B407_127;
            case RR: state = state.POP; goto B408_129;
            case RD: state = state.RT.SWI; goto B407_127;
            case RL: state = state.LT.SWI; goto B407_127;
            case RT: state = state.SWI; goto B407_127;
            default: return Exit;
        }

        B384_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B385_127;
            case LL: state = state.DUP; goto B383_127;
            case RR: state = state.OUTc; goto B385_127;
            case RL: state = state.DUP; goto B383_127;
            default: return Exit;
        }

        B357_142: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B358_142;
            case LL: state = state.ROL; goto B356_142;
            case RR: state = state.POP; goto B358_142;
            case RL: state = state.ROL; goto B356_142;
            default: return Exit;
        }

        B322_135: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B323_135;
            case LL: state = state.DUP; goto B321_135;
            case RR: state = state.OUTc; goto B323_135;
            case RL: state = state.DUP; goto B321_135;
            default: return Exit;
        }

        B408_129: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RR: state = state.RL.PSH(3); goto B417_133;
            default: return Exit;
        }

        B383_127: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B384_127;
            case LL: state = state.NOT; goto B380_127;
            case RR: state = state.DIV; goto B384_127;
            case RL: state = state.NOT; goto B380_127;
            default: return Exit;
        }

        B356_142: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B357_142;
            case LL: state = state.OUTc; goto B355_142;
            case RR: state = state.NOT; goto B357_142;
            case RL: state = state.OUTc; goto B355_142;
            default: return Exit;
        }

        B321_135: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B322_135;
            case LL: state = state.NOT; goto B318_135;
            case RR: state = state.DIV; goto B322_135;
            case RL: state = state.NOT; goto B318_135;
            default: return Exit;
        }

        B417_133: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B418_133;
            case LL: state = state.ROT; goto B416_133;
            case RR: state = state.POP; goto B418_133;
            case RL: state = state.ROT; goto B416_133;
            default: return Exit;
        }

        B380_127: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B383_127;
            case LL: state = state.PSH(3); goto B379_127;
            case RR: state = state.ROL; goto B383_127;
            case RL: state = state.PSH(3); goto B379_127;
            default: return Exit;
        }

        B355_142: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B356_142;
            case LL: state = state.PSH(1); goto B354_142;
            case RR: state = state.SUB; goto B356_142;
            case RL: state = state.PSH(1); goto B354_142;
            default: return Exit;
        }

        B318_135: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B321_135;
            case LL: state = state.PSH(3); goto B317_135;
            case RR: state = state.ROL; goto B321_135;
            case RL: state = state.PSH(3); goto B317_135;
            default: return Exit;
        }

        B416_133: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.SWI; goto B417_133;
            case LD: state = state.PSH(3); goto B416_136;
            case LL: state = state.LR.SWI; goto B417_133;
            case LT: state = state.LR.SWI; goto B417_133;
            case RR: state = state.LR.SWI; goto B417_133;
            case RD: state = state.PSH(3); goto B416_136;
            case RL: state = state.LR.SWI; goto B417_133;
            case RT: state = state.LR.SWI; goto B417_133;
            default: return Exit;
        }

        B379_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B380_127;
            case LL: state = state.MUL; goto B378_127;
            case RR: state = state.POP; goto B380_127;
            case RL: state = state.MUL; goto B378_127;
            default: return Exit;
        }

        B354_142: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B355_142;
            case LL: state = state.SUB; goto B353_142;
            case RR: state = state.POP; goto B355_142;
            case RL: state = state.SUB; goto B353_142;
            default: return Exit;
        }

        B317_135: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B318_135;
            case LL: state = state.MUL; goto B316_135;
            case RR: state = state.POP; goto B318_135;
            case RL: state = state.MUL; goto B316_135;
            default: return Exit;
        }

        B416_136: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B416_137;
            case LT: state = state.POP; goto B416_133;
            case RD: state = state.ROT; goto B416_137;
            case RT: state = state.POP; goto B416_133;
            default: return Exit;
        }

        B378_127: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B379_127;
            case LL: state = state.DUP; goto B377_127;
            case RR: state = state.OUTi; goto B379_127;
            case RL: state = state.DUP; goto B377_127;
            default: return Exit;
        }

        B353_142: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B354_142;
            case LL: state = state.DUP; goto B352_142;
            case RR: state = state.OUTc; goto B354_142;
            case RL: state = state.DUP; goto B352_142;
            default: return Exit;
        }

        B316_135: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B317_135;
            case LL: state = state.DUP; goto B315_135;
            case RR: state = state.OUTi; goto B317_135;
            case RL: state = state.DUP; goto B315_135;
            default: return Exit;
        }

        B418_133: switch (state.PT) // Size = 3, Colour = light red
        {
            case LR: state = state.LL.PSH(3); goto B417_133;
            case RR: state = state.RL.PSH(3); goto B417_133;
            default: return Exit;
        }

        B416_137: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B419_137;
            case LD: state = state.LT.SWI; goto B416_136;
            case LL: state = state.LT.SWI; goto B416_136;
            case LT: state = state.SWI; goto B416_136;
            case RR: state = state.PSH(3); goto B419_137;
            case RD: state = state.LT.SWI; goto B416_136;
            case RL: state = state.LT.SWI; goto B416_136;
            case RT: state = state.LT.SWI; goto B416_136;
            default: return Exit;
        }

        B377_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B378_127;
            case LL: state = state.ROT; goto B376_127;
            case RR: state = state.DIV; goto B378_127;
            case RL: state = state.ROT; goto B376_127;
            default: return Exit;
        }

        B352_142: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B353_142;
            case LL: state = state.NOT; goto B349_142;
            case RR: state = state.DIV; goto B353_142;
            case RL: state = state.NOT; goto B349_142;
            default: return Exit;
        }

        B315_135: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B316_135;
            case LL: state = state.ROT; goto B314_135;
            case RR: state = state.DIV; goto B316_135;
            case RL: state = state.ROT; goto B314_135;
            default: return Exit;
        }

        B419_137: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B428_137;
            case RR: state = state.ROT; goto B428_137;
            default: return Exit;
        }

        B376_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B377_127;
            case LD: state = state.ROT; goto B376_128;
            case LL: state = state.POP; goto B375_127;
            case LT: state = state.RR.SWI; goto B377_127;
            case RR: state = state.SWI; goto B377_127;
            case RD: state = state.ROT; goto B376_128;
            case RL: state = state.POP; goto B375_127;
            case RT: state = state.LR.SWI; goto B377_127;
            default: return Exit;
        }

        B349_142: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B352_142;
            case LL: state = state.PSH(3); goto B348_142;
            case RR: state = state.ROL; goto B352_142;
            case RL: state = state.PSH(3); goto B348_142;
            default: return Exit;
        }

        B314_135: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B315_135;
            case LD: state = state.ROT; goto B314_136;
            case LL: state = state.POP; goto B313_135;
            case LT: state = state.RR.SWI; goto B315_135;
            case RR: state = state.SWI; goto B315_135;
            case RD: state = state.ROT; goto B314_136;
            case RL: state = state.POP; goto B313_135;
            case RT: state = state.LR.SWI; goto B315_135;
            default: return Exit;
        }

        B428_137: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.LL.SWI; goto B427_137;
            case LD: state = state.RL.SWI; goto B427_137;
            case LL: state = state.SWI; goto B427_137;
            case RR: state = state.RL.SWI; goto B427_137;
            case RD: state = state.LL.SWI; goto B427_137;
            case RL: state = state.SWI; goto B427_137;
            default: return Exit;
        }

        B375_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B389_127;
            case RL: state = state.PSH(2); goto B389_127;
            default: return Exit;
        }

        B376_128: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.RR.POP; goto B377_129;
            case LD: state = state.LT.SWI; goto B376_127;
            case LL: state = state.RT.SWI; goto B376_127;
            case LT: state = state.SWI; goto B376_127;
            case RR: state = state.POP; goto B377_129;
            case RD: state = state.RT.SWI; goto B376_127;
            case RL: state = state.LT.SWI; goto B376_127;
            case RT: state = state.SWI; goto B376_127;
            default: return Exit;
        }

        B348_142: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B349_142;
            case LL: state = state.MUL; goto B347_142;
            case RR: state = state.POP; goto B349_142;
            case RL: state = state.MUL; goto B347_142;
            default: return Exit;
        }

        B313_135: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B327_135;
            case RL: state = state.PSH(2); goto B327_135;
            default: return Exit;
        }

        B314_136: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.RR.POP; goto B315_137;
            case LD: state = state.LT.SWI; goto B314_135;
            case LL: state = state.RT.SWI; goto B314_135;
            case LT: state = state.SWI; goto B314_135;
            case RR: state = state.POP; goto B315_137;
            case RD: state = state.RT.SWI; goto B314_135;
            case RL: state = state.LT.SWI; goto B314_135;
            case RT: state = state.SWI; goto B314_135;
            default: return Exit;
        }

        B427_137: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LL: state = state.POP; goto B416_137;
            case RL: state = state.POP; goto B416_137;
            default: return Exit;
        }

        B377_129: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RR: state = state.LD.PSH(1); goto B391_131;
            default: return Exit;
        }

        B347_142: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B348_142;
            case LL: state = state.DUP; goto B346_142;
            case RR: state = state.OUTi; goto B348_142;
            case RL: state = state.DUP; goto B346_142;
            default: return Exit;
        }

        B315_137: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RR: state = state.LD.PSH(1); goto B329_139;
            default: return Exit;
        }

        B391_131: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B391_132;
            case LT: state = state.POP; goto B391_130;
            case RD: state = state.ROT; goto B391_132;
            case RT: state = state.POP; goto B391_130;
            default: return Exit;
        }

        B346_142: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B347_142;
            case LL: state = state.ROT; goto B345_142;
            case RR: state = state.DIV; goto B347_142;
            case RL: state = state.ROT; goto B345_142;
            default: return Exit;
        }

        B329_139: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B329_140;
            case LT: state = state.POP; goto B329_138;
            case RD: state = state.ROT; goto B329_140;
            case RT: state = state.POP; goto B329_138;
            default: return Exit;
        }

        B391_132: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state.RR.PSH(1); goto B409_045;
            case LL: state = state.LR.PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B391_131;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state.LR.PSH(1); goto B409_045;
            case RL: state = state.RR.PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B391_131;
            default: return Exit;
        }

        B345_142: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B346_142;
            case LD: state = state.ROT; goto B345_143;
            case LL: state = state.POP; goto B344_142;
            case LT: state = state.RR.SWI; goto B346_142;
            case RR: state = state.SWI; goto B346_142;
            case RD: state = state.ROT; goto B345_143;
            case RL: state = state.POP; goto B344_142;
            case RT: state = state.LR.SWI; goto B346_142;
            default: return Exit;
        }

        B329_140: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state.RR.PSH(1); goto B409_045;
            case LL: state = state.LR.PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B329_139;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state.LR.PSH(1); goto B409_045;
            case RL: state = state.RR.PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B329_139;
            default: return Exit;
        }

        B421_127: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.LL.PSH(2); goto B420_127;
            case RR: state = state.RL.PSH(2); goto B420_127;
            default: return Exit;
        }

        B344_142: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B358_142;
            case RL: state = state.PSH(2); goto B358_142;
            default: return Exit;
        }

        B345_143: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.RR.POP; goto B346_144;
            case LD: state = state.LT.SWI; goto B345_142;
            case LL: state = state.RT.SWI; goto B345_142;
            case LT: state = state.SWI; goto B345_142;
            case RR: state = state.POP; goto B346_144;
            case RD: state = state.RT.SWI; goto B345_142;
            case RL: state = state.LT.SWI; goto B345_142;
            case RT: state = state.SWI; goto B345_142;
            default: return Exit;
        }

        B391_130: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state.LD.PSH(1); goto B391_131;
            case RT: state = state.RD.PSH(1); goto B391_131;
            default: return Exit;
        }

        B346_144: switch (state.PT) // Size = 1, Colour = cyan
        {
            case RR: state = state.LD.PSH(1); goto B360_146;
            default: return Exit;
        }

        B329_138: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state.LD.PSH(1); goto B329_139;
            case RT: state = state.RD.PSH(1); goto B329_139;
            default: return Exit;
        }

        B360_146: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ROT; goto B360_147;
            case LT: state = state.POP; goto B360_145;
            case RD: state = state.ROT; goto B360_147;
            case RT: state = state.POP; goto B360_145;
            default: return Exit;
        }

        B360_147: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state.RR.PSH(1); goto B409_045;
            case LL: state = state.LR.PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B360_146;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state.LR.PSH(1); goto B409_045;
            case RL: state = state.RR.PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B360_146;
            default: return Exit;
        }

        B360_145: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.LD.PSH(1); goto B360_146;
            case RT: state = state.RD.PSH(1); goto B360_146;
            default: return Exit;
        }

        B390_127: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.LL.PSH(2); goto B389_127;
            case RR: state = state.RL.PSH(2); goto B389_127;
            default: return Exit;
        }

        B328_135: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.LL.PSH(2); goto B327_135;
            case RR: state = state.RL.PSH(2); goto B327_135;
            default: return Exit;
        }

        B359_142: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.LL.PSH(2); goto B358_142;
            case RR: state = state.RL.PSH(2); goto B358_142;
            default: return Exit;
        }
    }
}
