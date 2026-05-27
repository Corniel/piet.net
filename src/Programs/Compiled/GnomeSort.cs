#pragma warning disable

using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class GnomeSort
{
    public static void Execute(State state)
    {
        B000_000: state = state.PSH(10); goto B001_000; // PT = LR, Size = 10, Colour = light red

        B001_000: state = state.PSH(22); goto B002_000; // PT = LR, Size = 22, Colour = red

        B002_000: state = state.PSH(23); goto B003_000; // PT = LR, Size = 23, Colour = dark red

        B003_000: state = state.PSH(4); goto B004_000; // PT = LR, Size = 4, Colour = light red

        B004_000: state = state.MUL; goto B005_000; // PT = LR, Size = 1, Colour = red

        B005_000: state = state.ADD; goto B006_000; // PT = LR, Size = 1, Colour = light yellow

        B006_000: state = state.DUP; goto B007_000; // PT = LR, Size = 1, Colour = light green

        B007_000: state = state.PSH(13); goto B008_000; // PT = LR, Size = 13, Colour = light red

        B008_000: state = state.SUB; goto B009_000; // PT = LR, Size = 1, Colour = red

        B009_000: state = state.DUP; goto B010_000; // PT = LR, Size = 1, Colour = dark yellow

        B010_000: state = state.PSH(15); goto B011_000; // PT = LR, Size = 15, Colour = dark magenta

        B011_000: state = state.ADD; goto B012_000; // PT = LR, Size = 1, Colour = light magenta

        B012_000: state = state[RD].DUP; goto B013_010; // PT = LR, Size = 1, Colour = light red

        B013_010: state = state.PSH(8); goto B013_018; // PT = RD, Size = 8, Colour = light blue

        B013_018: state = state.SUB; goto B013_019; // PT = RD, Size = 1, Colour = blue

        B013_019: state = state.PSH(2); goto B013_021; // PT = RD, Size = 2, Colour = dark magenta

        B013_021: state = state.ROT; goto B013_022; // PT = RD, Size = 1, Colour = light magenta

        B013_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B015_010;
            case RD: state = state[RT].DUP; goto B015_010;
            case RL: state = state[LT].DUP; goto B015_010;
            case RT: state = state.DUP; goto B015_010;
        }

        B015_010: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B015_009;
            case RT: state = state.PSH(9); goto B015_009;
        }

        B015_009: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B015_008;
            case RT: state = state.ADD; goto B015_008;
        }

        B015_008: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B017_005;
            case RT: state = state[RD].DUP; goto B017_005;
        }

        B017_005: switch (state.PT) // Size = 13, Colour = light blue
        {
            case LD: state = state.PSH(13); goto B017_018;
            case RD: state = state.PSH(13); goto B017_018;
        }

        B017_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B017_019;
            case RD: state = state.SUB; goto B017_019;
        }

        B017_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B017_021;
            case RD: state = state.PSH(2); goto B017_021;
        }

        B017_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B017_022;
            case RD: state = state.ROT; goto B017_022;
        }

        B017_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B019_014;
            case LD: state = state[LT].DUP; goto B019_014;
            case LL: state = state[RT].DUP; goto B019_014;
            case LT: state = state.DUP; goto B019_014;
            case RR: state = state[LT].DUP; goto B019_014;
            case RD: state = state[RT].DUP; goto B019_014;
            case RL: state = state[LT].DUP; goto B019_014;
            case RT: state = state.DUP; goto B019_014;
        }

        B019_014: switch (state.PT) // Size = 5, Colour = red
        {
            case LT: state = state.PSH(5); goto B019_013;
            case RT: state = state.PSH(5); goto B019_013;
        }

        B019_013: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B019_012;
            case RT: state = state.SUB; goto B019_012;
        }

        B019_012: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state[RR].DUP; goto B021_000;
            case RT: state = state[LR].DUP; goto B021_000;
        }

        B021_000: switch (state.PT) // Size = 16, Colour = light blue
        {
            case LR: state = state.PSH(16); goto B022_000;
            case RR: state = state[LR].PSH(16); goto B022_000;
        }

        B022_000: state = state.SUB; goto B023_000; // PT = LR, Size = 1, Colour = blue

        B023_000: state = state.PSH(9); goto B024_000; // PT = LR, Size = 9, Colour = dark magenta

        B024_000: state = state.PSH(23); goto B025_000; // PT = LR, Size = 23, Colour = light magenta

        B025_000: state = state.ADD; goto B026_000; // PT = LR, Size = 1, Colour = magenta

        B026_000: state = state.PSH(5); goto B027_000; // PT = LR, Size = 5, Colour = red

        B027_000: state = state.PSH(23); goto B028_000; // PT = LR, Size = 23, Colour = dark red

        B028_000: state = state.PSH(4); goto B029_000; // PT = LR, Size = 4, Colour = light red

        B029_000: state = state.MUL; goto B030_000; // PT = LR, Size = 1, Colour = red

        B030_000: state = state.ADD; goto B031_000; // PT = LR, Size = 1, Colour = light yellow

        B031_000: state = state.DUP; goto B032_000; // PT = LR, Size = 1, Colour = light green

        B032_000: state = state.PSH(20); goto B033_000; // PT = LR, Size = 20, Colour = light red

        B033_000: state = state.ADD; goto B034_000; // PT = LR, Size = 1, Colour = red

        B034_000: state = state[RD].DUP; goto B035_005; // PT = LR, Size = 1, Colour = yellow

        B035_005: state = state.PSH(13); goto B035_018; // PT = RD, Size = 13, Colour = light blue

        B035_018: state = state.SUB; goto B035_019; // PT = RD, Size = 1, Colour = blue

        B035_019: state = state.PSH(2); goto B035_021; // PT = RD, Size = 2, Colour = dark magenta

        B035_021: state = state.ROT; goto B035_022; // PT = RD, Size = 1, Colour = light magenta

        B035_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B037_008;
            case RD: state = state[RT].DUP; goto B037_008;
            case RL: state = state[LT].DUP; goto B037_008;
            case RT: state = state.DUP; goto B037_008;
        }

        B037_008: switch (state.PT) // Size = 11, Colour = red
        {
            case LT: state = state.PSH(11); goto B037_007;
            case RT: state = state.PSH(11); goto B037_007;
        }

        B037_007: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B037_006;
            case RT: state = state.ADD; goto B037_006;
        }

        B037_006: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[RR].DUP; goto B039_000;
            case RT: state = state[LR].DUP; goto B039_000;
        }

        B039_000: switch (state.PT) // Size = 4, Colour = magenta
        {
            case LR: state = state.PSH(4); goto B040_000;
            case RR: state = state[LR].PSH(4); goto B040_000;
        }

        B040_000: state = state.SUB; goto B041_000; // PT = LR, Size = 1, Colour = dark magenta

        B041_000: state = state.PSH(5); goto B042_000; // PT = LR, Size = 5, Colour = light red

        B042_000: state = state.PSH(23); goto B043_000; // PT = LR, Size = 23, Colour = red

        B043_000: state = state.PSH(3); goto B044_000; // PT = LR, Size = 3, Colour = dark red

        B044_000: state = state.MUL; goto B045_000; // PT = LR, Size = 1, Colour = light red

        B045_000: state = state.ADD; goto B046_000; // PT = LR, Size = 1, Colour = dark yellow

        B046_000: state = state.PSH(9); goto B047_000; // PT = LR, Size = 9, Colour = dark green

        B047_000: state = state.PSH(23); goto B048_000; // PT = LR, Size = 23, Colour = light green

        B048_000: state = state.ADD; goto B049_000; // PT = LR, Size = 1, Colour = green

        B049_000: state = state.DUP; goto B050_000; // PT = LR, Size = 1, Colour = cyan

        B050_000: state = state.PSH(16); goto B051_000; // PT = LR, Size = 16, Colour = yellow

        B051_000: state = state.ADD; goto B052_000; // PT = LR, Size = 1, Colour = dark yellow

        B052_000: state = state[RD].DUP; goto B053_017; // PT = LR, Size = 1, Colour = dark green

        B053_017: state = state.PSH(1); goto B053_018; // PT = RD, Size = 1, Colour = light blue

        B053_018: state = state.ADD; goto B053_019; // PT = RD, Size = 1, Colour = blue

        B053_019: state = state.PSH(2); goto B053_021; // PT = RD, Size = 2, Colour = magenta

        B053_021: state = state.ROT; goto B053_022; // PT = RD, Size = 1, Colour = dark magenta

        B053_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B055_018;
            case RD: state = state[RT].DUP; goto B055_018;
            case RL: state = state[LT].DUP; goto B055_018;
            case RT: state = state.DUP; goto B055_018;
        }

        B055_018: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state.PSH(1); goto B055_017;
            case RT: state = state.PSH(1); goto B055_017;
        }

        B055_017: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B055_016;
            case RT: state = state.SUB; goto B055_016;
        }

        B055_016: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B055_014;
            case RT: state = state.DUP; goto B055_014;
        }

        B055_014: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LT: state = state.PSH(2); goto B055_013;
            case RT: state = state.PSH(2); goto B055_013;
        }

        B055_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B055_012;
            case RT: state = state.ADD; goto B055_012;
        }

        B055_012: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state[RR].DUP; goto B057_000;
            case RT: state = state[LR].DUP; goto B057_000;
        }

        B057_000: switch (state.PT) // Size = 18, Colour = dark red
        {
            case LR: state = state.PSH(18); goto B058_000;
            case RR: state = state[LR].PSH(18); goto B058_000;
        }

        B058_000: state = state.SUB; goto B059_000; // PT = LR, Size = 1, Colour = light red

        B059_000: state = state.PSH(1); goto B060_000; // PT = LR, Size = 1, Colour = yellow

        B060_000: state = state.PSH(23); goto B061_000; // PT = LR, Size = 23, Colour = dark yellow

        B061_000: state = state.PSH(5); goto B062_000; // PT = LR, Size = 5, Colour = light yellow

        B062_000: state = state.MUL; goto B063_000; // PT = LR, Size = 1, Colour = yellow

        B063_000: state = state.ADD; goto B064_000; // PT = LR, Size = 1, Colour = light green

        B064_000: state = state[RD].DUP; goto B065_006; // PT = LR, Size = 1, Colour = light cyan

        B065_006: state = state.PSH(12); goto B065_018; // PT = RD, Size = 12, Colour = light blue

        B065_018: state = state.SUB; goto B065_019; // PT = RD, Size = 1, Colour = blue

        B065_019: state = state.PSH(2); goto B065_021; // PT = RD, Size = 2, Colour = dark magenta

        B065_021: state = state.ROT; goto B065_022; // PT = RD, Size = 1, Colour = light magenta

        B065_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B067_018;
            case RD: state = state[RT].DUP; goto B067_018;
            case RL: state = state[LT].DUP; goto B067_018;
            case RT: state = state.DUP; goto B067_018;
        }

        B067_018: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B067_017;
            case RT: state = state.PSH(1); goto B067_017;
        }

        B067_017: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B067_016;
            case RT: state = state.SUB; goto B067_016;
        }

        B067_016: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B067_014;
            case RT: state = state.DUP; goto B067_014;
        }

        B067_014: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LT: state = state.PSH(2); goto B067_013;
            case RT: state = state.PSH(2); goto B067_013;
        }

        B067_013: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B067_012;
            case RT: state = state.ADD; goto B067_012;
        }

        B067_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state[LD].DUP; goto B069_009;
            case RT: state = state[RD].DUP; goto B069_009;
        }

        B069_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B069_018;
            case RD: state = state.PSH(9); goto B069_018;
        }

        B069_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B069_019;
            case RD: state = state.ADD; goto B069_019;
        }

        B069_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LD: state = state.PSH(2); goto B069_021;
            case RD: state = state.PSH(2); goto B069_021;
        }

        B069_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROT; goto B069_022;
            case RD: state = state.ROT; goto B069_022;
        }

        B069_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state[RT].DUP; goto B071_012;
            case LD: state = state[LT].DUP; goto B071_012;
            case LL: state = state[RT].DUP; goto B071_012;
            case LT: state = state.DUP; goto B071_012;
            case RR: state = state[LT].DUP; goto B071_012;
            case RD: state = state[RT].DUP; goto B071_012;
            case RL: state = state[LT].DUP; goto B071_012;
            case RT: state = state.DUP; goto B071_012;
        }

        B071_012: switch (state.PT) // Size = 7, Colour = light red
        {
            case LT: state = state.PSH(7); goto B071_011;
            case RT: state = state.PSH(7); goto B071_011;
        }

        B071_011: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.ADD; goto B071_010;
            case RT: state = state.ADD; goto B071_010;
        }

        B071_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state[LD].DUP; goto B073_009;
            case RT: state = state[RD].DUP; goto B073_009;
        }

        B073_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B073_018;
            case RD: state = state.PSH(9); goto B073_018;
        }

        B073_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B073_019;
            case RD: state = state.SUB; goto B073_019;
        }

        B073_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B073_021;
            case RD: state = state.PSH(2); goto B073_021;
        }

        B073_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B073_022;
            case RD: state = state.ROT; goto B073_022;
        }

        B073_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B075_018;
            case LD: state = state[LT].DUP; goto B075_018;
            case LL: state = state[RT].DUP; goto B075_018;
            case LT: state = state.DUP; goto B075_018;
            case RR: state = state[LT].DUP; goto B075_018;
            case RD: state = state[RT].DUP; goto B075_018;
            case RL: state = state[LT].DUP; goto B075_018;
            case RT: state = state.DUP; goto B075_018;
        }

        B075_018: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B075_017;
            case RT: state = state.PSH(1); goto B075_017;
        }

        B075_017: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B075_016;
            case RT: state = state.SUB; goto B075_016;
        }

        B075_016: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state[RR].PSH(21); goto B078_000;
            case RT: state = state[LR].PSH(21); goto B078_000;
        }

        B078_000: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B079_000;
            case RR: state = state[LR].PSH(23); goto B079_000;
        }

        B079_000: state = state.PSH(2); goto B080_000; // PT = LR, Size = 2, Colour = dark cyan

        B080_000: state = state.MUL; goto B081_000; // PT = LR, Size = 1, Colour = light cyan

        B081_000: state = state.ADD; goto B082_000; // PT = LR, Size = 1, Colour = dark blue

        B082_000: state = state.PSH(10); goto B083_000; // PT = LR, Size = 10, Colour = dark magenta

        B083_000: state = state.PSH(1); goto B084_000; // PT = LR, Size = 1, Colour = light magenta

        B084_000: state = state.PSH(23); goto B085_000; // PT = LR, Size = 23, Colour = magenta

        B085_000: state = state.PSH(5); goto B086_000; // PT = LR, Size = 5, Colour = dark magenta

        B086_000: state = state.MUL; goto B087_000; // PT = LR, Size = 1, Colour = light magenta

        B087_000: state = state.ADD; goto B088_000; // PT = LR, Size = 1, Colour = dark red

        B088_000: state = state.DUP; goto B089_000; // PT = LR, Size = 1, Colour = dark yellow

        B089_000: state = state.PSH(15); goto B090_000; // PT = LR, Size = 15, Colour = dark magenta

        B090_000: state = state.SUB; goto B091_000; // PT = LR, Size = 1, Colour = light magenta

        B091_000: state = state[RD].DUP; goto B092_014; // PT = LR, Size = 1, Colour = red

        B092_014: state = state.PSH(4); goto B092_018; // PT = RD, Size = 4, Colour = light blue

        B092_018: state = state.ADD; goto B092_019; // PT = RD, Size = 1, Colour = blue

        B092_019: state = state.PSH(2); goto B092_021; // PT = RD, Size = 2, Colour = magenta

        B092_021: state = state.ROT; goto B092_022; // PT = RD, Size = 1, Colour = dark magenta

        B092_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B094_012;
            case RD: state = state[RT].DUP; goto B094_012;
            case RL: state = state[LT].DUP; goto B094_012;
            case RT: state = state.DUP; goto B094_012;
        }

        B094_012: switch (state.PT) // Size = 7, Colour = light red
        {
            case LT: state = state.PSH(7); goto B094_011;
            case RT: state = state.PSH(7); goto B094_011;
        }

        B094_011: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.ADD; goto B094_010;
            case RT: state = state.ADD; goto B094_010;
        }

        B094_010: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LT: state = state[RR].PSH(9); goto B097_000;
            case RT: state = state[LR].PSH(9); goto B097_000;
        }

        B097_000: switch (state.PT) // Size = 23, Colour = dark red
        {
            case LR: state = state.PSH(23); goto B098_000;
            case RR: state = state[LR].PSH(23); goto B098_000;
        }

        B098_000: state = state.ADD; goto B099_000; // PT = LR, Size = 1, Colour = light red

        B099_000: state = state.PSH(18); goto B100_000; // PT = LR, Size = 18, Colour = light yellow

        B100_000: state = state.PSH(23); goto B101_000; // PT = LR, Size = 23, Colour = yellow

        B101_000: state = state.PSH(4); goto B102_000; // PT = LR, Size = 4, Colour = dark yellow

        B102_000: state = state.MUL; goto B103_000; // PT = LR, Size = 1, Colour = light yellow

        B103_000: state = state.ADD; goto B104_000; // PT = LR, Size = 1, Colour = dark green

        B104_000: state = state.DUP; goto B105_000; // PT = LR, Size = 1, Colour = dark cyan

        B105_000: state = state.PSH(5); goto B106_000; // PT = LR, Size = 5, Colour = dark yellow

        B106_000: state = state.SUB; goto B107_000; // PT = LR, Size = 1, Colour = light yellow

        B107_000: state = state.PSH(9); goto B108_000; // PT = LR, Size = 9, Colour = green

        B108_000: state = state.PSH(23); goto B109_000; // PT = LR, Size = 23, Colour = dark green

        B109_000: state = state.ADD; goto B110_000; // PT = LR, Size = 1, Colour = light green

        B110_000: state = state.PSH(18); goto B111_000; // PT = LR, Size = 18, Colour = light cyan

        B111_000: state = state.PSH(23); goto B112_000; // PT = LR, Size = 23, Colour = cyan

        B112_000: state = state.PSH(4); goto B113_000; // PT = LR, Size = 4, Colour = dark cyan

        B113_000: state = state.MUL; goto B114_000; // PT = LR, Size = 1, Colour = light cyan

        B114_000: state = state.ADD; goto B115_000; // PT = LR, Size = 1, Colour = dark blue

        B115_000: state = state.DUP; goto B116_000; // PT = LR, Size = 1, Colour = dark magenta

        B116_000: state = state.PSH(9); goto B117_000; // PT = LR, Size = 9, Colour = dark cyan

        B117_000: state = state.SUB; goto B118_000; // PT = LR, Size = 1, Colour = light cyan

        B118_000: state = state.DUP; goto B119_000; // PT = LR, Size = 1, Colour = blue

        B119_000: state = state.PSH(15); goto B120_000; // PT = LR, Size = 15, Colour = green

        B120_000: state = state.ADD; goto B121_000; // PT = LR, Size = 1, Colour = dark green

        B121_000: state = state.DUP; goto B122_000; // PT = LR, Size = 1, Colour = dark cyan

        B122_000: state = state[RD].DUP; goto B123_007; // PT = LR, Size = 1, Colour = dark yellow

        B123_007: state = state.PSH(11); goto B123_018; // PT = RD, Size = 11, Colour = light blue

        B123_018: state = state.SUB; goto B123_019; // PT = RD, Size = 1, Colour = blue

        B123_019: state = state.PSH(2); goto B123_021; // PT = RD, Size = 2, Colour = dark magenta

        B123_021: state = state.ROT; goto B123_022; // PT = RD, Size = 1, Colour = light magenta

        B123_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B125_010;
            case RD: state = state[RT].DUP; goto B125_010;
            case RL: state = state[LT].DUP; goto B125_010;
            case RT: state = state.DUP; goto B125_010;
        }

        B125_010: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B125_009;
            case RT: state = state.PSH(9); goto B125_009;
        }

        B125_009: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B125_008;
            case RT: state = state.ADD; goto B125_008;
        }

        B125_008: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[RR].DUP; goto B127_000;
            case RT: state = state[LR].DUP; goto B127_000;
        }

        B127_000: switch (state.PT) // Size = 5, Colour = dark magenta
        {
            case LR: state = state.PSH(5); goto B128_000;
            case RR: state = state[LR].PSH(5); goto B128_000;
        }

        B128_000: state = state.ADD; goto B129_000; // PT = LR, Size = 1, Colour = light magenta

        B129_000: state = state.PSH(9); goto B130_000; // PT = LR, Size = 9, Colour = light red

        B130_000: state = state.PSH(23); goto B131_000; // PT = LR, Size = 23, Colour = red

        B131_000: state = state.ADD; goto B132_000; // PT = LR, Size = 1, Colour = dark red

        B132_000: state = state.PSH(17); goto B133_000; // PT = LR, Size = 17, Colour = dark yellow

        B133_000: state = state.PSH(23); goto B134_000; // PT = LR, Size = 23, Colour = light yellow

        B134_000: state = state.PSH(4); goto B135_000; // PT = LR, Size = 4, Colour = yellow

        B135_000: state = state.MUL; goto B136_000; // PT = LR, Size = 1, Colour = dark yellow

        B136_000: state = state.ADD; goto B137_000; // PT = LR, Size = 1, Colour = green

        B137_000: state = state.DUP; goto B138_000; // PT = LR, Size = 1, Colour = cyan

        B138_000: state = state.PSH(12); goto B139_000; // PT = LR, Size = 12, Colour = yellow

        B139_000: state = state.SUB; goto B140_000; // PT = LR, Size = 1, Colour = dark yellow

        B140_000: state = state.DUP; goto B141_000; // PT = LR, Size = 1, Colour = light green

        B141_000: state = state.PSH(17); goto B142_000; // PT = LR, Size = 17, Colour = light red

        B142_000: state = state.ADD; goto B143_000; // PT = LR, Size = 1, Colour = red

        B143_000: state = state[RD].DUP; goto B144_007; // PT = LR, Size = 1, Colour = yellow

        B144_007: state = state.PSH(11); goto B144_018; // PT = RD, Size = 11, Colour = light blue

        B144_018: state = state.SUB; goto B144_019; // PT = RD, Size = 1, Colour = blue

        B144_019: state = state.PSH(2); goto B144_021; // PT = RD, Size = 2, Colour = dark magenta

        B144_021: state = state.ROT; goto B144_022; // PT = RD, Size = 1, Colour = light magenta

        B144_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B146_011;
            case RD: state = state[RT].DUP; goto B146_011;
            case RL: state = state[LT].DUP; goto B146_011;
            case RT: state = state.DUP; goto B146_011;
        }

        B146_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B146_010;
            case RT: state = state.PSH(8); goto B146_010;
        }

        B146_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B146_009;
            case RT: state = state.ADD; goto B146_009;
        }

        B146_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B146_006;
            case RT: state = state.DUP; goto B146_006;
        }

        B146_006: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LT: state = state.PSH(3); goto B146_005;
            case RT: state = state.PSH(3); goto B146_005;
        }

        B146_005: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B146_004;
            case RT: state = state.ADD; goto B146_004;
        }

        B146_004: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state[RR].DUP; goto B148_000;
            case RT: state = state[LR].DUP; goto B148_000;
        }

        B148_000: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LR: state = state.PSH(2); goto B149_000;
            case RR: state = state[LR].PSH(2); goto B149_000;
        }

        B149_000: state = state.SUB; goto B150_000; // PT = LR, Size = 1, Colour = dark magenta

        B150_000: state = state.PSH(9); goto B151_000; // PT = LR, Size = 9, Colour = light red

        B151_000: state = state.PSH(23); goto B152_000; // PT = LR, Size = 23, Colour = red

        B152_000: state = state.ADD; goto B153_000; // PT = LR, Size = 1, Colour = dark red

        B153_000: state = state.PSH(11); goto B154_000; // PT = LR, Size = 11, Colour = dark yellow

        B154_000: state = state.PSH(23); goto B155_000; // PT = LR, Size = 23, Colour = light yellow

        B155_000: state = state.PSH(4); goto B156_000; // PT = LR, Size = 4, Colour = yellow

        B156_000: state = state.MUL; goto B157_000; // PT = LR, Size = 1, Colour = dark yellow

        B157_000: state = state.ADD; goto B158_000; // PT = LR, Size = 1, Colour = green

        B158_000: state = state[RD].DUP; goto B159_011; // PT = LR, Size = 1, Colour = cyan

        B159_011: state = state.PSH(7); goto B159_018; // PT = RD, Size = 7, Colour = light blue

        B159_018: state = state.ADD; goto B159_019; // PT = RD, Size = 1, Colour = blue

        B159_019: state = state.PSH(2); goto B159_021; // PT = RD, Size = 2, Colour = magenta

        B159_021: state = state.ROT; goto B159_022; // PT = RD, Size = 1, Colour = dark magenta

        B159_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B161_014;
            case RD: state = state[RT].DUP; goto B161_014;
            case RL: state = state[LT].DUP; goto B161_014;
            case RT: state = state.DUP; goto B161_014;
        }

        B161_014: switch (state.PT) // Size = 5, Colour = light red
        {
            case LT: state = state.PSH(5); goto B161_013;
            case RT: state = state.PSH(5); goto B161_013;
        }

        B161_013: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B161_012;
            case RT: state = state.SUB; goto B161_012;
        }

        B161_012: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B163_007;
            case RT: state = state[RD].DUP; goto B163_007;
        }

        B163_007: switch (state.PT) // Size = 11, Colour = light blue
        {
            case LD: state = state.PSH(11); goto B163_018;
            case RD: state = state.PSH(11); goto B163_018;
        }

        B163_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ADD; goto B163_019;
            case RD: state = state.ADD; goto B163_019;
        }

        B163_019: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LD: state = state.PSH(2); goto B163_021;
            case RD: state = state.PSH(2); goto B163_021;
        }

        B163_021: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROT; goto B163_022;
            case RD: state = state.ROT; goto B163_022;
        }

        B163_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state[RT].DUP; goto B165_017;
            case LD: state = state[LT].DUP; goto B165_017;
            case LL: state = state[RT].DUP; goto B165_017;
            case LT: state = state.DUP; goto B165_017;
            case RR: state = state[LT].DUP; goto B165_017;
            case RD: state = state[RT].DUP; goto B165_017;
            case RL: state = state[LT].DUP; goto B165_017;
            case RT: state = state.DUP; goto B165_017;
        }

        B165_017: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state.PSH(2); goto B165_016;
            case RT: state = state.PSH(2); goto B165_016;
        }

        B165_016: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B165_015;
            case RT: state = state.SUB; goto B165_015;
        }

        B165_015: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B165_012;
            case RT: state = state.DUP; goto B165_012;
        }

        B165_012: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LT: state = state.PSH(3); goto B165_011;
            case RT: state = state.PSH(3); goto B165_011;
        }

        B165_011: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.SUB; goto B165_010;
            case RT: state = state.SUB; goto B165_010;
        }

        B165_010: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.DUP; goto B165_006;
            case RT: state = state.DUP; goto B165_006;
        }

        B165_006: switch (state.PT) // Size = 4, Colour = blue
        {
            case LT: state = state.PSH(4); goto B165_005;
            case RT: state = state.PSH(4); goto B165_005;
        }

        B165_005: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LT: state = state.ADD; goto B165_004;
            case RT: state = state.ADD; goto B165_004;
        }

        B165_004: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state[RR].PSH(9); goto B168_000;
            case RT: state = state[LR].PSH(9); goto B168_000;
        }

        B168_000: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LR: state = state.PSH(23); goto B169_000;
            case RR: state = state[LR].PSH(23); goto B169_000;
        }

        B169_000: state = state.ADD; goto B170_000; // PT = LR, Size = 1, Colour = light cyan

        B170_000: state = state.PSH(5); goto B171_000; // PT = LR, Size = 5, Colour = light blue

        B171_000: state = state.PSH(23); goto B172_000; // PT = LR, Size = 23, Colour = blue

        B172_000: state = state.PSH(4); goto B173_000; // PT = LR, Size = 4, Colour = dark blue

        B173_000: state = state.MUL; goto B174_000; // PT = LR, Size = 1, Colour = light blue

        B174_000: state = state.ADD; goto B175_000; // PT = LR, Size = 1, Colour = dark magenta

        B175_000: state = state.PSH(9); goto B176_000; // PT = LR, Size = 9, Colour = dark red

        B176_000: state = state.PSH(23); goto B177_000; // PT = LR, Size = 23, Colour = light red

        B177_000: state = state.ADD; goto B178_000; // PT = LR, Size = 1, Colour = red

        B178_000: state = state.PSH(12); goto B179_000; // PT = LR, Size = 12, Colour = yellow

        B179_000: state = state.PSH(23); goto B180_000; // PT = LR, Size = 23, Colour = dark yellow

        B180_000: state = state.PSH(2); goto B181_000; // PT = LR, Size = 2, Colour = light yellow

        B181_000: state = state.MUL; goto B182_000; // PT = LR, Size = 1, Colour = yellow

        B182_000: state = state.ADD; goto B183_000; // PT = LR, Size = 1, Colour = light green

        B183_000: state = state.PSH(1); goto B184_000; // PT = LR, Size = 1, Colour = light cyan

        B184_000: state = state.PSH(23); goto B185_000; // PT = LR, Size = 23, Colour = cyan

        B185_000: state = state.PSH(5); goto B186_000; // PT = LR, Size = 5, Colour = dark cyan

        B186_000: state = state.MUL; goto B187_000; // PT = LR, Size = 1, Colour = light cyan

        B187_000: state = state.ADD; goto B188_000; // PT = LR, Size = 1, Colour = dark blue

        B188_000: state = state[RD].DUP; goto B189_016; // PT = LR, Size = 1, Colour = dark magenta

        B189_016: state = state.PSH(2); goto B189_018; // PT = RD, Size = 2, Colour = light blue

        B189_018: state = state.SUB; goto B189_019; // PT = RD, Size = 1, Colour = blue

        B189_019: state = state.PSH(2); goto B189_021; // PT = RD, Size = 2, Colour = dark magenta

        B189_021: state = state.ROT; goto B189_022; // PT = RD, Size = 1, Colour = light magenta

        B189_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B191_016;
            case RD: state = state[RT].DUP; goto B191_016;
            case RL: state = state[LT].DUP; goto B191_016;
            case RT: state = state.DUP; goto B191_016;
        }

        B191_016: switch (state.PT) // Size = 3, Colour = red
        {
            case LT: state = state.PSH(3); goto B191_015;
            case RT: state = state.PSH(3); goto B191_015;
        }

        B191_015: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B191_014;
            case RT: state = state.SUB; goto B191_014;
        }

        B191_014: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B191_010;
            case RT: state = state.DUP; goto B191_010;
        }

        B191_010: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LT: state = state.PSH(4); goto B191_009;
            case RT: state = state.PSH(4); goto B191_009;
        }

        B191_009: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B191_008;
            case RT: state = state.ADD; goto B191_008;
        }

        B191_008: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.DUP; goto B191_007;
            case RT: state = state.DUP; goto B191_007;
        }

        B191_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LT: state = state.PSH(1); goto B191_006;
            case RT: state = state.PSH(1); goto B191_006;
        }

        B191_006: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LT: state = state.ADD; goto B191_005;
            case RT: state = state.ADD; goto B191_005;
        }

        B191_005: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state[RR].DUP; goto B193_000;
            case RT: state = state[LR].DUP; goto B193_000;
        }

        B193_000: switch (state.PT) // Size = 15, Colour = dark cyan
        {
            case LR: state = state.PSH(15); goto B194_000;
            case RR: state = state[LR].PSH(15); goto B194_000;
        }

        B194_000: state = state.SUB; goto B195_000; // PT = LR, Size = 1, Colour = light cyan

        B195_000: state = state.DUP; goto B196_000; // PT = LR, Size = 1, Colour = blue

        B196_000: state = state.PSH(4); goto B197_000; // PT = LR, Size = 4, Colour = green

        B197_000: state = state.ADD; goto B198_000; // PT = LR, Size = 1, Colour = dark green

        B198_000: state = state.PSH(11); goto B199_000; // PT = LR, Size = 11, Colour = dark cyan

        B199_000: state = state.PSH(23); goto B200_000; // PT = LR, Size = 23, Colour = light cyan

        B200_000: state = state.PSH(3); goto B201_000; // PT = LR, Size = 3, Colour = cyan

        B201_000: state = state.MUL; goto B202_000; // PT = LR, Size = 1, Colour = dark cyan

        B202_000: state = state.ADD; goto B203_000; // PT = LR, Size = 1, Colour = blue

        B203_000: state = state.PSH(6); goto B204_000; // PT = LR, Size = 6, Colour = magenta

        B204_000: state = state.PSH(23); goto B205_000; // PT = LR, Size = 23, Colour = dark magenta

        B205_000: state = state.PSH(3); goto B206_000; // PT = LR, Size = 3, Colour = light magenta

        B206_000: state = state.MUL; goto B207_000; // PT = LR, Size = 1, Colour = magenta

        B207_000: state = state.ADD; goto B208_000; // PT = LR, Size = 1, Colour = light red

        B208_000: state = state[RD].PSH(2); goto B211_002; // PT = LR, Size = 1, Colour = light yellow

        B211_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B211_003;
            case LT: state = state.POP; goto B211_000;
            case RD: state = state.PSH(1); goto B211_003;
            case RT: state = state.POP; goto B211_000;
        }

        B211_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B211_004;
            case LT: state = state.POP; goto B211_002;
            case RD: state = state.ROL; goto B211_004;
            case RT: state = state.POP; goto B211_002;
        }

        B211_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B211_005;
            case LT: state = state.NOT; goto B211_003;
            case RD: state = state.OUTc; goto B211_005;
            case RT: state = state.NOT; goto B211_003;
        }

        B211_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B211_006;
            case LT: state = state.SUB; goto B211_004;
            case RD: state = state.PSH(1); goto B211_006;
            case RT: state = state.SUB; goto B211_004;
        }

        B211_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B211_007;
            case LT: state = state.POP; goto B211_005;
            case RD: state = state.SUB; goto B211_007;
            case RT: state = state.POP; goto B211_005;
        }

        B211_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B211_008;
            case LT: state = state.OUTc; goto B211_006;
            case RD: state = state.DUP; goto B211_008;
            case RT: state = state.OUTc; goto B211_006;
        }

        B211_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B211_009;
            case LT: state = state.DIV; goto B211_007;
            case RD: state = state.NOT; goto B211_009;
            case RT: state = state.DIV; goto B211_007;
        }

        B211_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B211_012;
            case LT: state = state.ROL; goto B211_008;
            case RD: state = state.PSH(3); goto B211_012;
            case RT: state = state.ROL; goto B211_008;
        }

        B211_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B211_013;
            case LT: state = state.POP; goto B211_009;
            case RD: state = state.MUL; goto B211_013;
            case RT: state = state.POP; goto B211_009;
        }

        B211_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B211_014;
            case LT: state = state.OUTi; goto B211_012;
            case RD: state = state.DUP; goto B211_014;
            case RT: state = state.OUTi; goto B211_012;
        }

        B211_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B211_015;
            case LT: state = state.DIV; goto B211_013;
            case RD: state = state.ROT; goto B211_015;
            case RT: state = state.DIV; goto B211_013;
        }

        B211_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B212_015;
            case LD: state = state.POP; goto B211_016;
            case LL: state = state[RT].SWI; goto B211_014;
            case LT: state = state.SWI; goto B211_014;
            case RR: state = state.ROT; goto B212_015;
            case RD: state = state.POP; goto B211_016;
            case RL: state = state[LT].SWI; goto B211_014;
            case RT: state = state.SWI; goto B211_014;
        }

        B211_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B211_002;
            case RD: state = state.PSH(2); goto B211_002;
        }

        B212_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[LL].SWI; goto B211_015;
            case LD: state = state[RL].SWI; goto B211_015;
            case LL: state = state.SWI; goto B211_015;
            case LT: state = state[RT].POP; goto B213_014;
            case RR: state = state[RL].SWI; goto B211_015;
            case RD: state = state[LL].SWI; goto B211_015;
            case RL: state = state.SWI; goto B211_015;
            case RT: state = state.POP; goto B213_014;
        }

        B213_014: state = state[LR].PSH(10); goto B215_000; // PT = RT, Size = 1, Colour = cyan

        B215_000: state = state.PSH(17); goto B216_000; // PT = LR, Size = 17, Colour = yellow

        B216_000: state = state.PSH(23); goto B217_000; // PT = LR, Size = 23, Colour = dark yellow

        B217_000: state = state.PSH(2); goto B218_000; // PT = LR, Size = 2, Colour = light yellow

        B218_000: state = state.MUL; goto B219_000; // PT = LR, Size = 1, Colour = yellow

        B219_000: state = state.ADD; goto B220_000; // PT = LR, Size = 1, Colour = light green

        B220_000: state = state.PSH(8); goto B221_000; // PT = LR, Size = 8, Colour = light cyan

        B221_000: state = state.PSH(23); goto B222_000; // PT = LR, Size = 23, Colour = cyan

        B222_000: state = state.PSH(4); goto B223_000; // PT = LR, Size = 4, Colour = dark cyan

        B223_000: state = state.MUL; goto B224_000; // PT = LR, Size = 1, Colour = light cyan

        B211_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state[LD].PSH(2); goto B211_002;
            case RT: state = state[RD].PSH(2); goto B211_002;
        }

        B224_000: state = state.ADD; goto B225_000; // PT = LR, Size = 1, Colour = dark blue

        B225_000: state = state.DUP; goto B226_000; // PT = LR, Size = 1, Colour = dark magenta

        B226_000: state = state.PSH(1); goto B227_000; // PT = LR, Size = 1, Colour = dark cyan

        B227_000: state = state.ADD; goto B228_000; // PT = LR, Size = 1, Colour = light cyan

        B228_000: state = state.DUP; goto B229_000; // PT = LR, Size = 1, Colour = light blue

        B229_000: state = state.PSH(15); goto B230_000; // PT = LR, Size = 15, Colour = light green

        B230_000: state = state.ADD; goto B231_000; // PT = LR, Size = 1, Colour = green

        B231_000: state = state[RD].DUP; goto B232_016; // PT = LR, Size = 1, Colour = cyan

        B232_016: state = state.PSH(2); goto B232_018; // PT = RD, Size = 2, Colour = light blue

        B232_018: state = state.SUB; goto B232_019; // PT = RD, Size = 1, Colour = blue

        B232_019: state = state.PSH(2); goto B232_021; // PT = RD, Size = 2, Colour = dark magenta

        B232_021: state = state.ROT; goto B232_022; // PT = RD, Size = 1, Colour = light magenta

        B232_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B234_016;
            case RD: state = state[RT].DUP; goto B234_016;
            case RL: state = state[LT].DUP; goto B234_016;
            case RT: state = state.DUP; goto B234_016;
        }

        B234_016: switch (state.PT) // Size = 3, Colour = red
        {
            case LT: state = state.PSH(3); goto B234_015;
            case RT: state = state.PSH(3); goto B234_015;
        }

        B234_015: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B234_014;
            case RT: state = state.SUB; goto B234_014;
        }

        B234_014: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.DUP; goto B234_010;
            case RT: state = state.DUP; goto B234_010;
        }

        B234_010: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LT: state = state.PSH(4); goto B234_009;
            case RT: state = state.PSH(4); goto B234_009;
        }

        B234_009: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LT: state = state.ADD; goto B234_008;
            case RT: state = state.ADD; goto B234_008;
        }

        B234_008: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state[RR].PSH(9); goto B237_000;
            case RT: state = state[LR].PSH(9); goto B237_000;
        }

        B237_000: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LR: state = state.PSH(23); goto B238_000;
            case RR: state = state[LR].PSH(23); goto B238_000;
        }

        B238_000: state = state.ADD; goto B239_000; // PT = LR, Size = 1, Colour = light cyan

        B239_000: state = state.PSH(9); goto B240_000; // PT = LR, Size = 9, Colour = light blue

        B240_000: state = state.PSH(23); goto B241_000; // PT = LR, Size = 23, Colour = blue

        B241_000: state = state.PSH(4); goto B242_000; // PT = LR, Size = 4, Colour = dark blue

        B242_000: state = state.MUL; goto B243_000; // PT = LR, Size = 1, Colour = light blue

        B243_000: state = state.ADD; goto B244_000; // PT = LR, Size = 1, Colour = dark magenta

        B244_000: state = state.DUP; goto B245_000; // PT = LR, Size = 1, Colour = dark red

        B245_000: state = state.PSH(3); goto B246_000; // PT = LR, Size = 3, Colour = dark blue

        B246_000: state = state.SUB; goto B247_000; // PT = LR, Size = 1, Colour = light blue

        B247_000: state = state.PSH(9); goto B248_000; // PT = LR, Size = 9, Colour = magenta

        B248_000: state = state.PSH(23); goto B249_000; // PT = LR, Size = 23, Colour = dark magenta

        B249_000: state = state.ADD; goto B250_000; // PT = LR, Size = 1, Colour = light magenta

        B250_000: state = state.PSH(19); goto B251_000; // PT = LR, Size = 19, Colour = light red

        B251_000: state = state.PSH(23); goto B252_000; // PT = LR, Size = 23, Colour = red

        B252_000: state = state.PSH(4); goto B253_000; // PT = LR, Size = 4, Colour = dark red

        B253_000: state = state.MUL; goto B254_000; // PT = LR, Size = 1, Colour = light red

        B254_000: state = state.ADD; goto B255_000; // PT = LR, Size = 1, Colour = dark yellow

        B255_000: state = state.DUP; goto B256_000; // PT = LR, Size = 1, Colour = dark green

        B256_000: state = state.PSH(5); goto B257_000; // PT = LR, Size = 5, Colour = dark red

        B257_000: state = state.ADD; goto B258_000; // PT = LR, Size = 1, Colour = light red

        B258_000: state = state.PSH(9); goto B259_000; // PT = LR, Size = 9, Colour = light yellow

        B259_000: state = state.PSH(23); goto B260_000; // PT = LR, Size = 23, Colour = yellow

        B260_000: state = state.ADD; goto B261_000; // PT = LR, Size = 1, Colour = dark yellow

        B261_000: state = state.PSH(23); goto B262_000; // PT = LR, Size = 23, Colour = dark green

        B262_000: state = state.PSH(5); goto B263_000; // PT = LR, Size = 5, Colour = light green

        B263_000: state = state.MUL; goto B264_000; // PT = LR, Size = 1, Colour = green

        B264_000: state = state[RD].DUP; goto B265_017; // PT = LR, Size = 1, Colour = light cyan

        B265_017: state = state.PSH(1); goto B265_018; // PT = RD, Size = 1, Colour = light blue

        B265_018: state = state.ADD; goto B265_019; // PT = RD, Size = 1, Colour = blue

        B265_019: state = state.PSH(2); goto B265_021; // PT = RD, Size = 2, Colour = magenta

        B265_021: state = state.ROT; goto B265_022; // PT = RD, Size = 1, Colour = dark magenta

        B265_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B267_013;
            case RD: state = state[RT].DUP; goto B267_013;
            case RL: state = state[LT].DUP; goto B267_013;
            case RT: state = state.DUP; goto B267_013;
        }

        B267_013: switch (state.PT) // Size = 6, Colour = light red
        {
            case LT: state = state.PSH(6); goto B267_012;
            case RT: state = state.PSH(6); goto B267_012;
        }

        B267_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B267_011;
            case RT: state = state.SUB; goto B267_011;
        }

        B267_011: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B269_009;
            case RT: state = state[RD].DUP; goto B269_009;
        }

        B269_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B269_018;
            case RD: state = state.PSH(9); goto B269_018;
        }

        B269_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B269_019;
            case RD: state = state.SUB; goto B269_019;
        }

        B269_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B269_021;
            case RD: state = state.PSH(2); goto B269_021;
        }

        B269_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B269_022;
            case RD: state = state.ROT; goto B269_022;
        }

        B269_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B271_011;
            case LD: state = state[LT].DUP; goto B271_011;
            case LL: state = state[RT].DUP; goto B271_011;
            case LT: state = state.DUP; goto B271_011;
            case RR: state = state[LT].DUP; goto B271_011;
            case RD: state = state[RT].DUP; goto B271_011;
            case RL: state = state[LT].DUP; goto B271_011;
            case RT: state = state.DUP; goto B271_011;
        }

        B271_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B271_010;
            case RT: state = state.PSH(8); goto B271_010;
        }

        B271_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B271_009;
            case RT: state = state.ADD; goto B271_009;
        }

        B271_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B273_010;
            case RT: state = state[RD].DUP; goto B273_010;
        }

        B273_010: switch (state.PT) // Size = 8, Colour = light blue
        {
            case LD: state = state.PSH(8); goto B273_018;
            case RD: state = state.PSH(8); goto B273_018;
        }

        B273_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B273_019;
            case RD: state = state.SUB; goto B273_019;
        }

        B273_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B273_021;
            case RD: state = state.PSH(2); goto B273_021;
        }

        B273_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B273_022;
            case RD: state = state.ROT; goto B273_022;
        }

        B273_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B275_012;
            case LD: state = state[LT].DUP; goto B275_012;
            case LL: state = state[RT].DUP; goto B275_012;
            case LT: state = state.DUP; goto B275_012;
            case RR: state = state[LT].DUP; goto B275_012;
            case RD: state = state[RT].DUP; goto B275_012;
            case RL: state = state[LT].DUP; goto B275_012;
            case RT: state = state.DUP; goto B275_012;
        }

        B275_012: switch (state.PT) // Size = 7, Colour = red
        {
            case LT: state = state.PSH(7); goto B275_011;
            case RT: state = state.PSH(7); goto B275_011;
        }

        B275_011: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B275_010;
            case RT: state = state.ADD; goto B275_010;
        }

        B275_010: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[RR].DUP; goto B277_000;
            case RT: state = state[LR].DUP; goto B277_000;
        }

        B277_000: switch (state.PT) // Size = 7, Colour = light yellow
        {
            case LR: state = state.PSH(7); goto B278_000;
            case RR: state = state[LR].PSH(7); goto B278_000;
        }

        B278_000: state = state.SUB; goto B279_000; // PT = LR, Size = 1, Colour = yellow

        B279_000: state = state.PSH(9); goto B280_000; // PT = LR, Size = 9, Colour = dark green

        B280_000: state = state.PSH(23); goto B281_000; // PT = LR, Size = 23, Colour = light green

        B281_000: state = state.ADD; goto B282_000; // PT = LR, Size = 1, Colour = green

        B282_000: state = state.PSH(6); goto B283_000; // PT = LR, Size = 6, Colour = cyan

        B283_000: state = state.PSH(23); goto B284_000; // PT = LR, Size = 23, Colour = dark cyan

        B284_000: state = state.PSH(5); goto B285_000; // PT = LR, Size = 5, Colour = light cyan

        B285_000: state = state.MUL; goto B286_000; // PT = LR, Size = 1, Colour = cyan

        B286_000: state = state.ADD; goto B287_000; // PT = LR, Size = 1, Colour = light blue

        B287_000: state = state[RD].DUP; goto B288_007; // PT = LR, Size = 1, Colour = light magenta

        B288_007: state = state.PSH(11); goto B288_018; // PT = RD, Size = 11, Colour = light blue

        B288_018: state = state.SUB; goto B288_019; // PT = RD, Size = 1, Colour = blue

        B288_019: state = state.PSH(2); goto B288_021; // PT = RD, Size = 2, Colour = dark magenta

        B288_021: state = state.ROT; goto B288_022; // PT = RD, Size = 1, Colour = light magenta

        B288_022: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B290_006;
            case RD: state = state[RT].DUP; goto B290_006;
            case RL: state = state[LT].DUP; goto B290_006;
            case RT: state = state.DUP; goto B290_006;
        }

        B290_006: switch (state.PT) // Size = 13, Colour = red
        {
            case LT: state = state.PSH(13); goto B290_005;
            case RT: state = state.PSH(13); goto B290_005;
        }

        B290_005: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B290_004;
            case RT: state = state.SUB; goto B290_004;
        }

        B290_004: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state[RR].DUP; goto B292_000;
            case RT: state = state[LR].DUP; goto B292_000;
        }

        B292_000: switch (state.PT) // Size = 12, Colour = light cyan
        {
            case LR: state = state.PSH(12); goto B293_000;
            case RR: state = state[LR].PSH(12); goto B293_000;
        }

        B293_000: state = state.ADD; goto B294_000; // PT = LR, Size = 1, Colour = cyan

        B294_000: state = state.PSH(9); goto B295_000; // PT = LR, Size = 9, Colour = blue

        B295_000: state = state.PSH(23); goto B296_000; // PT = LR, Size = 23, Colour = dark blue

        B296_000: state = state.ADD; goto B297_000; // PT = LR, Size = 1, Colour = light blue

        B297_000: state = state.PSH(4); goto B298_000; // PT = LR, Size = 4, Colour = light magenta

        B298_000: state = state.PSH(23); goto B299_000; // PT = LR, Size = 23, Colour = magenta

        B299_000: state = state.PSH(5); goto B300_000; // PT = LR, Size = 5, Colour = dark magenta

        B300_000: state = state.MUL; goto B301_000; // PT = LR, Size = 1, Colour = light magenta

        B301_000: state = state.ADD; goto B302_000; // PT = LR, Size = 1, Colour = dark red

        B302_000: state = state.DUP; goto B303_000; // PT = LR, Size = 1, Colour = dark yellow

        B303_000: state = state.PSH(8); goto B304_000; // PT = LR, Size = 8, Colour = dark magenta

        B304_000: state = state.SUB; goto B305_000; // PT = LR, Size = 1, Colour = light magenta

        B305_000: state = state.PSH(3); goto B306_000; // PT = LR, Size = 3, Colour = red

        B306_000: state = state.PSH(23); goto B307_000; // PT = LR, Size = 23, Colour = dark red

        B307_000: state = state.PSH(3); goto B308_000; // PT = LR, Size = 3, Colour = light red

        B308_000: state = state.MUL; goto B309_000; // PT = LR, Size = 1, Colour = red

        B309_000: state = state.ADD; goto B310_000; // PT = LR, Size = 1, Colour = light yellow

        B310_000: state = state.PSH(9); goto B311_000; // PT = LR, Size = 9, Colour = light green

        B311_000: state = state.PSH(23); goto B312_000; // PT = LR, Size = 23, Colour = green

        B312_000: state = state.ADD; goto B313_000; // PT = LR, Size = 1, Colour = dark green

        B313_000: state = state[RD].PSH(2); goto B316_002; // PT = LR, Size = 1, Colour = dark cyan

        B316_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B316_003;
            case LT: state = state.POP; goto B316_000;
            case RD: state = state.PSH(1); goto B316_003;
            case RT: state = state.POP; goto B316_000;
        }

        B316_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B316_004;
            case LT: state = state.POP; goto B316_002;
            case RD: state = state.ROL; goto B316_004;
            case RT: state = state.POP; goto B316_002;
        }

        B316_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B316_005;
            case LT: state = state.NOT; goto B316_003;
            case RD: state = state.OUTc; goto B316_005;
            case RT: state = state.NOT; goto B316_003;
        }

        B316_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B316_006;
            case LT: state = state.SUB; goto B316_004;
            case RD: state = state.PSH(1); goto B316_006;
            case RT: state = state.SUB; goto B316_004;
        }

        B316_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B316_007;
            case LT: state = state.POP; goto B316_005;
            case RD: state = state.SUB; goto B316_007;
            case RT: state = state.POP; goto B316_005;
        }

        B316_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B316_008;
            case LT: state = state.OUTc; goto B316_006;
            case RD: state = state.DUP; goto B316_008;
            case RT: state = state.OUTc; goto B316_006;
        }

        B316_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B316_009;
            case LT: state = state.DIV; goto B316_007;
            case RD: state = state.NOT; goto B316_009;
            case RT: state = state.DIV; goto B316_007;
        }

        B316_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B316_012;
            case LT: state = state.ROL; goto B316_008;
            case RD: state = state.PSH(3); goto B316_012;
            case RT: state = state.ROL; goto B316_008;
        }

        B316_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B316_013;
            case LT: state = state.POP; goto B316_009;
            case RD: state = state.MUL; goto B316_013;
            case RT: state = state.POP; goto B316_009;
        }

        B316_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B316_014;
            case LT: state = state.OUTi; goto B316_012;
            case RD: state = state.DUP; goto B316_014;
            case RT: state = state.OUTi; goto B316_012;
        }

        B316_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B316_015;
            case LT: state = state.DIV; goto B316_013;
            case RD: state = state.ROT; goto B316_015;
            case RT: state = state.DIV; goto B316_013;
        }

        B316_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B317_015;
            case LD: state = state.POP; goto B316_016;
            case LL: state = state[RT].SWI; goto B316_014;
            case LT: state = state.SWI; goto B316_014;
            case RR: state = state.ROT; goto B317_015;
            case RD: state = state.POP; goto B316_016;
            case RL: state = state[LT].SWI; goto B316_014;
            case RT: state = state.SWI; goto B316_014;
        }

        B316_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B316_002;
            case RD: state = state.PSH(2); goto B316_002;
        }

        B317_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[LL].SWI; goto B316_015;
            case LD: state = state[RL].SWI; goto B316_015;
            case LL: state = state.SWI; goto B316_015;
            case LT: state = state[RT].POP; goto B318_014;
            case RR: state = state[RL].SWI; goto B316_015;
            case RD: state = state[LL].SWI; goto B316_015;
            case RL: state = state.SWI; goto B316_015;
            case RT: state = state.POP; goto B318_014;
        }

        B318_014: state = state[LR].INi; goto B320_000; // PT = RT, Size = 1, Colour = cyan

        B320_000: state = state.PSH(1); goto B321_000; // PT = LR, Size = 1, Colour = yellow

        B321_000: state = state.NOT; goto B322_000; // PT = LR, Size = 1, Colour = dark yellow

        B322_000: state = state.PSH(10); goto B323_000; // PT = LR, Size = 10, Colour = cyan

        B323_000: state = state.PSH(12); goto B324_000; // PT = LR, Size = 12, Colour = dark cyan

        B324_000: state = state.PSH(23); goto B325_000; // PT = LR, Size = 23, Colour = light cyan

        B325_000: state = state.PSH(2); goto B326_000; // PT = LR, Size = 2, Colour = cyan

        B326_000: state = state.MUL; goto B327_000; // PT = LR, Size = 1, Colour = dark cyan

        B327_000: state = state.ADD; goto B328_000; // PT = LR, Size = 1, Colour = blue

        B328_000: state = state.PSH(23); goto B329_000; // PT = LR, Size = 23, Colour = magenta

        B316_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state[LD].PSH(2); goto B316_002;
            case RT: state = state[RD].PSH(2); goto B316_002;
        }

        B329_000: state = state.PSH(5); goto B330_000; // PT = LR, Size = 5, Colour = dark magenta

        B330_000: state = state.MUL; goto B331_000; // PT = LR, Size = 1, Colour = light magenta

        B331_000: state = state[RD].DUP; goto B332_017; // PT = LR, Size = 1, Colour = dark red

        B332_017: state = state.PSH(1); goto B332_018; // PT = RD, Size = 1, Colour = light blue

        B332_018: state = state.ADD; goto B332_019; // PT = RD, Size = 1, Colour = blue

        B332_019: state = state.PSH(2); goto B332_021; // PT = RD, Size = 2, Colour = magenta

        B332_021: state = state.ROT; goto B332_022; // PT = RD, Size = 1, Colour = dark magenta

        B332_022: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B334_013;
            case RD: state = state[RT].DUP; goto B334_013;
            case RL: state = state[LT].DUP; goto B334_013;
            case RT: state = state.DUP; goto B334_013;
        }

        B334_013: switch (state.PT) // Size = 6, Colour = light red
        {
            case LT: state = state.PSH(6); goto B334_012;
            case RT: state = state.PSH(6); goto B334_012;
        }

        B334_012: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B334_011;
            case RT: state = state.SUB; goto B334_011;
        }

        B334_011: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B336_009;
            case RT: state = state[RD].DUP; goto B336_009;
        }

        B336_009: switch (state.PT) // Size = 9, Colour = light blue
        {
            case LD: state = state.PSH(9); goto B336_018;
            case RD: state = state.PSH(9); goto B336_018;
        }

        B336_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B336_019;
            case RD: state = state.SUB; goto B336_019;
        }

        B336_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B336_021;
            case RD: state = state.PSH(2); goto B336_021;
        }

        B336_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B336_022;
            case RD: state = state.ROT; goto B336_022;
        }

        B336_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B338_011;
            case LD: state = state[LT].DUP; goto B338_011;
            case LL: state = state[RT].DUP; goto B338_011;
            case LT: state = state.DUP; goto B338_011;
            case RR: state = state[LT].DUP; goto B338_011;
            case RD: state = state[RT].DUP; goto B338_011;
            case RL: state = state[LT].DUP; goto B338_011;
            case RT: state = state.DUP; goto B338_011;
        }

        B338_011: switch (state.PT) // Size = 8, Colour = red
        {
            case LT: state = state.PSH(8); goto B338_010;
            case RT: state = state.PSH(8); goto B338_010;
        }

        B338_010: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B338_009;
            case RT: state = state.ADD; goto B338_009;
        }

        B338_009: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B340_010;
            case RT: state = state[RD].DUP; goto B340_010;
        }

        B340_010: switch (state.PT) // Size = 8, Colour = light blue
        {
            case LD: state = state.PSH(8); goto B340_018;
            case RD: state = state.PSH(8); goto B340_018;
        }

        B340_018: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B340_019;
            case RD: state = state.SUB; goto B340_019;
        }

        B340_019: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B340_021;
            case RD: state = state.PSH(2); goto B340_021;
        }

        B340_021: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B340_022;
            case RD: state = state.ROT; goto B340_022;
        }

        B340_022: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B342_012;
            case LD: state = state[LT].DUP; goto B342_012;
            case LL: state = state[RT].DUP; goto B342_012;
            case LT: state = state.DUP; goto B342_012;
            case RR: state = state[LT].DUP; goto B342_012;
            case RD: state = state[RT].DUP; goto B342_012;
            case RL: state = state[LT].DUP; goto B342_012;
            case RT: state = state.DUP; goto B342_012;
        }

        B342_012: switch (state.PT) // Size = 7, Colour = red
        {
            case LT: state = state.PSH(7); goto B342_011;
            case RT: state = state.PSH(7); goto B342_011;
        }

        B342_011: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B342_010;
            case RT: state = state.ADD; goto B342_010;
        }

        B342_010: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[RR].DUP; goto B344_000;
            case RT: state = state[LR].DUP; goto B344_000;
        }

        B344_000: switch (state.PT) // Size = 7, Colour = dark blue
        {
            case LR: state = state.PSH(7); goto B345_000;
            case RR: state = state[LR].PSH(7); goto B345_000;
        }

        B345_000: state = state.SUB; goto B346_000; // PT = LR, Size = 1, Colour = light blue

        B346_000: state = state.PSH(10); goto B347_000; // PT = LR, Size = 10, Colour = magenta

        B347_000: state = state[RD].PSH(2); goto B350_002; // PT = LR, Size = 1, Colour = dark magenta

        B350_002: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B350_003;
            case LT: state = state.POP; goto B350_000;
            case RD: state = state.PSH(1); goto B350_003;
            case RT: state = state.POP; goto B350_000;
        }

        B350_003: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B350_004;
            case LT: state = state.POP; goto B350_002;
            case RD: state = state.ROL; goto B350_004;
            case RT: state = state.POP; goto B350_002;
        }

        B350_004: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B350_005;
            case LT: state = state.NOT; goto B350_003;
            case RD: state = state.OUTc; goto B350_005;
            case RT: state = state.NOT; goto B350_003;
        }

        B350_005: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B350_006;
            case LT: state = state.SUB; goto B350_004;
            case RD: state = state.PSH(1); goto B350_006;
            case RT: state = state.SUB; goto B350_004;
        }

        B350_006: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B350_007;
            case LT: state = state.POP; goto B350_005;
            case RD: state = state.SUB; goto B350_007;
            case RT: state = state.POP; goto B350_005;
        }

        B350_007: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B350_008;
            case LT: state = state.OUTc; goto B350_006;
            case RD: state = state.DUP; goto B350_008;
            case RT: state = state.OUTc; goto B350_006;
        }

        B350_008: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B350_009;
            case LT: state = state.DIV; goto B350_007;
            case RD: state = state.NOT; goto B350_009;
            case RT: state = state.DIV; goto B350_007;
        }

        B350_009: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B350_012;
            case LT: state = state.ROL; goto B350_008;
            case RD: state = state.PSH(3); goto B350_012;
            case RT: state = state.ROL; goto B350_008;
        }

        B350_012: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B350_013;
            case LT: state = state.POP; goto B350_009;
            case RD: state = state.MUL; goto B350_013;
            case RT: state = state.POP; goto B350_009;
        }

        B350_013: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B350_014;
            case LT: state = state.OUTi; goto B350_012;
            case RD: state = state.DUP; goto B350_014;
            case RT: state = state.OUTi; goto B350_012;
        }

        B350_014: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B350_015;
            case LT: state = state.DIV; goto B350_013;
            case RD: state = state.ROT; goto B350_015;
            case RT: state = state.DIV; goto B350_013;
        }

        B350_015: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B351_015;
            case LD: state = state.POP; goto B350_016;
            case LL: state = state[RT].SWI; goto B350_014;
            case LT: state = state.SWI; goto B350_014;
            case RR: state = state.ROT; goto B351_015;
            case RD: state = state.POP; goto B350_016;
            case RL: state = state[LT].SWI; goto B350_014;
            case RT: state = state.SWI; goto B350_014;
        }

        B350_016: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B350_002;
            case RD: state = state.PSH(2); goto B350_002;
        }

        B351_015: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[LL].SWI; goto B350_015;
            case LD: state = state[RL].SWI; goto B350_015;
            case LL: state = state.SWI; goto B350_015;
            case LT: state = state[RT].POP; goto B352_014;
            case RR: state = state[RL].SWI; goto B350_015;
            case RD: state = state[LL].SWI; goto B350_015;
            case RL: state = state.SWI; goto B350_015;
            case RT: state = state.POP; goto B352_014;
        }

        B352_014: state = state[LR].INi; goto B356_000; // PT = RT, Size = 1, Colour = cyan

        B356_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B357_000;
            case RR: state = state[LR].PSH(3); goto B357_000;
            case RL: state = state.MOD; goto B355_000;
        }

        B357_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B358_000;
            case RL: state = state.POP; goto B356_000;
        }

        B358_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROL; goto B359_000;
            case RL: state = state.POP; goto B357_000;
        }

        B359_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B360_000;
            case RL: state = state.NOT; goto B358_000;
        }

        B360_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ADD; goto B361_000;
            case RL: state = state.POP; goto B359_000;
        }

        B361_000: switch (state.PT) // Size = 2, Colour = dark green
        {
            case LR: state = state.PSH(2); goto B362_000;
            case RL: state = state.INc; goto B360_000;
        }

        B362_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B363_000;
            case RL: state = state.POP; goto B361_000;
        }

        B363_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ROL; goto B364_000;
            case RL: state = state.POP; goto B362_000;
        }

        B364_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.DUP; goto B365_000;
            case RL: state = state.NOT; goto B363_000;
        }

        B350_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state[LD].PSH(2); goto B350_002;
            case RT: state = state[RD].PSH(2); goto B350_002;
        }

        B365_000: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LR: state = state.PSH(3); goto B366_000;
            case RL: state = state.DIV; goto B364_000;
        }

        B366_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B367_000;
            case RL: state = state.POP; goto B365_000;
        }

        B367_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B368_000;
            case RL: state = state.POP; goto B366_000;
        }

        B368_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.SUB; goto B369_000;
            case RL: state = state.POP; goto B367_000;
        }

        B369_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B370_000;
            case RL: state = state.OUTc; goto B368_000;
        }

        B370_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B371_000;
            case RL: state = state.NOT; goto B369_000;
        }

        B371_000: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LR: state = state.PSH(3); goto B372_000;
            case LL: state = state[RL].DIV; goto B370_000;
            case RL: state = state.DIV; goto B370_000;
        }

        B372_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.PSH(1); goto B373_000;
            case LL: state = state.POP; goto B371_000;
            case RL: state = state.POP; goto B371_000;
        }

        B373_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B374_000;
            case LL: state = state.POP; goto B372_000;
            case RL: state = state.POP; goto B372_000;
        }

        B374_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.GT_; goto B375_000;
            case LL: state = state.NOT; goto B373_000;
            case RL: state = state.NOT; goto B373_000;
        }

        B375_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.NOT; goto B376_000;
            case LL: state = state.GT_; goto B374_000;
            case RL: state = state.GT_; goto B374_000;
        }

        B376_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B377_000;
            case LL: state = state.ROL; goto B375_000;
            case RL: state = state.ROL; goto B375_000;
        }

        B377_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B378_000;
            case LL: state = state.ROL; goto B376_000;
            case RL: state = state.ROL; goto B376_000;
        }

        B378_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B381_000;
            case LD: state = state[RR].INi; goto B356_000;
            case LL: state = state.SWI; goto B377_000;
            case LT: state = state[RR].POP; goto B381_000;
        }

        B381_000: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.PSH(2); goto B382_000;
            case RR: state = state[LR].PSH(2); goto B382_000;
            case RL: state = state.PSH(2); goto B380_000;
        }

        B382_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ADD; goto B383_000;
            case RL: state = state.POP; goto B381_000;
        }

        B383_000: switch (state.PT) // Size = 2, Colour = light blue
        {
            case LR: state = state.PSH(2); goto B384_000;
            case RL: state = state.INc; goto B382_000;
        }

        B384_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(1); goto B385_000;
            case RL: state = state.POP; goto B383_000;
        }

        B385_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B386_000;
            case RL: state = state.POP; goto B384_000;
        }

        B386_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B387_000;
            case RL: state = state.NOT; goto B385_000;
        }

        B387_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.NOT; goto B388_000;
            case RL: state = state.POP; goto B386_000;
        }

        B388_000: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.PSH(3); goto B389_000;
            case RL: state = state.ROL; goto B387_000;
        }

        B389_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(1); goto B390_000;
            case RL: state = state.POP; goto B388_000;
        }

        B390_000: switch (state.PT) // Size = 2, Colour = dark blue
        {
            case LR: state = state.PSH(2); goto B391_000;
            case RL: state = state.POP; goto B389_000;
        }

        B391_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.SUB; goto B392_000;
            case RL: state = state.POP; goto B390_000;
        }

        B392_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROL; goto B393_000;
            case RL: state = state.OUTc; goto B391_000;
        }

        B393_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B394_000;
            case RL: state = state.NOT; goto B392_000;
        }

        B394_000: switch (state.PT) // Size = 5, Colour = dark yellow
        {
            case LR: state = state.PSH(5); goto B395_000;
            case RL: state = state.DIV; goto B393_000;
        }

        B395_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B396_000;
            case RL: state = state.POP; goto B394_000;
        }

        B396_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B397_000;
            case RL: state = state.POP; goto B395_000;
        }

        B397_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B398_000;
            case RL: state = state.NOT; goto B396_000;
        }

        B398_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B399_000;
            case RL: state = state.POP; goto B397_000;
        }

        B399_000: state = state.PSH(3); goto B402_000; // PT = LR, Size = 1, Colour = cyan

        B402_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B403_000;
            case RL: state = state.POP; goto B401_000;
        }

        B403_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B404_000;
            case RL: state = state.POP; goto B402_000;
        }

        B404_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.SUB; goto B405_000;
            case RL: state = state.POP; goto B403_000;
        }

        B405_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B406_000;
            case RL: state = state.OUTc; goto B404_000;
        }

        B355_000: state = state[RR].INi; goto B356_000; // PT = RL, Size = 1, Colour = dark magenta

        B406_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.DUP; goto B407_000;
            case RL: state = state.NOT; goto B405_000;
        }

        B407_000: switch (state.PT) // Size = 3, Colour = light red
        {
            case LR: state = state.PSH(3); goto B408_000;
            case RL: state = state.DIV; goto B406_000;
        }

        B408_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B409_000;
            case RL: state = state.POP; goto B407_000;
        }

        B409_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROL; goto B410_000;
            case RL: state = state.POP; goto B408_000;
        }

        B410_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B411_000;
            case RL: state = state.NOT; goto B409_000;
        }

        B411_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B412_000;
            case RL: state = state.POP; goto B410_000;
        }

        B412_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.SUB; goto B413_000;
            case RL: state = state.POP; goto B411_000;
        }

        B413_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROL; goto B414_000;
            case RL: state = state.OUTc; goto B412_000;
        }

        B414_000: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LR: state = state.PSH(3); goto B415_000;
            case RL: state = state.NOT; goto B413_000;
        }

        B415_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B416_000;
            case RL: state = state.POP; goto B414_000;
        }

        B416_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B417_000;
            case RL: state = state.POP; goto B415_000;
        }

        B417_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.SUB; goto B418_000;
            case RL: state = state.POP; goto B416_000;
        }

        B418_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ROL; goto B419_000;
            case RL: state = state.OUTc; goto B417_000;
        }

        B419_000: switch (state.PT) // Size = 2, Colour = light green
        {
            case LR: state = state.PSH(2); goto B420_000;
            case RL: state = state.NOT; goto B418_000;
        }

        B420_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.SUB; goto B421_000;
            case RL: state = state.POP; goto B419_000;
        }

        B421_000: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state.PSH(2); goto B422_000;
            case RL: state = state.OUTc; goto B420_000;
        }

        B422_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B423_000;
            case RL: state = state.POP; goto B421_000;
        }

        B423_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.ROL; goto B424_000;
            case RL: state = state.POP; goto B422_000;
        }

        B424_000: switch (state.PT) // Size = 2, Colour = dark yellow
        {
            case LR: state = state.PSH(2); goto B425_000;
            case RL: state = state.NOT; goto B423_000;
        }

        B425_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B426_000;
            case RL: state = state.POP; goto B424_000;
        }

        B426_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B427_000;
            case RL: state = state.POP; goto B425_000;
        }

        B427_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B428_000;
            case RL: state = state.NOT; goto B426_000;
        }

        B428_000: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.PSH(3); goto B429_000;
            case RL: state = state.DIV; goto B427_000;
        }

        B429_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.PSH(1); goto B430_000;
            case RL: state = state.POP; goto B428_000;
        }

        B430_000: switch (state.PT) // Size = 2, Colour = cyan
        {
            case LR: state = state.PSH(2); goto B431_000;
            case RL: state = state.POP; goto B429_000;
        }

        B431_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B432_000;
            case RL: state = state.POP; goto B430_000;
        }

        B432_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B433_000;
            case RL: state = state.OUTc; goto B431_000;
        }

        B433_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DUP; goto B434_000;
            case RL: state = state.NOT; goto B432_000;
        }

        B434_000: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B435_000;
            case LL: state = state[RL].DIV; goto B433_000;
            case RL: state = state.DIV; goto B433_000;
        }

        B435_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B436_000;
            case LL: state = state.POP; goto B434_000;
            case RL: state = state.POP; goto B434_000;
        }

        B436_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ROL; goto B437_000;
            case LL: state = state.POP; goto B435_000;
            case RL: state = state.POP; goto B435_000;
        }

        B437_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.GT_; goto B438_000;
            case LL: state = state.NOT; goto B436_000;
            case RL: state = state.NOT; goto B436_000;
        }

        B438_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B439_000;
            case LL: state = state.GT_; goto B437_000;
            case RL: state = state.GT_; goto B437_000;
        }

        B439_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B440_000;
            case LL: state = state.ROL; goto B438_000;
            case RL: state = state.ROL; goto B438_000;
        }

        B440_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(2); goto B443_000;
            case LD: state = state.PSH(3); goto B059_046;
            case LL: state = state.SWI; goto B439_000;
            case LT: state = state[LR].PSH(2); goto B443_000;
        }

        B443_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B444_000;
            case RL: state = state.POP; goto B442_000;
        }

        B059_046: state = state.PSH(1); goto B058_047; // PT = LD, Size = 1, Colour = red

        B444_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.ROL; goto B445_000;
            case RL: state = state.POP; goto B443_000;
        }

        B058_047: state = state.PSH(2); goto B059_048; // PT = LD, Size = 2, Colour = dark red

        B445_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LR: state = state.PSH(2); goto B446_000;
            case RL: state = state.NOT; goto B444_000;
        }

        B059_048: state = state.SUB; goto B059_049; // PT = LD, Size = 1, Colour = light red

        B446_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.ADD; goto B447_000;
            case RL: state = state.POP; goto B445_000;
        }

        B059_049: state = state.ROL; goto B058_050; // PT = LD, Size = 1, Colour = yellow

        B447_000: switch (state.PT) // Size = 3, Colour = dark magenta
        {
            case LR: state = state.PSH(3); goto B448_000;
            case LL: state = state[RL].INc; goto B446_000;
            case RL: state = state.INc; goto B446_000;
        }

        B058_050: state = state.PSH(2); goto B059_051; // PT = LD, Size = 2, Colour = dark magenta

        B448_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.PSH(1); goto B449_000;
            case LL: state = state.POP; goto B447_000;
            case RL: state = state.POP; goto B447_000;
        }

        B059_051: state = state.PSH(1); goto B059_052; // PT = LD, Size = 1, Colour = light magenta

        B449_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROL; goto B450_000;
            case LL: state = state.POP; goto B448_000;
            case RL: state = state.POP; goto B448_000;
        }

        B059_052: state = state.ROL; goto B059_053; // PT = LD, Size = 1, Colour = magenta

        B450_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.DUP; goto B451_000;
            case LL: state = state.NOT; goto B449_000;
            case RL: state = state.NOT; goto B449_000;
        }

        B059_053: state = state.PSH(1); goto B059_054; // PT = LD, Size = 1, Colour = dark cyan

        B451_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.NOT; goto B452_000;
            case LL: state = state.DIV; goto B450_000;
            case RL: state = state.DIV; goto B450_000;
        }

        B059_054: state = state.ADD; goto B059_055; // PT = LD, Size = 1, Colour = light cyan

        B452_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.ROT; goto B453_000;
            case LL: state = state.ROL; goto B451_000;
            case RL: state = state.ROL; goto B451_000;
        }

        B059_055: state = state.PSH(1); goto B059_056; // PT = LD, Size = 1, Colour = light blue

        B453_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(3); goto B456_000;
            case LD: state = state[RR].PSH(1); goto B497_000;
            case LL: state = state.SWI; goto B452_000;
            case LT: state = state[LR].PSH(3); goto B456_000;
        }

        B059_056: state = state.ROL; goto B059_057; // PT = LD, Size = 1, Colour = blue

        B456_000: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.PSH(1); goto B457_000;
            case RL: state = state.POP; goto B455_000;
        }

        B497_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case RR: state = state.ADD; goto B498_000;
            case RL: state = state.POP; goto B496_000;
        }

        B059_057: state = state.PSH(1); goto B059_058; // PT = LD, Size = 1, Colour = dark green

        B457_000: switch (state.PT) // Size = 2, Colour = red
        {
            case LR: state = state.PSH(2); goto B458_000;
            case RL: state = state.POP; goto B456_000;
        }

        B498_000: switch (state.PT) // Size = 3, Colour = red
        {
            case RR: state = state[LR].PSH(3); goto B499_000;
            case RL: state = state.INc; goto B497_000;
        }

        B059_058: state = state.NOT; goto B050_059; // PT = LD, Size = 1, Colour = light green

        B458_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B459_000;
            case RL: state = state.POP; goto B457_000;
        }

        B499_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(1); goto B500_000;
            case RL: state = state.POP; goto B498_000;
        }

        B050_059: state = state.PSH(10); goto B048_060; // PT = LD, Size = 10, Colour = dark blue

        B459_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROL; goto B460_000;
            case RL: state = state.OUTc; goto B458_000;
        }

        B500_000: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state.PSH(2); goto B501_000;
            case RL: state = state.POP; goto B499_000;
        }

        B048_060: state = state.PSH(12); goto B037_061; // PT = LD, Size = 12, Colour = light blue

        B460_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.DUP; goto B461_000;
            case RL: state = state.NOT; goto B459_000;
        }

        B501_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B502_000;
            case RL: state = state.POP; goto B500_000;
        }

        B037_061: state = state.PSH(23); goto B058_062; // PT = LD, Size = 23, Colour = blue

        B461_000: switch (state.PT) // Size = 5, Colour = cyan
        {
            case LR: state = state.PSH(5); goto B462_000;
            case RL: state = state.DIV; goto B460_000;
        }

        B502_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROL; goto B503_000;
            case RL: state = state.OUTc; goto B501_000;
        }

        B058_062: state = state.PSH(2); goto B059_063; // PT = LD, Size = 2, Colour = dark blue

        B462_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.PSH(1); goto B463_000;
            case RL: state = state.POP; goto B461_000;
        }

        B503_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.DUP; goto B504_000;
            case RL: state = state.NOT; goto B502_000;
        }

        B059_063: state = state.MUL; goto B059_064; // PT = LD, Size = 1, Colour = light blue

        B463_000: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROL; goto B464_000;
            case RL: state = state.POP; goto B462_000;
        }

        B504_000: switch (state.PT) // Size = 5, Colour = light cyan
        {
            case LR: state = state.PSH(5); goto B505_000;
            case LL: state = state[RL].DIV; goto B503_000;
            case RL: state = state.DIV; goto B503_000;
        }

        B059_064: state = state.ADD; goto B059_065; // PT = LD, Size = 1, Colour = dark magenta

        B464_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.PSH(1); goto B465_000;
            case RL: state = state.NOT; goto B463_000;
        }

        B505_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B506_000;
            case LL: state = state.POP; goto B504_000;
            case RL: state = state.POP; goto B504_000;
        }

        B059_065: state = state.PSH(1); goto B037_066; // PT = LD, Size = 1, Colour = dark red

        B465_000: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROL; goto B466_000;
            case RL: state = state.POP; goto B464_000;
        }

        B506_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROL; goto B507_000;
            case LL: state = state.POP; goto B505_000;
            case RL: state = state.POP; goto B505_000;
        }

        B037_066: state = state.PSH(23); goto B055_067; // PT = LD, Size = 23, Colour = light red

        B466_000: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LR: state = state.PSH(2); goto B467_000;
            case RL: state = state.NOT; goto B465_000;
        }

        B507_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.PSH(1); goto B508_000;
            case LL: state = state.NOT; goto B506_000;
            case RL: state = state.NOT; goto B506_000;
        }

        B442_000: state = state.SWI; goto B439_000; // PT = RL, Size = 2, Colour = red

        B055_067: state = state.PSH(5); goto B059_068; // PT = LD, Size = 5, Colour = red

        B467_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(1); goto B468_000;
            case RL: state = state.POP; goto B466_000;
        }

        B508_000: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.ROL; goto B509_000;
            case LL: state = state.POP; goto B507_000;
            case RL: state = state.POP; goto B507_000;
        }

        B059_068: state = state.MUL; goto B059_069; // PT = LD, Size = 1, Colour = dark red

        B468_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.ROL; goto B469_000;
            case RL: state = state.POP; goto B467_000;
        }

        B509_000: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.PSH(1); goto B510_000;
            case LL: state = state.NOT; goto B508_000;
            case RL: state = state.NOT; goto B508_000;
        }

        B059_069: state = state.ADD; goto B059_070; // PT = LD, Size = 1, Colour = yellow

        B469_000: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LR: state = state.PSH(2); goto B470_000;
            case RL: state = state.NOT; goto B468_000;
        }

        B510_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.ROT; goto B511_000;
            case LL: state = state.POP; goto B509_000;
            case RL: state = state.POP; goto B509_000;
        }

        B059_070: state = state[RL].DUP; goto B042_071; // PT = LD, Size = 1, Colour = green

        B470_000: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.PSH(1); goto B471_000;
            case RL: state = state.POP; goto B469_000;
        }

        B511_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state[LR].PSH(3); goto B402_000;
            case LL: state = state.SWI; goto B510_000;
            case LT: state = state[LR].PSH(3); goto B402_000;
        }

        B042_071: state = state.PSH(1); goto B041_071; // PT = RL, Size = 1, Colour = light blue

        B471_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROL; goto B472_000;
            case RL: state = state.POP; goto B470_000;
        }

        B041_071: state = state.SUB; goto B039_071; // PT = RL, Size = 1, Colour = blue

        B472_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B473_000;
            case RL: state = state.NOT; goto B471_000;
        }

        B039_071: state = state.PSH(2); goto B038_071; // PT = RL, Size = 2, Colour = dark magenta

        B473_000: switch (state.PT) // Size = 3, Colour = light magenta
        {
            case LR: state = state.PSH(3); goto B474_000;
            case RL: state = state.DIV; goto B472_000;
        }

        B038_071: state = state.ROT; goto B037_071; // PT = RL, Size = 1, Colour = light magenta

        B474_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.PSH(1); goto B475_000;
            case RL: state = state.POP; goto B473_000;
        }

        B037_071: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B041_073;
            case RD: state = state[LR].DUP; goto B041_073;
            case RL: state = state[RR].DUP; goto B041_073;
            case RT: state = state[LR].DUP; goto B041_073;
        }

        B475_000: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LR: state = state.PSH(2); goto B476_000;
            case RL: state = state.POP; goto B474_000;
        }

        B041_073: switch (state.PT) // Size = 10, Colour = red
        {
            case LR: state = state.PSH(10); goto B051_073;
            case RR: state = state.PSH(10); goto B051_073;
        }

        B476_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B477_000;
            case RL: state = state.POP; goto B475_000;
        }

        B051_073: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B052_073;
            case RR: state = state.SUB; goto B052_073;
        }

        B477_000: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROL; goto B478_000;
            case RL: state = state.OUTc; goto B476_000;
        }

        B052_073: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state[RD].DUP; goto B057_075;
            case RR: state = state[LD].DUP; goto B057_075;
        }

        B478_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.DUP; goto B479_000;
            case RL: state = state.NOT; goto B477_000;
        }

        B057_075: switch (state.PT) // Size = 3, Colour = red
        {
            case LD: state = state.PSH(3); goto B059_076;
            case RD: state = state[LD].PSH(3); goto B059_076;
        }

        B479_000: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LR: state = state.PSH(3); goto B480_000;
            case LL: state = state[RL].DIV; goto B478_000;
            case RL: state = state.DIV; goto B478_000;
        }

        B059_076: state = state.ADD; goto B051_077; // PT = LD, Size = 1, Colour = dark red

        B480_000: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.PSH(1); goto B481_000;
            case LL: state = state.POP; goto B479_000;
            case RL: state = state.POP; goto B479_000;
        }

        B051_077: state = state.PSH(9); goto B037_078; // PT = LD, Size = 9, Colour = dark yellow

        B481_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.ROL; goto B482_000;
            case LL: state = state.POP; goto B480_000;
            case RL: state = state.POP; goto B480_000;
        }

        B037_078: state = state.PSH(23); goto B059_079; // PT = LD, Size = 23, Colour = light yellow

        B482_000: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.GT_; goto B483_000;
            case LL: state = state.NOT; goto B481_000;
            case RL: state = state.NOT; goto B481_000;
        }

        B059_079: state = state.ADD; goto B052_080; // PT = LD, Size = 1, Colour = yellow

        B483_000: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B484_000;
            case LL: state = state.GT_; goto B482_000;
            case RL: state = state.GT_; goto B482_000;
        }

        B052_080: state = state.PSH(8); goto B037_081; // PT = LD, Size = 8, Colour = green

        B401_000: state = state.NOT; goto B398_000; // PT = RL, Size = 3, Colour = cyan

        B484_000: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.NOT; goto B485_000;
            case LL: state = state.ROL; goto B483_000;
            case RL: state = state.ROL; goto B483_000;
        }

        B037_081: state = state.PSH(23); goto B056_082; // PT = LD, Size = 23, Colour = dark green

        B485_000: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.ROT; goto B486_000;
            case LL: state = state.ROL; goto B484_000;
            case RL: state = state.ROL; goto B484_000;
        }

        B496_000: state = state[RR].PSH(1); goto B497_000; // PT = RL, Size = 1, Colour = light magenta

        B056_082: state = state.PSH(4); goto B059_083; // PT = LD, Size = 4, Colour = light green

        B486_000: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.PSH(2); goto B489_000;
            case LD: state = state.PSH(3); goto B015_046;
            case LL: state = state.SWI; goto B485_000;
            case LT: state = state[LR].PSH(2); goto B489_000;
        }

        B059_083: state = state.MUL; goto B059_084; // PT = LD, Size = 1, Colour = green

        B489_000: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(1); goto B490_000;
            case LL: state = state.POP; goto B488_000;
            case RL: state = state.POP; goto B488_000;
        }

        B015_046: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B014_047;
            case RT: state = state.POP; goto B013_045;
        }

        B059_084: state = state.ADD; goto B059_085; // PT = LD, Size = 1, Colour = light cyan

        B490_000: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.ROL; goto B491_000;
            case LL: state = state.POP; goto B489_000;
            case RL: state = state.POP; goto B489_000;
        }

        B014_047: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B015_048;
            case RT: state = state.POP; goto B015_046;
        }

        B059_085: state = state.DUP; goto B059_086; // PT = LD, Size = 1, Colour = light blue

        B491_000: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B492_000;
            case LL: state = state.NOT; goto B490_000;
            case RL: state = state.NOT; goto B490_000;
        }

        B015_048: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B015_049;
            case RT: state = state.POP; goto B014_047;
        }

        B059_086: state = state.PSH(1); goto B059_087; // PT = LD, Size = 1, Colour = light green

        B492_000: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.ROT; goto B493_000;
            case LL: state = state.POP; goto B491_000;
            case RL: state = state.POP; goto B491_000;
        }

        B015_049: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROL; goto B015_050;
            case RT: state = state.OUTc; goto B015_048;
        }

        B059_087: state = state.ADD; goto B059_088; // PT = LD, Size = 1, Colour = green

        B493_000: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state[LD].PSH(3); goto B025_046;
            case LD: state = state.PSH(3); goto B025_046;
            case LL: state = state.SWI; goto B492_000;
            case LT: state = state[LD].PSH(3); goto B025_046;
        }

        B015_050: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.DUP; goto B013_051;
            case RT: state = state.NOT; goto B015_049;
        }

        B059_088: state = state.DUP; goto B045_089; // PT = LD, Size = 1, Colour = cyan

        B025_046: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B024_047;
            case RT: state = state.POP; goto B023_045;
        }

        B013_051: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LD: state = state.PSH(3); goto B015_052;
            case RT: state = state.DIV; goto B015_050;
        }

        B045_089: state = state.PSH(15); goto B059_090; // PT = LD, Size = 15, Colour = yellow

        B024_047: switch (state.PT) // Size = 2, Colour = dark red
        {
            case LD: state = state.PSH(2); goto B025_048;
            case RT: state = state.POP; goto B025_046;
        }

        B015_052: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B015_053;
            case RT: state = state.POP; goto B013_051;
        }

        B059_090: state = state.ADD; goto B059_091; // PT = LD, Size = 1, Colour = dark yellow

        B025_048: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.SUB; goto B025_049;
            case RT: state = state.POP; goto B024_047;
        }

        B015_053: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROL; goto B015_054;
            case RT: state = state.POP; goto B015_052;
        }

        B059_091: state = state[RL].DUP; goto B042_092; // PT = LD, Size = 1, Colour = dark green

        B025_049: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROL; goto B025_050;
            case RT: state = state.OUTc; goto B025_048;
        }

        B015_054: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B014_055;
            case RT: state = state.NOT; goto B015_053;
        }

        B042_092: state = state.PSH(2); goto B041_092; // PT = RL, Size = 2, Colour = light blue

        B025_050: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.DUP; goto B023_051;
            case RT: state = state.NOT; goto B025_049;
        }

        B488_000: switch (state.PT) // Size = 2, Colour = blue
        {
            case LL: state = state[RL].SWI; goto B485_000;
            case RL: state = state.SWI; goto B485_000;
        }

        B014_055: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LD: state = state.PSH(2); goto B015_056;
            case LT: state = state[RT].POP; goto B015_054;
            case RT: state = state.POP; goto B015_054;
        }

        B041_092: state = state.SUB; goto B039_092; // PT = RL, Size = 1, Colour = blue

        B023_051: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LD: state = state.PSH(3); goto B025_052;
            case RT: state = state.DIV; goto B025_050;
        }

        B015_056: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.SUB; goto B015_057;
            case LT: state = state.POP; goto B014_055;
            case RT: state = state.POP; goto B014_055;
        }

        B039_092: state = state.PSH(2); goto B038_092; // PT = RL, Size = 2, Colour = dark magenta

        B025_052: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B025_053;
            case RT: state = state.POP; goto B023_051;
        }

        B015_057: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B015_058;
            case LT: state = state.OUTc; goto B015_056;
            case RT: state = state.OUTc; goto B015_056;
        }

        B038_092: state = state.ROT; goto B037_092; // PT = RL, Size = 1, Colour = light magenta

        B025_053: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROL; goto B025_054;
            case RT: state = state.POP; goto B025_052;
        }

        B015_058: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B015_059;
            case LT: state = state.NOT; goto B015_057;
            case RT: state = state.NOT; goto B015_057;
        }

        B037_092: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B041_094;
            case RD: state = state[LR].DUP; goto B041_094;
            case RL: state = state[RR].DUP; goto B041_094;
            case RT: state = state[LR].DUP; goto B041_094;
        }

        B025_054: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B024_055;
            case RT: state = state.NOT; goto B025_053;
        }

        B015_059: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.SUB; goto B015_060;
            case LT: state = state.POP; goto B015_058;
            case RT: state = state.POP; goto B015_058;
        }

        B041_094: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B044_094;
            case RR: state = state.PSH(3); goto B044_094;
        }

        B024_055: switch (state.PT) // Size = 2, Colour = light yellow
        {
            case LD: state = state.PSH(2); goto B025_056;
            case RT: state = state.POP; goto B025_054;
        }

        B015_060: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.DUP; goto B015_061;
            case LT: state = state.OUTc; goto B015_059;
            case RT: state = state.OUTc; goto B015_059;
        }

        B044_094: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B045_094;
            case RR: state = state.SUB; goto B045_094;
        }

        B025_056: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.SUB; goto B025_057;
            case RT: state = state.POP; goto B024_055;
        }

        B015_061: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.NOT; goto B015_062;
            case LT: state = state.DIV; goto B015_060;
            case RT: state = state.DIV; goto B015_060;
        }

        B045_094: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B046_094;
            case RR: state = state.DUP; goto B046_094;
        }

        B380_000: state = state.SWI; goto B377_000; // PT = RL, Size = 1, Colour = light cyan

        B025_057: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B025_058;
            case RT: state = state.OUTc; goto B025_056;
        }

        B015_062: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROT; goto B015_063;
            case LT: state = state.ROL; goto B015_061;
            case RT: state = state.ROL; goto B015_061;
        }

        B046_094: switch (state.PT) // Size = 4, Colour = light magenta
        {
            case LR: state = state.PSH(4); goto B050_094;
            case RR: state = state.PSH(4); goto B050_094;
        }

        B025_058: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B025_059;
            case RT: state = state.NOT; goto B025_057;
        }

        B015_063: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state[LD].PSH(3); goto B015_066;
            case LD: state = state.PSH(3); goto B015_066;
            case LL: state = state[LD].PSH(3); goto B015_100;
            case LT: state = state.SWI; goto B015_062;
        }

        B050_094: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ADD; goto B051_094;
            case RR: state = state.ADD; goto B051_094;
        }

        B025_059: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B024_060;
            case RT: state = state.POP; goto B025_058;
        }

        B015_066: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B014_067;
            case RT: state = state.POP; goto B013_065;
        }

        B015_100: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B014_101;
            case RT: state = state.POP; goto B013_099;
        }

        B051_094: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state[RD].PSH(9); goto B037_097;
            case RR: state = state[LD].PSH(9); goto B037_097;
        }

        B024_060: switch (state.PT) // Size = 2, Colour = yellow
        {
            case LD: state = state.PSH(2); goto B025_061;
            case RT: state = state.INc; goto B025_059;
        }

        B014_067: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B015_068;
            case RT: state = state.POP; goto B015_066;
        }

        B014_101: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B015_102;
            case RT: state = state.POP; goto B015_100;
        }

        B037_097: switch (state.PT) // Size = 23, Colour = light green
        {
            case LD: state = state.PSH(23); goto B059_098;
            case RD: state = state[LD].PSH(23); goto B059_098;
        }

        B025_061: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B025_062;
            case RT: state = state.POP; goto B024_060;
        }

        B015_068: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B015_069;
            case RT: state = state.POP; goto B014_067;
        }

        B015_102: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B015_103;
            case RT: state = state.POP; goto B014_101;
        }

        B059_098: state = state.ADD; goto B051_099; // PT = LD, Size = 1, Colour = green

        B025_062: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B023_063;
            case RT: state = state.POP; goto B025_061;
        }

        B015_069: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_070;
            case RT: state = state.OUTc; goto B015_068;
        }

        B015_103: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_104;
            case RT: state = state.OUTc; goto B015_102;
        }

        B051_099: state = state.PSH(9); goto B037_100; // PT = LD, Size = 9, Colour = cyan

        B023_063: switch (state.PT) // Size = 3, Colour = magenta
        {
            case LD: state = state.PSH(3); goto B025_064;
            case RT: state = state.NOT; goto B025_062;
        }

        B015_070: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B013_071;
            case RT: state = state.NOT; goto B015_069;
        }

        B015_104: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B011_105;
            case RT: state = state.NOT; goto B015_103;
        }

        B037_100: state = state.PSH(23); goto B056_101; // PT = LD, Size = 23, Colour = dark cyan

        B025_064: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.PSH(1); goto B024_065;
            case RT: state = state.POP; goto B023_063;
        }

        B013_071: switch (state.PT) // Size = 3, Colour = yellow
        {
            case LD: state = state.PSH(3); goto B015_072;
            case RT: state = state.DIV; goto B015_070;
        }

        B011_105: switch (state.PT) // Size = 5, Colour = yellow
        {
            case LD: state = state.PSH(5); goto B015_106;
            case LT: state = state[RT].DIV; goto B015_104;
            case RT: state = state.DIV; goto B015_104;
        }

        B056_101: state = state.PSH(4); goto B059_102; // PT = LD, Size = 4, Colour = light cyan

        B024_065: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LD: state = state.PSH(2); goto B025_066;
            case RT: state = state.POP; goto B025_064;
        }

        B015_072: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B015_073;
            case RT: state = state.POP; goto B013_071;
        }

        B015_106: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B015_107;
            case LT: state = state.POP; goto B011_105;
            case RT: state = state.POP; goto B011_105;
        }

        B059_102: state = state.MUL; goto B059_103; // PT = LD, Size = 1, Colour = cyan

        B025_066: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.SUB; goto B025_067;
            case RT: state = state.POP; goto B024_065;
        }

        B015_073: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B015_074;
            case RT: state = state.POP; goto B015_072;
        }

        B015_107: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B015_108;
            case LT: state = state.POP; goto B015_106;
            case RT: state = state.POP; goto B015_106;
        }

        B059_103: state = state.ADD; goto B059_104; // PT = LD, Size = 1, Colour = light blue

        B025_067: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B025_068;
            case RT: state = state.OUTc; goto B025_066;
        }

        B015_074: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B014_075;
            case RT: state = state.NOT; goto B015_073;
        }

        B015_108: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B015_109;
            case LT: state = state.NOT; goto B015_107;
            case RT: state = state.NOT; goto B015_107;
        }

        B059_104: state = state.DUP; goto B057_105; // PT = LD, Size = 1, Colour = light magenta

        B025_068: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.DUP; goto B021_069;
            case RT: state = state.NOT; goto B025_067;
        }

        B014_075: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B015_076;
            case RT: state = state.POP; goto B015_074;
        }

        B015_109: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROL; goto B015_110;
            case LT: state = state.POP; goto B015_108;
            case RT: state = state.POP; goto B015_108;
        }

        B057_105: state = state.PSH(3); goto B059_106; // PT = LD, Size = 3, Colour = light cyan

        B021_069: switch (state.PT) // Size = 5, Colour = light green
        {
            case LD: state = state.PSH(5); goto B025_070;
            case RT: state = state.DIV; goto B025_068;
        }

        B015_076: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.SUB; goto B015_077;
            case RT: state = state.POP; goto B014_075;
        }

        B015_110: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B015_111;
            case LT: state = state.NOT; goto B015_109;
            case RT: state = state.NOT; goto B015_109;
        }

        B059_106: state = state.ADD; goto B059_107; // PT = LD, Size = 1, Colour = cyan

        B025_070: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(1); goto B025_071;
            case RT: state = state.POP; goto B021_069;
        }

        B015_077: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ROL; goto B014_078;
            case RT: state = state.OUTc; goto B015_076;
        }

        B015_111: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROT; goto B015_112;
            case LT: state = state.POP; goto B015_110;
            case RT: state = state.POP; goto B015_110;
        }

        B059_107: state = state.DUP; goto B048_108; // PT = LD, Size = 1, Colour = blue

        B025_071: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.ROL; goto B025_072;
            case RT: state = state.POP; goto B025_070;
        }

        B014_078: switch (state.PT) // Size = 2, Colour = dark blue
        {
            case LD: state = state.PSH(2); goto B015_079;
            case RT: state = state.NOT; goto B015_077;
        }

        B015_112: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state[RD].PSH(1); goto B015_095;
            case LD: state = state.PSH(1); goto B015_095;
            case LL: state = state[RD].PSH(1); goto B015_095;
            case LT: state = state.SWI; goto B015_111;
        }

        B455_000: state = state.SWI; goto B452_000; // PT = RL, Size = 3, Colour = dark red

        B048_108: state = state.PSH(12); goto B059_109; // PT = LD, Size = 12, Colour = green

        B025_072: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B025_073;
            case RT: state = state.NOT; goto B025_071;
        }

        B015_079: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B015_080;
            case RT: state = state.POP; goto B014_078;
        }

        B015_095: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.ROT; goto B015_096;
            case LT: state = state.POP; goto B015_094;
            case RD: state = state.ROT; goto B015_096;
            case RT: state = state.POP; goto B015_094;
        }

        B059_109: state = state.ADD; goto B043_110; // PT = LD, Size = 1, Colour = dark green

        B025_073: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ROL; goto B023_074;
            case RT: state = state.POP; goto B025_072;
        }

        B015_080: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B013_081;
            case RT: state = state.POP; goto B015_079;
        }

        B015_096: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state[LR].PSH(3); goto B402_000;
            case LL: state = state[LR].PSH(3); goto B402_000;
            case LT: state = state.SWI; goto B015_095;
            case RR: state = state[LR].PSH(3); goto B402_000;
            case RD: state = state[LR].PSH(3); goto B402_000;
            case RL: state = state[LR].PSH(3); goto B402_000;
            case RT: state = state.SWI; goto B015_095;
        }

        B043_110: state = state.PSH(17); goto B059_111; // PT = LD, Size = 17, Colour = dark cyan

        B023_074: switch (state.PT) // Size = 3, Colour = dark blue
        {
            case LD: state = state.PSH(3); goto B025_075;
            case RT: state = state.NOT; goto B025_073;
        }

        B013_081: switch (state.PT) // Size = 3, Colour = dark green
        {
            case LD: state = state.PSH(3); goto B015_082;
            case RT: state = state.NOT; goto B015_080;
        }

        B059_111: state = state[RL].PSH(2); goto B057_114; // PT = LD, Size = 1, Colour = light cyan

        B025_075: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.PSH(1); goto B024_076;
            case RT: state = state.POP; goto B023_074;
        }

        B015_082: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.PSH(1); goto B014_083;
            case RT: state = state.POP; goto B013_081;
        }

        B015_094: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state.NOT; goto B015_091;
            case RT: state = state.NOT; goto B015_091;
        }

        B057_114: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B058_114;
            case LL: state = state.PSH(1); goto B056_114;
            case RR: state = state.POP; goto B058_114;
            case RL: state = state.PSH(1); goto B056_114;
        }

        B024_076: switch (state.PT) // Size = 2, Colour = blue
        {
            case LD: state = state.PSH(2); goto B025_077;
            case RT: state = state.POP; goto B025_075;
        }

        B014_083: switch (state.PT) // Size = 2, Colour = green
        {
            case LD: state = state.PSH(2); goto B015_084;
            case RT: state = state.POP; goto B015_082;
        }

        B015_091: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.ROL; goto B015_092;
            case LT: state = state.POP; goto B015_090;
            case RT: state = state.POP; goto B015_090;
        }

        B013_045: state = state[LD].PSH(3); goto B015_046; // PT = RT, Size = 3, Colour = light red

        B056_114: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B057_114;
            case LL: state = state.ROL; goto B055_114;
            case RR: state = state.POP; goto B057_114;
            case RL: state = state.ROL; goto B055_114;
        }

        B025_077: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.SUB; goto B025_078;
            case RT: state = state.POP; goto B024_076;
        }

        B015_084: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.SUB; goto B015_085;
            case RT: state = state.POP; goto B014_083;
        }

        B015_090: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.PSH(1); goto B015_091;
            case LT: state = state.NOT; goto B015_089;
            case RT: state = state.NOT; goto B015_089;
        }

        B055_114: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B056_114;
            case LL: state = state.OUTc; goto B054_114;
            case RR: state = state.NOT; goto B056_114;
            case RL: state = state.OUTc; goto B054_114;
        }

        B025_078: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B025_079;
            case RT: state = state.OUTc; goto B025_077;
        }

        B015_085: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROL; goto B015_086;
            case RT: state = state.OUTc; goto B015_084;
        }

        B015_089: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROL; goto B015_090;
            case LT: state = state.POP; goto B015_088;
            case RT: state = state.POP; goto B015_088;
        }

        B054_114: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B055_114;
            case LL: state = state.PSH(1); goto B053_114;
            case RR: state = state.SUB; goto B055_114;
            case RL: state = state.PSH(1); goto B053_114;
        }

        B025_079: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.DUP; goto B021_080;
            case RT: state = state.NOT; goto B025_078;
        }

        B015_086: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.DUP; goto B011_087;
            case RT: state = state.NOT; goto B015_085;
        }

        B015_088: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.PSH(1); goto B015_089;
            case LT: state = state.POP; goto B011_087;
            case RT: state = state.POP; goto B011_087;
        }

        B053_114: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B054_114;
            case LL: state = state.SUB; goto B052_114;
            case RR: state = state.POP; goto B054_114;
            case RL: state = state.SUB; goto B052_114;
        }

        B021_080: switch (state.PT) // Size = 5, Colour = yellow
        {
            case LD: state = state.PSH(5); goto B025_081;
            case LT: state = state[RT].DIV; goto B025_079;
            case RT: state = state.DIV; goto B025_079;
        }

        B011_087: switch (state.PT) // Size = 5, Colour = magenta
        {
            case LD: state = state.PSH(5); goto B015_088;
            case LT: state = state[RT].DIV; goto B015_086;
            case RT: state = state.DIV; goto B015_086;
        }

        B052_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B053_114;
            case LL: state = state.DUP; goto B051_114;
            case RR: state = state.OUTc; goto B053_114;
            case RL: state = state.DUP; goto B051_114;
        }

        B025_081: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B025_082;
            case LT: state = state.POP; goto B021_080;
            case RT: state = state.POP; goto B021_080;
        }

        B051_114: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B052_114;
            case LL: state = state.NOT; goto B048_114;
            case RR: state = state.DIV; goto B052_114;
            case RL: state = state.NOT; goto B048_114;
        }

        B025_082: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B025_083;
            case LT: state = state.POP; goto B025_081;
            case RT: state = state.POP; goto B025_081;
        }

        B048_114: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B051_114;
            case LL: state = state.PSH(3); goto B047_114;
            case RR: state = state.ROL; goto B051_114;
            case RL: state = state.PSH(3); goto B047_114;
        }

        B025_083: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.PSH(1); goto B025_084;
            case LT: state = state.NOT; goto B025_082;
            case RT: state = state.NOT; goto B025_082;
        }

        B047_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B048_114;
            case LL: state = state.MUL; goto B046_114;
            case RR: state = state.POP; goto B048_114;
            case RL: state = state.MUL; goto B046_114;
        }

        B025_084: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LD: state = state.ROL; goto B025_085;
            case LT: state = state.POP; goto B025_083;
            case RT: state = state.POP; goto B025_083;
        }

        B013_099: state = state[LD].PSH(3); goto B015_100; // PT = RT, Size = 3, Colour = dark blue

        B046_114: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B047_114;
            case LL: state = state.DUP; goto B045_114;
            case RR: state = state.OUTi; goto B047_114;
            case RL: state = state.DUP; goto B045_114;
        }

        B025_085: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.PSH(1); goto B025_086;
            case LT: state = state.NOT; goto B025_084;
            case RT: state = state.NOT; goto B025_084;
        }

        B015_092: state = state.PSH(1); goto B015_095; // PT = LD, Size = 1, Colour = light yellow

        B045_114: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B046_114;
            case LL: state = state.ROT; goto B044_114;
            case RR: state = state.DIV; goto B046_114;
            case RL: state = state.ROT; goto B044_114;
        }

        B025_086: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.ROT; goto B025_087;
            case LT: state = state.POP; goto B025_085;
            case RT: state = state.POP; goto B025_085;
        }

        B044_114: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B045_114;
            case LD: state = state.ROT; goto B044_115;
            case LL: state = state.POP; goto B043_114;
            case LT: state = state[RR].SWI; goto B045_114;
            case RR: state = state.SWI; goto B045_114;
            case RD: state = state.ROT; goto B044_115;
            case RL: state = state.POP; goto B043_114;
            case RT: state = state[LR].SWI; goto B045_114;
        }

        B025_087: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.PSH(3); goto B402_000;
            case LD: state = state[LR].PSH(3); goto B402_000;
            case LL: state = state[LR].PSH(3); goto B402_000;
            case LT: state = state.SWI; goto B025_086;
        }

        B043_114: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B057_114;
            case RL: state = state.PSH(2); goto B057_114;
        }

        B044_115: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[RR].POP; goto B045_116;
            case LD: state = state[LT].SWI; goto B044_114;
            case LL: state = state[RT].SWI; goto B044_114;
            case LT: state = state.SWI; goto B044_114;
            case RR: state = state.POP; goto B045_116;
            case RD: state = state[RT].SWI; goto B044_114;
            case RL: state = state[LT].SWI; goto B044_114;
            case RT: state = state.SWI; goto B044_114;
        }

        B045_116: state = state[LD].PSH(3); goto B059_120; // PT = RR, Size = 1, Colour = cyan

        B059_120: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.PSH(1); goto B058_121;
            case RT: state = state.POP; goto B057_119;
        }

        B058_121: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LD: state = state.PSH(2); goto B059_122;
            case RT: state = state.POP; goto B059_120;
        }

        B059_122: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B059_123;
            case RT: state = state.POP; goto B058_121;
        }

        B059_123: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.ROL; goto B059_124;
            case RT: state = state.OUTc; goto B059_122;
        }

        B059_124: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LD: state = state.OUTi; goto B050_125;
            case RT: state = state.NOT; goto B059_123;
        }

        B050_125: switch (state.PT) // Size = 10, Colour = light yellow
        {
            case LD: state = state.PSH(10); goto B059_126;
            case RT: state = state.MUL; goto B059_124;
        }

        B059_126: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LD: state = state.OUTc; goto B059_127;
            case RT: state = state.POP; goto B050_125;
        }

        B059_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(1); goto B059_128;
            case RT: state = state.SUB; goto B059_126;
        }

        B059_128: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.ADD; goto B058_129;
            case RT: state = state.POP; goto B059_127;
        }

        B058_114: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state[LL].PSH(2); goto B057_114;
            case RR: state = state[RL].PSH(2); goto B057_114;
        }

        B058_129: switch (state.PT) // Size = 2, Colour = yellow
        {
            case LD: state = state.PSH(2); goto B059_130;
            case RT: state = state.INc; goto B059_128;
        }

        B059_130: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LD: state = state.PSH(1); goto B059_131;
            case RT: state = state.POP; goto B058_129;
        }

        B059_131: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.ROL; goto B059_132;
            case RT: state = state.POP; goto B059_130;
        }

        B059_132: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.DUP; goto B057_133;
            case RT: state = state.NOT; goto B059_131;
        }

        B013_065: state = state.SWI; goto B015_062; // PT = RT, Size = 3, Colour = dark blue

        B057_133: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LD: state = state.PSH(3); goto B059_134;
            case RT: state = state.DIV; goto B059_132;
        }

        B059_134: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B058_135;
            case RT: state = state.POP; goto B057_133;
        }

        B058_135: switch (state.PT) // Size = 2, Colour = light cyan
        {
            case LD: state = state.PSH(2); goto B059_136;
            case RT: state = state.POP; goto B059_134;
        }

        B059_136: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LD: state = state.SUB; goto B059_137;
            case RT: state = state.POP; goto B058_135;
        }

        B059_137: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.ROL; goto B059_138;
            case RT: state = state.OUTc; goto B059_136;
        }

        B059_138: switch (state.PT) // Size = 1, Colour = light green
        {
            case LD: state = state.DUP; goto B057_139;
            case RT: state = state.NOT; goto B059_137;
        }

        B057_139: switch (state.PT) // Size = 3, Colour = light red
        {
            case LD: state = state.PSH(3); goto B059_140;
            case LT: state = state[RT].DIV; goto B059_138;
            case RT: state = state.DIV; goto B059_138;
        }

        B059_140: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B059_141;
            case LT: state = state.POP; goto B057_139;
            case RT: state = state.POP; goto B057_139;
        }

        B059_141: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B059_142;
            case LT: state = state.POP; goto B059_140;
            case RT: state = state.POP; goto B059_140;
        }

        B059_142: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.GT_; goto B059_143;
            case LT: state = state.NOT; goto B059_141;
            case RT: state = state.NOT; goto B059_141;
        }

        B059_143: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LD: state = state.NOT; goto B059_144;
            case LT: state = state.GT_; goto B059_142;
            case RT: state = state.GT_; goto B059_142;
        }

        B059_144: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.NOT; goto B059_145;
            case LT: state = state.ROL; goto B059_143;
            case RT: state = state.ROL; goto B059_143;
        }

        B059_145: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ROT; goto B059_146;
            case LT: state = state.ROL; goto B059_144;
            case RT: state = state.ROL; goto B059_144;
        }

        B059_146: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(3); goto B063_153;
            case LD: state = state[RR].PSH(3); goto B063_153;
            case LL: state = state[LD].PSH(3); goto B059_120;
            case LT: state = state.SWI; goto B059_145;
        }

        B063_153: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROT; goto B064_153;
            case LL: state = state.POP; goto B060_153;
            case RR: state = state.ROT; goto B064_153;
            case RL: state = state.POP; goto B060_153;
        }

        B064_153: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state[LL].SWI; goto B063_153;
            case LD: state = state[RL].SWI; goto B063_153;
            case LL: state = state.SWI; goto B063_153;
            case LT: state = state[RR].PSH(3); goto B248_150;
            case RR: state = state[RL].SWI; goto B063_153;
            case RD: state = state[LL].SWI; goto B063_153;
            case RL: state = state.SWI; goto B063_153;
            case RT: state = state[LR].PSH(3); goto B248_150;
        }

        B248_150: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.ROT; goto B249_150;
            case LL: state = state.POP; goto B245_150;
            case RR: state = state.ROT; goto B249_150;
            case RL: state = state.POP; goto B245_150;
        }

        B060_153: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LL: state = state[LR].PSH(3); goto B063_153;
            case RL: state = state[RR].PSH(3); goto B063_153;
        }

        B249_150: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state[LL].SWI; goto B248_150;
            case LD: state = state[RL].SWI; goto B248_150;
            case LL: state = state.SWI; goto B248_150;
            case LT: state = state[RR].PSH(9); goto B301_045;
            case RR: state = state[RL].SWI; goto B248_150;
            case RD: state = state[LL].SWI; goto B248_150;
            case RL: state = state.SWI; goto B248_150;
            case RT: state = state[LR].PSH(9); goto B301_045;
        }

        B301_045: switch (state.PT) // Size = 23, Colour = red
        {
            case LR: state = state.PSH(23); goto B302_045;
            case RR: state = state[LR].PSH(23); goto B302_045;
        }

        B245_150: switch (state.PT) // Size = 3, Colour = cyan
        {
            case LL: state = state[LR].PSH(3); goto B248_150;
            case RL: state = state[RR].PSH(3); goto B248_150;
        }

        B302_045: state = state.ADD; goto B303_045; // PT = LR, Size = 1, Colour = dark red

        B303_045: state = state.PSH(23); goto B304_045; // PT = LR, Size = 23, Colour = dark yellow

        B304_045: state = state.PSH(5); goto B305_045; // PT = LR, Size = 5, Colour = light yellow

        B305_045: state = state.MUL; goto B306_045; // PT = LR, Size = 1, Colour = yellow

        B306_045: state = state.DUP; goto B307_045; // PT = LR, Size = 1, Colour = light green

        B307_045: state = state.PSH(10); goto B308_045; // PT = LR, Size = 10, Colour = light red

        B308_045: state = state.SUB; goto B309_045; // PT = LR, Size = 1, Colour = red

        B309_045: state = state.PSH(9); goto B310_045; // PT = LR, Size = 9, Colour = dark yellow

        B023_045: state = state[LD].PSH(3); goto B025_046; // PT = RT, Size = 3, Colour = light red

        B310_045: state = state.PSH(23); goto B311_045; // PT = LR, Size = 23, Colour = light yellow

        B311_045: state = state.ADD; goto B312_045; // PT = LR, Size = 1, Colour = yellow

        B312_045: state = state.PSH(22); goto B313_045; // PT = LR, Size = 22, Colour = green

        B313_045: state = state.PSH(23); goto B314_045; // PT = LR, Size = 23, Colour = dark green

        B314_045: state = state.PSH(4); goto B315_045; // PT = LR, Size = 4, Colour = light green

        B315_045: state = state.MUL; goto B316_045; // PT = LR, Size = 1, Colour = green

        B316_045: state = state.ADD; goto B317_045; // PT = LR, Size = 1, Colour = light cyan

        B317_045: state = state.DUP; goto B318_045; // PT = LR, Size = 1, Colour = light blue

        B318_045: state = state.PSH(13); goto B319_045; // PT = LR, Size = 13, Colour = light green

        B319_045: state = state.SUB; goto B320_045; // PT = LR, Size = 1, Colour = green

        B320_045: state = state.DUP; goto B321_045; // PT = LR, Size = 1, Colour = dark cyan

        B321_045: state = state.PSH(15); goto B322_045; // PT = LR, Size = 15, Colour = dark yellow

        B322_045: state = state.ADD; goto B323_045; // PT = LR, Size = 1, Colour = light yellow

        B323_045: state = state[RD].DUP; goto B324_055; // PT = LR, Size = 1, Colour = light green

        B057_119: state = state[LD].PSH(3); goto B059_120; // PT = RT, Size = 3, Colour = light cyan

        B324_055: state = state.PSH(8); goto B324_063; // PT = RD, Size = 8, Colour = light blue

        B324_063: state = state.SUB; goto B324_064; // PT = RD, Size = 1, Colour = blue

        B324_064: state = state.PSH(2); goto B324_066; // PT = RD, Size = 2, Colour = dark magenta

        B324_066: state = state.ROT; goto B324_067; // PT = RD, Size = 1, Colour = light magenta

        B324_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B326_055;
            case RD: state = state[RT].DUP; goto B326_055;
            case RL: state = state[LT].DUP; goto B326_055;
            case RT: state = state.DUP; goto B326_055;
        }

        B326_055: switch (state.PT) // Size = 9, Colour = red
        {
            case LT: state = state.PSH(9); goto B326_054;
            case RT: state = state.PSH(9); goto B326_054;
        }

        B326_054: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B326_053;
            case RT: state = state.ADD; goto B326_053;
        }

        B326_053: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[LD].DUP; goto B328_050;
            case RT: state = state[RD].DUP; goto B328_050;
        }

        B328_050: switch (state.PT) // Size = 13, Colour = light blue
        {
            case LD: state = state.PSH(13); goto B328_063;
            case RD: state = state.PSH(13); goto B328_063;
        }

        B328_063: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.SUB; goto B328_064;
            case RD: state = state.SUB; goto B328_064;
        }

        B328_064: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LD: state = state.PSH(2); goto B328_066;
            case RD: state = state.PSH(2); goto B328_066;
        }

        B328_066: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B328_067;
            case RD: state = state.ROT; goto B328_067;
        }

        B328_067: switch (state.PT) // Size = 4, Colour = green
        {
            case LR: state = state[RT].DUP; goto B330_059;
            case LD: state = state[LT].DUP; goto B330_059;
            case LL: state = state[RT].DUP; goto B330_059;
            case LT: state = state.DUP; goto B330_059;
            case RR: state = state[LT].DUP; goto B330_059;
            case RD: state = state[RT].DUP; goto B330_059;
            case RL: state = state[LT].DUP; goto B330_059;
            case RT: state = state.DUP; goto B330_059;
        }

        B330_059: switch (state.PT) // Size = 5, Colour = red
        {
            case LT: state = state.PSH(5); goto B330_058;
            case RT: state = state.PSH(5); goto B330_058;
        }

        B330_058: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B330_057;
            case RT: state = state.SUB; goto B330_057;
        }

        B330_057: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state[RR].DUP; goto B332_045;
            case RT: state = state[LR].DUP; goto B332_045;
        }

        B332_045: switch (state.PT) // Size = 16, Colour = light red
        {
            case LR: state = state.PSH(16); goto B333_045;
            case RR: state = state[LR].PSH(16); goto B333_045;
        }

        B333_045: state = state.SUB; goto B334_045; // PT = LR, Size = 1, Colour = red

        B334_045: state = state.PSH(9); goto B335_045; // PT = LR, Size = 9, Colour = dark yellow

        B335_045: state = state.PSH(23); goto B336_045; // PT = LR, Size = 23, Colour = light yellow

        B336_045: state = state.ADD; goto B337_045; // PT = LR, Size = 1, Colour = yellow

        B337_045: state = state.PSH(5); goto B338_045; // PT = LR, Size = 5, Colour = green

        B338_045: state = state.PSH(23); goto B339_045; // PT = LR, Size = 23, Colour = dark green

        B339_045: state = state.PSH(4); goto B340_045; // PT = LR, Size = 4, Colour = light green

        B340_045: state = state.MUL; goto B341_045; // PT = LR, Size = 1, Colour = green

        B341_045: state = state.ADD; goto B342_045; // PT = LR, Size = 1, Colour = light cyan

        B342_045: state = state.DUP; goto B343_045; // PT = LR, Size = 1, Colour = light blue

        B343_045: state = state.PSH(20); goto B344_045; // PT = LR, Size = 20, Colour = light green

        B344_045: state = state.ADD; goto B345_045; // PT = LR, Size = 1, Colour = green

        B345_045: state = state[RD].DUP; goto B346_050; // PT = LR, Size = 1, Colour = cyan

        B346_050: state = state.PSH(13); goto B346_063; // PT = RD, Size = 13, Colour = light blue

        B346_063: state = state.SUB; goto B346_064; // PT = RD, Size = 1, Colour = blue

        B346_064: state = state.PSH(2); goto B346_066; // PT = RD, Size = 2, Colour = dark magenta

        B346_066: state = state.ROT; goto B346_067; // PT = RD, Size = 1, Colour = light magenta

        B346_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B348_053;
            case RD: state = state[RT].DUP; goto B348_053;
            case RL: state = state[LT].DUP; goto B348_053;
            case RT: state = state.DUP; goto B348_053;
        }

        B348_053: switch (state.PT) // Size = 11, Colour = red
        {
            case LT: state = state.PSH(11); goto B348_052;
            case RT: state = state.PSH(11); goto B348_052;
        }

        B348_052: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.ADD; goto B348_051;
            case RT: state = state.ADD; goto B348_051;
        }

        B348_051: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state[RR].DUP; goto B350_045;
            case RT: state = state[LR].DUP; goto B350_045;
        }

        B350_045: switch (state.PT) // Size = 4, Colour = yellow
        {
            case LR: state = state.PSH(4); goto B351_045;
            case RR: state = state[LR].PSH(4); goto B351_045;
        }

        B351_045: state = state.SUB; goto B352_045; // PT = LR, Size = 1, Colour = dark yellow

        B352_045: state = state.PSH(5); goto B353_045; // PT = LR, Size = 5, Colour = light green

        B353_045: state = state.PSH(23); goto B354_045; // PT = LR, Size = 23, Colour = green

        B354_045: state = state.PSH(3); goto B355_045; // PT = LR, Size = 3, Colour = dark green

        B355_045: state = state.MUL; goto B356_045; // PT = LR, Size = 1, Colour = light green

        B356_045: state = state.ADD; goto B357_045; // PT = LR, Size = 1, Colour = dark cyan

        B357_045: state = state.PSH(9); goto B358_045; // PT = LR, Size = 9, Colour = dark blue

        B358_045: state = state.PSH(23); goto B359_045; // PT = LR, Size = 23, Colour = light blue

        B359_045: state = state.ADD; goto B360_045; // PT = LR, Size = 1, Colour = blue

        B360_045: state = state.PSH(6); goto B361_045; // PT = LR, Size = 6, Colour = magenta

        B361_045: state = state.PSH(23); goto B362_045; // PT = LR, Size = 23, Colour = dark magenta

        B362_045: state = state.PSH(5); goto B363_045; // PT = LR, Size = 5, Colour = light magenta

        B363_045: state = state.MUL; goto B364_045; // PT = LR, Size = 1, Colour = magenta

        B364_045: state = state.ADD; goto B365_045; // PT = LR, Size = 1, Colour = light red

        B365_045: state = state.DUP; goto B366_045; // PT = LR, Size = 1, Colour = light yellow

        B366_045: state = state.PSH(23); goto B367_045; // PT = LR, Size = 23, Colour = light magenta

        B367_045: state = state.SUB; goto B368_045; // PT = LR, Size = 1, Colour = magenta

        B368_045: state = state.PSH(9); goto B369_045; // PT = LR, Size = 9, Colour = dark red

        B369_045: state = state.PSH(23); goto B370_045; // PT = LR, Size = 23, Colour = light red

        B370_045: state = state.ADD; goto B371_045; // PT = LR, Size = 1, Colour = red

        B371_045: state = state.PSH(15); goto B372_045; // PT = LR, Size = 15, Colour = yellow

        B372_045: state = state.PSH(23); goto B373_045; // PT = LR, Size = 23, Colour = dark yellow

        B373_045: state = state.PSH(4); goto B374_045; // PT = LR, Size = 4, Colour = light yellow

        B374_045: state = state.MUL; goto B375_045; // PT = LR, Size = 1, Colour = yellow

        B375_045: state = state.ADD; goto B376_045; // PT = LR, Size = 1, Colour = light green

        B376_045: state = state[RD].DUP; goto B377_056; // PT = LR, Size = 1, Colour = light cyan

        B377_056: state = state.PSH(7); goto B377_063; // PT = RD, Size = 7, Colour = light blue

        B377_063: state = state.ADD; goto B377_064; // PT = RD, Size = 1, Colour = blue

        B377_064: state = state.PSH(2); goto B377_066; // PT = RD, Size = 2, Colour = magenta

        B377_066: state = state.ROT; goto B377_067; // PT = RD, Size = 1, Colour = dark magenta

        B377_067: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state[LT].DUP; goto B379_061;
            case RD: state = state[RT].DUP; goto B379_061;
            case RL: state = state[LT].DUP; goto B379_061;
            case RT: state = state.DUP; goto B379_061;
        }

        B379_061: switch (state.PT) // Size = 3, Colour = light red
        {
            case LT: state = state.PSH(3); goto B379_060;
            case RT: state = state.PSH(3); goto B379_060;
        }

        B379_060: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.SUB; goto B379_059;
            case RT: state = state.SUB; goto B379_059;
        }

        B379_059: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LT: state = state.DUP; goto B379_051;
            case RT: state = state.DUP; goto B379_051;
        }

        B379_051: switch (state.PT) // Size = 8, Colour = dark magenta
        {
            case LT: state = state.PSH(8); goto B379_050;
            case RT: state = state.PSH(8); goto B379_050;
        }

        B379_050: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state.ADD; goto B379_049;
            case RT: state = state.ADD; goto B379_049;
        }

        B379_049: switch (state.PT) // Size = 1, Colour = light red
        {
            case LT: state = state[RR].PSH(9); goto B382_045;
            case RT: state = state[LR].PSH(9); goto B382_045;
        }

        B382_045: switch (state.PT) // Size = 23, Colour = cyan
        {
            case LR: state = state.PSH(23); goto B383_045;
            case RR: state = state[LR].PSH(23); goto B383_045;
        }

        B383_045: state = state.ADD; goto B384_045; // PT = LR, Size = 1, Colour = dark cyan

        B384_045: state = state.PSH(23); goto B385_045; // PT = LR, Size = 23, Colour = dark blue

        B385_045: state = state.PSH(5); goto B386_045; // PT = LR, Size = 5, Colour = light blue

        B386_045: state = state.MUL; goto B387_045; // PT = LR, Size = 1, Colour = blue

        B387_045: state = state[RD].DUP; goto B388_053; // PT = LR, Size = 1, Colour = light magenta

        B388_053: state = state.PSH(10); goto B388_063; // PT = RD, Size = 10, Colour = light blue

        B388_063: state = state.SUB; goto B388_064; // PT = RD, Size = 1, Colour = blue

        B388_064: state = state.PSH(2); goto B388_066; // PT = RD, Size = 2, Colour = dark magenta

        B388_066: state = state.ROT; goto B388_067; // PT = RD, Size = 1, Colour = light magenta

        B388_067: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state[LT].DUP; goto B390_063;
            case RD: state = state[RT].DUP; goto B390_063;
            case RL: state = state[LT].DUP; goto B390_063;
            case RT: state = state.DUP; goto B390_063;
        }

        B390_063: switch (state.PT) // Size = 1, Colour = red
        {
            case LT: state = state.PSH(1); goto B390_062;
            case RT: state = state.PSH(1); goto B390_062;
        }

        B390_062: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LT: state = state.SUB; goto B390_061;
            case RT: state = state.SUB; goto B390_061;
        }

        B390_061: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LT: state = state[RR].DUP; goto B392_045;
            case RT: state = state[LR].DUP; goto B392_045;
        }

        B392_045: switch (state.PT) // Size = 20, Colour = light cyan
        {
            case LR: state = state.PSH(20); goto B393_045;
            case RR: state = state[LR].PSH(20); goto B393_045;
        }

        B393_045: state = state.SUB; goto B394_045; // PT = LR, Size = 1, Colour = cyan

        B394_045: state = state.PSH(9); goto B395_045; // PT = LR, Size = 9, Colour = dark blue

        B395_045: state = state.PSH(23); goto B396_045; // PT = LR, Size = 23, Colour = light blue

        B396_045: state = state.ADD; goto B397_045; // PT = LR, Size = 1, Colour = blue

        B397_045: state = state[RD].PSH(2); goto B400_047; // PT = LR, Size = 1, Colour = magenta

        B400_047: switch (state.PT) // Size = 1, Colour = red
        {
            case LD: state = state.PSH(1); goto B400_048;
            case LT: state = state.POP; goto B400_045;
            case RD: state = state.PSH(1); goto B400_048;
            case RT: state = state.POP; goto B400_045;
        }

        B400_048: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LD: state = state.ROL; goto B400_049;
            case LT: state = state.POP; goto B400_047;
            case RD: state = state.ROL; goto B400_049;
            case RT: state = state.POP; goto B400_047;
        }

        B400_049: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LD: state = state.OUTc; goto B400_050;
            case LT: state = state.NOT; goto B400_048;
            case RD: state = state.OUTc; goto B400_050;
            case RT: state = state.NOT; goto B400_048;
        }

        B400_050: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LD: state = state.PSH(1); goto B400_051;
            case LT: state = state.SUB; goto B400_049;
            case RD: state = state.PSH(1); goto B400_051;
            case RT: state = state.SUB; goto B400_049;
        }

        B400_051: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.SUB; goto B400_052;
            case LT: state = state.POP; goto B400_050;
            case RD: state = state.SUB; goto B400_052;
            case RT: state = state.POP; goto B400_050;
        }

        B400_052: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.DUP; goto B400_053;
            case LT: state = state.OUTc; goto B400_051;
            case RD: state = state.DUP; goto B400_053;
            case RT: state = state.OUTc; goto B400_051;
        }

        B400_053: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.NOT; goto B400_054;
            case LT: state = state.DIV; goto B400_052;
            case RD: state = state.NOT; goto B400_054;
            case RT: state = state.DIV; goto B400_052;
        }

        B400_054: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LD: state = state.PSH(3); goto B400_057;
            case LT: state = state.ROL; goto B400_053;
            case RD: state = state.PSH(3); goto B400_057;
            case RT: state = state.ROL; goto B400_053;
        }

        B400_057: switch (state.PT) // Size = 1, Colour = blue
        {
            case LD: state = state.MUL; goto B400_058;
            case LT: state = state.POP; goto B400_054;
            case RD: state = state.MUL; goto B400_058;
            case RT: state = state.POP; goto B400_054;
        }

        B400_058: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.DUP; goto B400_059;
            case LT: state = state.OUTi; goto B400_057;
            case RD: state = state.DUP; goto B400_059;
            case RT: state = state.OUTi; goto B400_057;
        }

        B400_059: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B400_060;
            case LT: state = state.DIV; goto B400_058;
            case RD: state = state.ROT; goto B400_060;
            case RT: state = state.DIV; goto B400_058;
        }

        B400_060: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.ROT; goto B401_060;
            case LD: state = state.POP; goto B400_061;
            case LL: state = state[RT].SWI; goto B400_059;
            case LT: state = state.SWI; goto B400_059;
            case RR: state = state.ROT; goto B401_060;
            case RD: state = state.POP; goto B400_061;
            case RL: state = state[LT].SWI; goto B400_059;
            case RT: state = state.SWI; goto B400_059;
        }

        B400_061: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(2); goto B400_047;
            case RD: state = state.PSH(2); goto B400_047;
        }

        B401_060: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[LL].SWI; goto B400_060;
            case LD: state = state[RL].SWI; goto B400_060;
            case LL: state = state.SWI; goto B400_060;
            case LT: state = state[RT].POP; goto B402_059;
            case RR: state = state[RL].SWI; goto B400_060;
            case RD: state = state[LL].SWI; goto B400_060;
            case RL: state = state.SWI; goto B400_060;
            case RT: state = state.POP; goto B402_059;
        }

        B402_059: state = state[LR].PSH(1); goto B404_045; // PT = RT, Size = 1, Colour = cyan

        B404_045: switch (state.PT) // Size = 2, Colour = dark magenta
        {
            case LR: state = state.PSH(2); goto B405_045;
            case LL: state = state[RL].POP; goto B403_045;
            case RR: state = state[LR].PSH(2); goto B405_045;
            case RL: state = state.POP; goto B403_045;
        }

        B405_045: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.SUB; goto B406_045;
            case LL: state = state.POP; goto B404_045;
            case RL: state = state.POP; goto B404_045;
        }

        B406_045: state = state.PSH(1); goto B409_045; // PT = LR, Size = 1, Colour = red

        B409_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B410_045;
            case LL: state = state.POP; goto B408_045;
            case RR: state = state.ADD; goto B410_045;
            case RL: state = state.POP; goto B408_045;
        }

        B410_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.DUP; goto B411_045;
            case LL: state = state.INc; goto B409_045;
            case RR: state = state.DUP; goto B411_045;
            case RL: state = state.INc; goto B409_045;
        }

        B411_045: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B412_045;
            case LL: state = state.DIV; goto B410_045;
            case RR: state = state.DUP; goto B412_045;
            case RL: state = state.DIV; goto B410_045;
        }

        B412_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B413_045;
            case LL: state = state.DIV; goto B411_045;
            case RR: state = state.NOT; goto B413_045;
            case RL: state = state.DIV; goto B411_045;
        }

        B413_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROT; goto B414_045;
            case LL: state = state.ROL; goto B412_045;
            case RR: state = state.ROT; goto B414_045;
            case RL: state = state.ROL; goto B412_045;
        }

        B414_045: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B415_045;
            case LD: state = state.POP; goto B414_046;
            case LL: state = state.SWI; goto B413_045;
            case LT: state = state[RR].PSH(1); goto B415_045;
            case RR: state = state.PSH(1); goto B415_045;
            case RD: state = state.POP; goto B414_046;
            case RL: state = state.SWI; goto B413_045;
            case RT: state = state[LR].PSH(1); goto B415_045;
        }

        B400_045: switch (state.PT) // Size = 2, Colour = light red
        {
            case LT: state = state[LD].PSH(2); goto B400_047;
            case RT: state = state[RD].PSH(2); goto B400_047;
        }

        B415_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B416_045;
            case LL: state = state.POP; goto B414_045;
            case RR: state = state.SUB; goto B416_045;
            case RL: state = state.POP; goto B414_045;
        }

        B414_046: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(10); goto B329_092;
            case RD: state = state[LD].PSH(10); goto B329_092;
        }

        B416_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B417_045;
            case LL: state = state.OUTc; goto B415_045;
            case RR: state = state.DUP; goto B417_045;
            case RL: state = state.OUTc; goto B415_045;
        }

        B329_092: state = state.DUP; goto B308_093; // PT = LD, Size = 1, Colour = red

        B417_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B418_045;
            case LL: state = state.DIV; goto B416_045;
            case RR: state = state.NOT; goto B418_045;
            case RL: state = state.DIV; goto B416_045;
        }

        B308_093: state = state.PSH(22); goto B329_094; // PT = LD, Size = 22, Colour = blue

        B418_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B419_045;
            case LL: state = state.ROL; goto B417_045;
            case RR: state = state.ROT; goto B419_045;
            case RL: state = state.ROL; goto B417_045;
        }

        B329_094: state = state.ADD; goto B308_095; // PT = LD, Size = 1, Colour = dark blue

        B419_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B420_045;
            case LD: state = state.POP; goto B419_046;
            case LL: state = state.SWI; goto B418_045;
            case LT: state = state[RR].PSH(1); goto B420_045;
            case RR: state = state.PSH(1); goto B420_045;
            case RD: state = state.POP; goto B419_046;
            case RL: state = state.SWI; goto B418_045;
            case RT: state = state[LR].PSH(1); goto B420_045;
        }

        B308_095: state = state.PSH(22); goto B307_096; // PT = LD, Size = 22, Colour = dark magenta

        B420_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B421_045;
            case LL: state = state.POP; goto B419_045;
            case RR: state = state.SUB; goto B421_045;
            case RL: state = state.POP; goto B419_045;
        }

        B419_046: switch (state.PT) // Size = 1, Colour = light red
        {
            case LD: state = state.PSH(9); goto B338_092;
            case RD: state = state.PSH(9); goto B338_092;
        }

        B307_096: state = state.PSH(23); goto B326_097; // PT = LD, Size = 23, Colour = light magenta

        B408_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LL: state = state.OUTc; goto B405_045;
            case RL: state = state.OUTc; goto B405_045;
        }

        B421_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B422_045;
            case LL: state = state.OUTc; goto B420_045;
            case RR: state = state.DUP; goto B422_045;
            case RL: state = state.OUTc; goto B420_045;
        }

        B338_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B360_093;
            case RD: state = state[LD].PSH(23); goto B360_093;
        }

        B326_097: state = state.PSH(4); goto B329_098; // PT = LD, Size = 4, Colour = magenta

        B422_045: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.NOT; goto B423_045;
            case LL: state = state.DIV; goto B421_045;
            case RR: state = state.NOT; goto B423_045;
            case RL: state = state.DIV; goto B421_045;
        }

        B360_093: state = state.ADD; goto B354_094; // PT = LD, Size = 1, Colour = dark red

        B329_098: state = state.MUL; goto B329_099; // PT = LD, Size = 1, Colour = dark magenta

        B423_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state.ROT; goto B424_045;
            case LL: state = state.ROL; goto B422_045;
            case RR: state = state.ROT; goto B424_045;
            case RL: state = state.ROL; goto B422_045;
        }

        B354_094: state = state.PSH(7); goto B338_095; // PT = LD, Size = 7, Colour = dark yellow

        B329_099: state = state.ADD; goto B329_100; // PT = LD, Size = 1, Colour = red

        B403_045: state = state[RR].PSH(1); goto B404_045; // PT = RL, Size = 1, Colour = magenta

        B424_045: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.PSH(1); goto B425_045;
            case LD: state = state.POP; goto B424_046;
            case LL: state = state.SWI; goto B423_045;
            case LT: state = state[RR].PSH(1); goto B425_045;
            case RR: state = state.PSH(1); goto B425_045;
            case RD: state = state.POP; goto B424_046;
            case RL: state = state.SWI; goto B423_045;
            case RT: state = state[LR].PSH(1); goto B425_045;
        }

        B338_095: state = state.PSH(23); goto B358_096; // PT = LD, Size = 23, Colour = light yellow

        B329_100: state = state[RL].DUP; goto B312_101; // PT = LD, Size = 1, Colour = yellow

        B425_045: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.SUB; goto B426_045;
            case LL: state = state.POP; goto B424_045;
            case RR: state = state.SUB; goto B426_045;
            case RL: state = state.POP; goto B424_045;
        }

        B424_046: switch (state.PT) // Size = 1, Colour = dark blue
        {
            case LD: state = state.PSH(9); goto B369_092;
            case RD: state = state.PSH(9); goto B369_092;
        }

        B358_096: state = state.PSH(3); goto B360_097; // PT = LD, Size = 3, Colour = yellow

        B312_101: state = state.PSH(13); goto B311_101; // PT = RL, Size = 13, Colour = light blue

        B426_045: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LR: state = state.DUP; goto B427_045;
            case LL: state = state.OUTc; goto B425_045;
            case RR: state = state.DUP; goto B427_045;
            case RL: state = state.OUTc; goto B425_045;
        }

        B369_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B391_093;
            case RD: state = state[LD].PSH(23); goto B391_093;
        }

        B360_097: state = state.MUL; goto B360_098; // PT = LD, Size = 1, Colour = dark yellow

        B311_101: state = state.SUB; goto B309_101; // PT = RL, Size = 1, Colour = blue

        B427_045: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.NOT; goto B428_045;
            case LL: state = state.DIV; goto B426_045;
            case RR: state = state.NOT; goto B428_045;
            case RL: state = state.DIV; goto B426_045;
        }

        B391_093: state = state.ADD; goto B391_094; // PT = LD, Size = 1, Colour = dark red

        B360_098: state = state.ADD; goto B360_099; // PT = LD, Size = 1, Colour = green

        B309_101: state = state.PSH(2); goto B308_101; // PT = RL, Size = 2, Colour = dark magenta

        B428_045: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ROT; goto B429_045;
            case LL: state = state.ROL; goto B427_045;
            case RR: state = state.ROT; goto B429_045;
            case RL: state = state.ROL; goto B427_045;
        }

        B391_094: state = state.DUP; goto B376_095; // PT = LD, Size = 1, Colour = dark yellow

        B360_099: state = state[RL].DUP; goto B343_100; // PT = LD, Size = 1, Colour = cyan

        B308_101: state = state.ROT; goto B307_101; // PT = RL, Size = 1, Colour = light magenta

        B429_045: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B430_045;
            case LD: state = state.POP; goto B429_046;
            case LL: state = state.SWI; goto B428_045;
            case LT: state = state[RR].PSH(1); goto B430_045;
            case RR: state = state.PSH(1); goto B430_045;
            case RD: state = state.POP; goto B429_046;
            case RL: state = state.SWI; goto B428_045;
            case RT: state = state[LR].PSH(1); goto B430_045;
        }

        B376_095: state = state.PSH(16); goto B391_096; // PT = LD, Size = 16, Colour = dark magenta

        B343_100: state = state.PSH(4); goto B342_100; // PT = RL, Size = 4, Colour = light blue

        B307_101: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B311_103;
            case RD: state = state[LR].DUP; goto B311_103;
            case RL: state = state[RR].DUP; goto B311_103;
            case RT: state = state[LR].DUP; goto B311_103;
        }

        B430_045: switch (state.PT) // Size = 1, Colour = light green
        {
            case LR: state = state.SUB; goto B431_045;
            case LL: state = state.POP; goto B429_045;
            case RR: state = state.SUB; goto B431_045;
            case RL: state = state.POP; goto B429_045;
        }

        B429_046: switch (state.PT) // Size = 1, Colour = green
        {
            case LD: state = state.PSH(10); goto B400_092;
            case RD: state = state.PSH(10); goto B400_092;
        }

        B391_096: state = state.ADD; goto B391_097; // PT = LD, Size = 1, Colour = light magenta

        B342_100: state = state.ADD; goto B340_100; // PT = RL, Size = 1, Colour = blue

        B311_103: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B312_103;
            case RR: state = state.PSH(1); goto B312_103;
        }

        B431_045: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LR: state = state.DUP; goto B432_045;
            case LL: state = state.OUTc; goto B430_045;
            case RR: state = state.DUP; goto B432_045;
            case RL: state = state.OUTc; goto B430_045;
        }

        B400_092: switch (state.PT) // Size = 23, Colour = red
        {
            case LD: state = state.PSH(23); goto B421_093;
            case RD: state = state[LD].PSH(23); goto B421_093;
        }

        B391_097: state = state[RL].DUP; goto B374_098; // PT = LD, Size = 1, Colour = light red

        B340_100: state = state.PSH(2); goto B339_100; // PT = RL, Size = 2, Colour = magenta

        B312_103: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B313_103;
            case RR: state = state.SUB; goto B313_103;
        }

        B432_045: switch (state.PT) // Size = 1, Colour = yellow
        {
            case LR: state = state.NOT; goto B433_045;
            case LL: state = state.DIV; goto B431_045;
            case RR: state = state.NOT; goto B433_045;
            case RL: state = state.DIV; goto B431_045;
        }

        B421_093: state = state.PSH(2); goto B422_094; // PT = LD, Size = 2, Colour = dark red

        B374_098: state = state.PSH(2); goto B373_098; // PT = RL, Size = 2, Colour = light blue

        B339_100: state = state.ROT; goto B338_100; // PT = RL, Size = 1, Colour = dark magenta

        B313_103: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B314_103;
            case RR: state = state.DUP; goto B314_103;
        }

        B433_045: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.ROT; goto B434_045;
            case LL: state = state.ROL; goto B432_045;
            case RR: state = state.ROT; goto B434_045;
            case RL: state = state.ROL; goto B432_045;
        }

        B422_094: state = state.MUL; goto B401_095; // PT = LD, Size = 1, Colour = light red

        B373_098: state = state.SUB; goto B371_098; // PT = RL, Size = 1, Colour = blue

        B338_100: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.DUP; goto B342_102;
            case RD: state = state[LR].DUP; goto B342_102;
            case RL: state = state[RR].DUP; goto B342_102;
            case RT: state = state[LR].DUP; goto B342_102;
        }

        B314_103: switch (state.PT) // Size = 10, Colour = light magenta
        {
            case LR: state = state.PSH(10); goto B324_103;
            case RR: state = state.PSH(10); goto B324_103;
        }

        B434_045: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.PSH(1); goto B435_045;
            case LD: state = state.POP; return;
            case LL: state = state.SWI; goto B433_045;
            case LT: state = state[RR].PSH(1); goto B435_045;
            case RR: state = state.PSH(1); goto B435_045;
            case RD: state = state.POP; return;
            case RL: state = state.SWI; goto B433_045;
            case RT: state = state[LR].PSH(1); goto B435_045;
        }

        B401_095: state = state.PSH(22); goto B400_096; // PT = LD, Size = 22, Colour = dark yellow

        B371_098: state = state.PSH(2); goto B370_098; // PT = RL, Size = 2, Colour = dark magenta

        B342_102: switch (state.PT) // Size = 9, Colour = light red
        {
            case LR: state = state.PSH(9); goto B351_102;
            case RR: state = state.PSH(9); goto B351_102;
        }

        B324_103: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.ADD; goto B325_103;
            case RR: state = state.ADD; goto B325_103;
        }

        B435_045: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B436_045;
            case LL: state = state.POP; goto B434_045;
            case RR: state = state.SUB; goto B436_045;
            case RL: state = state.POP; goto B434_045;
        }

        B400_096: state = state.PSH(23); goto B419_097; // PT = LD, Size = 23, Colour = light yellow

        B370_098: state = state.ROT; goto B369_098; // PT = RL, Size = 1, Colour = light magenta

        B351_102: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B352_102;
            case RR: state = state.SUB; goto B352_102;
        }

        B325_103: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state[RD].DUP; goto B323_105;
            case RR: state = state[LD].DUP; goto B323_105;
        }

        B436_045: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.POP; goto B437_045;
            case LL: state = state.OUTc; goto B435_045;
            case RR: state = state.POP; goto B437_045;
            case RL: state = state.OUTc; goto B435_045;
        }

        B419_097: state = state.PSH(4); goto B422_098; // PT = LD, Size = 4, Colour = yellow

        B369_098: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B373_100;
            case RD: state = state[LR].DUP; goto B373_100;
            case RL: state = state[RR].DUP; goto B373_100;
            case RT: state = state[LR].DUP; goto B373_100;
        }

        B352_102: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state[RD].PSH(9); goto B338_105;
            case RR: state = state[LD].PSH(9); goto B338_105;
        }

        B323_105: switch (state.PT) // Size = 7, Colour = magenta
        {
            case LD: state = state.PSH(7); goto B329_106;
            case RD: state = state[LD].PSH(7); goto B329_106;
        }

        B437_045: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state[LL].PSH(1); goto B436_045;
            case RR: state = state[RL].PSH(1); goto B436_045;
        }

        B422_098: state = state.MUL; goto B422_099; // PT = LD, Size = 1, Colour = dark yellow

        B373_100: switch (state.PT) // Size = 4, Colour = red
        {
            case LR: state = state.PSH(4); goto B377_100;
            case RR: state = state.PSH(4); goto B377_100;
        }

        B338_105: switch (state.PT) // Size = 23, Colour = dark cyan
        {
            case LD: state = state.PSH(23); goto B360_106;
            case RD: state = state[LD].PSH(23); goto B360_106;
        }

        B329_106: state = state.ADD; goto B321_107; // PT = LD, Size = 1, Colour = dark magenta

        B422_099: state = state.ADD; goto B422_100; // PT = LD, Size = 1, Colour = green

        B377_100: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ADD; goto B378_100;
            case RR: state = state.ADD; goto B378_100;
        }

        B360_106: state = state.ADD; goto B345_107; // PT = LD, Size = 1, Colour = light cyan

        B321_107: state = state.PSH(9); goto B307_108; // PT = LD, Size = 9, Colour = dark red

        B422_100: state = state.DUP; goto B410_101; // PT = LD, Size = 1, Colour = cyan

        B378_100: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state[RD].DUP; goto B374_102;
            case RR: state = state[LD].DUP; goto B374_102;
        }

        B345_107: state = state.PSH(16); goto B338_108; // PT = LD, Size = 16, Colour = light blue

        B307_108: state = state.PSH(23); goto B329_109; // PT = LD, Size = 23, Colour = light red

        B410_101: state = state.PSH(13); goto B422_102; // PT = LD, Size = 13, Colour = yellow

        B374_102: switch (state.PT) // Size = 18, Colour = light blue
        {
            case LD: state = state.PSH(18); goto B391_103;
            case RD: state = state[LD].PSH(18); goto B391_103;
        }

        B338_108: state = state.PSH(23); goto B358_109; // PT = LD, Size = 23, Colour = blue

        B329_109: state = state.ADD; goto B322_110; // PT = LD, Size = 1, Colour = red

        B422_102: state = state.SUB; goto B422_103; // PT = LD, Size = 1, Colour = dark yellow

        B391_103: state = state.SUB; goto B374_104; // PT = LD, Size = 1, Colour = blue

        B358_109: state = state.PSH(3); goto B360_110; // PT = LD, Size = 3, Colour = dark blue

        B322_110: state = state.PSH(8); goto B307_111; // PT = LD, Size = 8, Colour = yellow

        B422_103: state = state.DUP; goto B408_104; // PT = LD, Size = 1, Colour = light green

        B374_104: state = state.PSH(18); goto B369_105; // PT = LD, Size = 18, Colour = dark magenta

        B360_110: state = state.MUL; goto B360_111; // PT = LD, Size = 1, Colour = light blue

        B307_111: state = state.PSH(23); goto B326_112; // PT = LD, Size = 23, Colour = dark yellow

        B408_104: state = state.PSH(15); goto B422_105; // PT = LD, Size = 15, Colour = light red

        B369_105: state = state.PSH(23); goto B388_106; // PT = LD, Size = 23, Colour = light magenta

        B360_111: state = state.ADD; goto B360_112; // PT = LD, Size = 1, Colour = dark magenta

        B326_112: state = state.PSH(4); goto B329_113; // PT = LD, Size = 4, Colour = light yellow

        B422_105: state = state.ADD; goto B422_106; // PT = LD, Size = 1, Colour = red

        B388_106: state = state.PSH(4); goto B391_107; // PT = LD, Size = 4, Colour = magenta

        B360_112: state = state[RL].DUP; goto B343_113; // PT = LD, Size = 1, Colour = dark red

        B329_113: state = state.MUL; goto B329_114; // PT = LD, Size = 1, Colour = yellow

        B422_106: state = state.DUP; goto B404_107; // PT = LD, Size = 1, Colour = yellow

        B391_107: state = state.MUL; goto B391_108; // PT = LD, Size = 1, Colour = dark magenta

        B343_113: state = state.PSH(7); goto B342_113; // PT = RL, Size = 7, Colour = light blue

        B329_114: state = state.ADD; goto B329_115; // PT = LD, Size = 1, Colour = light green

        B404_107: state = state.PSH(19); goto B422_108; // PT = LD, Size = 19, Colour = magenta

        B391_108: state = state.ADD; goto B391_109; // PT = LD, Size = 1, Colour = red

        B342_113: state = state.SUB; goto B340_113; // PT = RL, Size = 1, Colour = blue

        B329_115: state = state.DUP; goto B329_116; // PT = LD, Size = 1, Colour = light cyan

        B422_108: state = state.SUB; goto B422_109; // PT = LD, Size = 1, Colour = dark magenta

        B391_109: state = state[RL].DUP; goto B374_110; // PT = LD, Size = 1, Colour = yellow

        B340_113: state = state.PSH(2); goto B339_113; // PT = RL, Size = 2, Colour = dark magenta

        B329_116: state = state.PSH(1); goto B329_117; // PT = LD, Size = 1, Colour = light yellow

        B422_109: state = state.DUP; goto B412_110; // PT = LD, Size = 1, Colour = light red

        B374_110: state = state.PSH(1); goto B373_110; // PT = RL, Size = 1, Colour = light blue

        B339_113: state = state.ROT; goto B338_113; // PT = RL, Size = 1, Colour = light magenta

        B329_117: state = state.ADD; goto B329_118; // PT = LD, Size = 1, Colour = yellow

        B412_110: state = state.PSH(11); goto B422_111; // PT = LD, Size = 11, Colour = light blue

        B373_110: state = state.ADD; goto B371_110; // PT = RL, Size = 1, Colour = blue

        B338_113: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B342_115;
            case RD: state = state[LR].DUP; goto B342_115;
            case RL: state = state[RR].DUP; goto B342_115;
            case RT: state = state[LR].DUP; goto B342_115;
        }

        B329_118: state = state.DUP; goto B316_119; // PT = LD, Size = 1, Colour = green

        B422_111: state = state.ADD; goto B414_112; // PT = LD, Size = 1, Colour = blue

        B371_110: state = state.PSH(2); goto B370_110; // PT = RL, Size = 2, Colour = magenta

        B342_115: switch (state.PT) // Size = 7, Colour = red
        {
            case LR: state = state.PSH(7); goto B349_115;
            case RR: state = state.PSH(7); goto B349_115;
        }

        B316_119: state = state.PSH(14); goto B329_120; // PT = LD, Size = 14, Colour = red

        B414_112: state = state.PSH(9); goto B400_113; // PT = LD, Size = 9, Colour = magenta

        B370_110: state = state.ROT; goto B369_110; // PT = RL, Size = 1, Colour = dark magenta

        B349_115: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B350_115;
            case RR: state = state.SUB; goto B350_115;
        }

        B329_120: state = state.ADD; goto B329_121; // PT = LD, Size = 1, Colour = dark red

        B400_113: state = state.PSH(23); goto B422_114; // PT = LD, Size = 23, Colour = dark magenta

        B369_110: switch (state.PT) // Size = 4, Colour = light green
        {
            case RR: state = state.DUP; goto B373_112;
            case RD: state = state[LR].DUP; goto B373_112;
            case RL: state = state[RR].DUP; goto B373_112;
            case RT: state = state[LR].DUP; goto B373_112;
        }

        B350_115: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state[RD].PSH(22); goto B338_118;
            case RR: state = state[LD].PSH(22); goto B338_118;
        }

        B329_121: state = state[RL].DUP; goto B312_122; // PT = LD, Size = 1, Colour = dark yellow

        B422_114: state = state.ADD; goto B401_115; // PT = LD, Size = 1, Colour = light magenta

        B373_112: switch (state.PT) // Size = 6, Colour = light red
        {
            case LR: state = state.PSH(6); goto B379_112;
            case RR: state = state.PSH(6); goto B379_112;
        }

        B338_118: switch (state.PT) // Size = 23, Colour = light red
        {
            case LD: state = state.PSH(23); goto B360_119;
            case RD: state = state[LD].PSH(23); goto B360_119;
        }

        B312_122: state = state.PSH(5); goto B311_122; // PT = RL, Size = 5, Colour = light blue

        B401_115: state = state.PSH(22); goto B400_116; // PT = LD, Size = 22, Colour = light red

        B379_112: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B380_112;
            case RR: state = state.SUB; goto B380_112;
        }

        B360_119: state = state.ADD; goto B360_120; // PT = LD, Size = 1, Colour = red

        B311_122: state = state.SUB; goto B309_122; // PT = RL, Size = 1, Colour = blue

        B400_116: state = state.PSH(23); goto B419_117; // PT = LD, Size = 23, Colour = red

        B380_112: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state[LL].DUP; goto B374_114;
            case RR: state = state[RL].DUP; goto B374_114;
        }

        B360_120: state = state.DUP; goto B339_121; // PT = LD, Size = 1, Colour = yellow

        B309_122: state = state.PSH(2); goto B308_122; // PT = RL, Size = 2, Colour = dark magenta

        B419_117: state = state.PSH(4); goto B422_118; // PT = LD, Size = 4, Colour = dark red

        B374_114: switch (state.PT) // Size = 10, Colour = light blue
        {
            case LL: state = state.PSH(10); goto B373_114;
            case RL: state = state.PSH(10); goto B373_114;
        }

        B339_121: state = state.PSH(22); goto B360_122; // PT = LD, Size = 22, Colour = magenta

        B308_122: state = state.ROT; goto B307_122; // PT = RL, Size = 1, Colour = light magenta

        B422_118: state = state.MUL; goto B422_119; // PT = LD, Size = 1, Colour = light red

        B373_114: switch (state.PT) // Size = 1, Colour = blue
        {
            case LL: state = state.ADD; goto B371_114;
            case RL: state = state.ADD; goto B371_114;
        }

        B360_122: state = state.ADD; goto B360_123; // PT = LD, Size = 1, Colour = dark magenta

        B307_122: switch (state.PT) // Size = 4, Colour = green
        {
            case RR: state = state.DUP; goto B311_124;
            case RD: state = state[LR].DUP; goto B311_124;
            case RL: state = state[RR].DUP; goto B311_124;
            case RT: state = state[LR].DUP; goto B311_124;
        }

        B422_119: state = state.ADD; goto B422_120; // PT = LD, Size = 1, Colour = dark yellow

        B371_114: switch (state.PT) // Size = 2, Colour = magenta
        {
            case LL: state = state.PSH(2); goto B370_114;
            case RL: state = state.PSH(2); goto B370_114;
        }

        B360_123: state = state.DUP; goto B352_124; // PT = LD, Size = 1, Colour = dark red

        B311_124: switch (state.PT) // Size = 9, Colour = red
        {
            case LR: state = state.PSH(9); goto B320_124;
            case RR: state = state.PSH(9); goto B320_124;
        }

        B422_120: state = state.DUP; goto B420_121; // PT = LD, Size = 1, Colour = dark green

        B370_114: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LL: state = state.ROT; goto B369_114;
            case RL: state = state.ROT; goto B369_114;
        }

        B352_124: state = state.PSH(9); goto B338_125; // PT = LD, Size = 9, Colour = dark blue

        B320_124: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.SUB; goto B321_124;
            case RR: state = state.SUB; goto B321_124;
        }

        B420_121: state = state.PSH(3); goto B422_122; // PT = LD, Size = 3, Colour = dark red

        B369_114: switch (state.PT) // Size = 4, Colour = light green
        {
            case LR: state = state.DUP; goto B373_116;
            case LD: state = state[RR].DUP; goto B373_116;
            case LL: state = state[LR].DUP; goto B373_116;
            case LT: state = state[RR].DUP; goto B373_116;
            case RR: state = state.DUP; goto B373_116;
            case RD: state = state[LR].DUP; goto B373_116;
            case RL: state = state[RR].DUP; goto B373_116;
            case RT: state = state[LR].DUP; goto B373_116;
        }

        B338_125: state = state.PSH(23); goto B360_126; // PT = LD, Size = 23, Colour = light blue

        B321_124: switch (state.PT) // Size = 1, Colour = light yellow
        {
            case LR: state = state.DUP; goto B322_124;
            case RR: state = state.DUP; goto B322_124;
        }

        B422_122: state = state.SUB; goto B413_123; // PT = LD, Size = 1, Colour = light red

        B373_116: switch (state.PT) // Size = 1, Colour = light red
        {
            case LR: state = state.PSH(1); goto B374_116;
            case RR: state = state.PSH(1); goto B374_116;
        }

        B360_126: state = state.ADD; goto B352_127; // PT = LD, Size = 1, Colour = blue

        B322_124: switch (state.PT) // Size = 2, Colour = light magenta
        {
            case LR: state = state.PSH(2); goto B324_124;
            case RR: state = state.PSH(2); goto B324_124;
        }

        B413_123: state = state.PSH(10); goto B422_124; // PT = LD, Size = 10, Colour = yellow

        B374_116: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SUB; goto B375_116;
            case RR: state = state.SUB; goto B375_116;
        }

        B352_127: state = state.PSH(9); goto B338_128; // PT = LD, Size = 9, Colour = magenta

        B324_124: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LR: state = state.SUB; goto B325_124;
            case RR: state = state.SUB; goto B325_124;
        }

        B422_124: state = state[RL].PSH(2); goto B420_127; // PT = LD, Size = 1, Colour = dark yellow

        B375_116: switch (state.PT) // Size = 1, Colour = dark yellow
        {
            case LR: state = state[RD].DUP; goto B379_118;
            case RR: state = state[LD].DUP; goto B379_118;
        }

        B338_128: state = state.PSH(23); goto B357_129; // PT = LD, Size = 23, Colour = dark magenta

        B325_124: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state[RD].DUP; goto B324_126;
            case RR: state = state[LD].DUP; goto B324_126;
        }

        B420_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B421_127;
            case LL: state = state.PSH(1); goto B419_127;
            case RR: state = state.POP; goto B421_127;
            case RL: state = state.PSH(1); goto B419_127;
        }

        B379_118: switch (state.PT) // Size = 13, Colour = magenta
        {
            case LD: state = state.PSH(13); goto B391_119;
            case RD: state = state[LD].PSH(13); goto B391_119;
        }

        B357_129: state = state.PSH(4); goto B360_130; // PT = LD, Size = 4, Colour = light magenta

        B324_126: switch (state.PT) // Size = 6, Colour = dark magenta
        {
            case LD: state = state.PSH(6); goto B329_127;
            case RD: state = state[LD].PSH(6); goto B329_127;
        }

        B419_127: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B420_127;
            case LL: state = state.ROL; goto B418_127;
            case RR: state = state.POP; goto B420_127;
            case RL: state = state.ROL; goto B418_127;
        }

        B391_119: state = state.SUB; goto B391_120; // PT = LD, Size = 1, Colour = dark magenta

        B360_130: state = state.MUL; goto B360_131; // PT = LD, Size = 1, Colour = magenta

        B329_127: state = state.ADD; goto B329_128; // PT = LD, Size = 1, Colour = light magenta

        B418_127: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B419_127;
            case LL: state = state.OUTc; goto B417_127;
            case RR: state = state.NOT; goto B419_127;
            case RL: state = state.OUTc; goto B417_127;
        }

        B391_120: state = state.DUP; goto B375_121; // PT = LD, Size = 1, Colour = light red

        B360_131: state = state.ADD; goto B360_132; // PT = LD, Size = 1, Colour = light red

        B329_128: state = state.DUP; goto B327_129; // PT = LD, Size = 1, Colour = light red

        B417_127: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B418_127;
            case LL: state = state.PSH(1); goto B416_127;
            case RR: state = state.SUB; goto B418_127;
            case RL: state = state.PSH(1); goto B416_127;
        }

        B375_121: state = state.PSH(17); goto B391_122; // PT = LD, Size = 17, Colour = light blue

        B360_132: state = state.DUP; goto B358_133; // PT = LD, Size = 1, Colour = light yellow

        B327_129: state = state.PSH(3); goto B329_130; // PT = LD, Size = 3, Colour = light blue

        B416_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B417_127;
            case LL: state = state.SUB; goto B415_127;
            case RR: state = state.POP; goto B417_127;
            case RL: state = state.SUB; goto B415_127;
        }

        B391_122: state = state.ADD; goto B380_123; // PT = LD, Size = 1, Colour = blue

        B358_133: state = state.PSH(3); goto B360_134; // PT = LD, Size = 3, Colour = light magenta

        B329_130: state = state.ADD; goto B314_131; // PT = LD, Size = 1, Colour = blue

        B415_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B416_127;
            case LL: state = state.DUP; goto B414_127;
            case RR: state = state.OUTc; goto B416_127;
            case RL: state = state.DUP; goto B414_127;
        }

        B380_123: state = state.PSH(12); goto B391_124; // PT = LD, Size = 12, Colour = magenta

        B360_134: state = state.ADD; goto B360_135; // PT = LD, Size = 1, Colour = magenta

        B314_131: state = state.PSH(16); goto B329_132; // PT = LD, Size = 16, Colour = magenta

        B414_127: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B415_127;
            case LL: state = state.NOT; goto B411_127;
            case RR: state = state.DIV; goto B415_127;
            case RL: state = state.NOT; goto B411_127;
        }

        B391_124: state = state[RL].PSH(2); goto B389_127; // PT = LD, Size = 1, Colour = dark magenta

        B360_135: state = state.DUP; goto B349_136; // PT = LD, Size = 1, Colour = red

        B329_132: state = state[RL].PSH(2); goto B327_135; // PT = LD, Size = 1, Colour = dark magenta

        B411_127: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B414_127;
            case LL: state = state.PSH(3); goto B410_127;
            case RR: state = state.ROL; goto B414_127;
            case RL: state = state.PSH(3); goto B410_127;
        }

        B389_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B390_127;
            case LL: state = state.PSH(1); goto B388_127;
            case RR: state = state.POP; goto B390_127;
            case RL: state = state.PSH(1); goto B388_127;
        }

        B349_136: state = state.PSH(12); goto B360_137; // PT = LD, Size = 12, Colour = blue

        B327_135: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B328_135;
            case LL: state = state.PSH(1); goto B326_135;
            case RR: state = state.POP; goto B328_135;
            case RL: state = state.PSH(1); goto B326_135;
        }

        B410_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B411_127;
            case LL: state = state.MUL; goto B409_127;
            case RR: state = state.POP; goto B411_127;
            case RL: state = state.MUL; goto B409_127;
        }

        B388_127: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B389_127;
            case LL: state = state.ROL; goto B387_127;
            case RR: state = state.POP; goto B389_127;
            case RL: state = state.ROL; goto B387_127;
        }

        B360_137: state = state.ADD; goto B346_138; // PT = LD, Size = 1, Colour = dark blue

        B326_135: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B327_135;
            case LL: state = state.ROL; goto B325_135;
            case RR: state = state.POP; goto B327_135;
            case RL: state = state.ROL; goto B325_135;
        }

        B409_127: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B410_127;
            case LL: state = state.DUP; goto B408_127;
            case RR: state = state.OUTi; goto B410_127;
            case RL: state = state.DUP; goto B408_127;
        }

        B387_127: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B388_127;
            case LL: state = state.OUTc; goto B386_127;
            case RR: state = state.NOT; goto B388_127;
            case RL: state = state.OUTc; goto B386_127;
        }

        B346_138: state = state.PSH(15); goto B360_139; // PT = LD, Size = 15, Colour = dark magenta

        B325_135: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B326_135;
            case LL: state = state.OUTc; goto B324_135;
            case RR: state = state.NOT; goto B326_135;
            case RL: state = state.OUTc; goto B324_135;
        }

        B408_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B409_127;
            case LL: state = state.ROT; goto B407_127;
            case RR: state = state.DIV; goto B409_127;
            case RL: state = state.ROT; goto B407_127;
        }

        B386_127: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B387_127;
            case LL: state = state.PSH(1); goto B385_127;
            case RR: state = state.SUB; goto B387_127;
            case RL: state = state.PSH(1); goto B385_127;
        }

        B360_139: state = state[RL].PSH(2); goto B358_142; // PT = LD, Size = 1, Colour = light magenta

        B324_135: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B325_135;
            case LL: state = state.PSH(1); goto B323_135;
            case RR: state = state.SUB; goto B325_135;
            case RL: state = state.PSH(1); goto B323_135;
        }

        B407_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B408_127;
            case LD: state = state.ROT; goto B407_128;
            case LL: state = state.POP; goto B406_127;
            case LT: state = state[RR].SWI; goto B408_127;
            case RR: state = state.SWI; goto B408_127;
            case RD: state = state.ROT; goto B407_128;
            case RL: state = state.POP; goto B406_127;
            case RT: state = state[LR].SWI; goto B408_127;
        }

        B385_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B386_127;
            case LL: state = state.SUB; goto B384_127;
            case RR: state = state.POP; goto B386_127;
            case RL: state = state.SUB; goto B384_127;
        }

        B358_142: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B359_142;
            case LL: state = state.PSH(1); goto B357_142;
            case RR: state = state.POP; goto B359_142;
            case RL: state = state.PSH(1); goto B357_142;
        }

        B323_135: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B324_135;
            case LL: state = state.SUB; goto B322_135;
            case RR: state = state.POP; goto B324_135;
            case RL: state = state.SUB; goto B322_135;
        }

        B406_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B420_127;
            case RL: state = state.PSH(2); goto B420_127;
        }

        B407_128: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[RR].POP; goto B408_129;
            case LD: state = state[LT].SWI; goto B407_127;
            case LL: state = state[RT].SWI; goto B407_127;
            case LT: state = state.SWI; goto B407_127;
            case RR: state = state.POP; goto B408_129;
            case RD: state = state[RT].SWI; goto B407_127;
            case RL: state = state[LT].SWI; goto B407_127;
            case RT: state = state.SWI; goto B407_127;
        }

        B384_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B385_127;
            case LL: state = state.DUP; goto B383_127;
            case RR: state = state.OUTc; goto B385_127;
            case RL: state = state.DUP; goto B383_127;
        }

        B357_142: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.POP; goto B358_142;
            case LL: state = state.ROL; goto B356_142;
            case RR: state = state.POP; goto B358_142;
            case RL: state = state.ROL; goto B356_142;
        }

        B322_135: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B323_135;
            case LL: state = state.DUP; goto B321_135;
            case RR: state = state.OUTc; goto B323_135;
            case RL: state = state.DUP; goto B321_135;
        }

        B408_129: state = state[RL].PSH(3); goto B417_133; // PT = RR, Size = 1, Colour = cyan

        B383_127: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B384_127;
            case LL: state = state.NOT; goto B380_127;
            case RR: state = state.DIV; goto B384_127;
            case RL: state = state.NOT; goto B380_127;
        }

        B356_142: switch (state.PT) // Size = 1, Colour = light blue
        {
            case LR: state = state.NOT; goto B357_142;
            case LL: state = state.OUTc; goto B355_142;
            case RR: state = state.NOT; goto B357_142;
            case RL: state = state.OUTc; goto B355_142;
        }

        B321_135: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B322_135;
            case LL: state = state.NOT; goto B318_135;
            case RR: state = state.DIV; goto B322_135;
            case RL: state = state.NOT; goto B318_135;
        }

        B417_133: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.POP; goto B418_133;
            case LL: state = state.ROT; goto B416_133;
            case RR: state = state.POP; goto B418_133;
            case RL: state = state.ROT; goto B416_133;
        }

        B380_127: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B383_127;
            case LL: state = state.PSH(3); goto B379_127;
            case RR: state = state.ROL; goto B383_127;
            case RL: state = state.PSH(3); goto B379_127;
        }

        B355_142: switch (state.PT) // Size = 1, Colour = dark cyan
        {
            case LR: state = state.SUB; goto B356_142;
            case LL: state = state.PSH(1); goto B354_142;
            case RR: state = state.SUB; goto B356_142;
            case RL: state = state.PSH(1); goto B354_142;
        }

        B318_135: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B321_135;
            case LL: state = state.PSH(3); goto B317_135;
            case RR: state = state.ROL; goto B321_135;
            case RL: state = state.PSH(3); goto B317_135;
        }

        B416_133: switch (state.PT) // Size = 3, Colour = dark cyan
        {
            case LR: state = state.SWI; goto B417_133;
            case LD: state = state.PSH(3); goto B416_136;
            case LL: state = state[LR].SWI; goto B417_133;
            case LT: state = state[LR].SWI; goto B417_133;
            case RR: state = state[LR].SWI; goto B417_133;
            case RD: state = state.PSH(3); goto B416_136;
            case RL: state = state[LR].SWI; goto B417_133;
            case RT: state = state[LR].SWI; goto B417_133;
        }

        B379_127: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B380_127;
            case LL: state = state.MUL; goto B378_127;
            case RR: state = state.POP; goto B380_127;
            case RL: state = state.MUL; goto B378_127;
        }

        B354_142: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.POP; goto B355_142;
            case LL: state = state.SUB; goto B353_142;
            case RR: state = state.POP; goto B355_142;
            case RL: state = state.SUB; goto B353_142;
        }

        B317_135: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B318_135;
            case LL: state = state.MUL; goto B316_135;
            case RR: state = state.POP; goto B318_135;
            case RL: state = state.MUL; goto B316_135;
        }

        B416_136: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LD: state = state.ROT; goto B416_137;
            case LT: state = state.POP; goto B416_133;
            case RD: state = state.ROT; goto B416_137;
            case RT: state = state.POP; goto B416_133;
        }

        B378_127: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B379_127;
            case LL: state = state.DUP; goto B377_127;
            case RR: state = state.OUTi; goto B379_127;
            case RL: state = state.DUP; goto B377_127;
        }

        B353_142: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.OUTc; goto B354_142;
            case LL: state = state.DUP; goto B352_142;
            case RR: state = state.OUTc; goto B354_142;
            case RL: state = state.DUP; goto B352_142;
        }

        B316_135: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B317_135;
            case LL: state = state.DUP; goto B315_135;
            case RR: state = state.OUTi; goto B317_135;
            case RL: state = state.DUP; goto B315_135;
        }

        B418_133: switch (state.PT) // Size = 3, Colour = light red
        {
            case LR: state = state[LL].PSH(3); goto B417_133;
            case RR: state = state[RL].PSH(3); goto B417_133;
        }

        B416_137: switch (state.PT) // Size = 3, Colour = red
        {
            case LR: state = state.PSH(3); goto B419_137;
            case LD: state = state[LT].SWI; goto B416_136;
            case LL: state = state[LT].SWI; goto B416_136;
            case LT: state = state.SWI; goto B416_136;
            case RR: state = state.PSH(3); goto B419_137;
            case RD: state = state[LT].SWI; goto B416_136;
            case RL: state = state[LT].SWI; goto B416_136;
            case RT: state = state[LT].SWI; goto B416_136;
        }

        B377_127: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B378_127;
            case LL: state = state.ROT; goto B376_127;
            case RR: state = state.DIV; goto B378_127;
            case RL: state = state.ROT; goto B376_127;
        }

        B352_142: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.DIV; goto B353_142;
            case LL: state = state.NOT; goto B349_142;
            case RR: state = state.DIV; goto B353_142;
            case RL: state = state.NOT; goto B349_142;
        }

        B315_135: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B316_135;
            case LL: state = state.ROT; goto B314_135;
            case RR: state = state.DIV; goto B316_135;
            case RL: state = state.ROT; goto B314_135;
        }

        B419_137: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state.ROT; goto B428_137;
            case RR: state = state.ROT; goto B428_137;
        }

        B376_127: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B377_127;
            case LD: state = state.ROT; goto B376_128;
            case LL: state = state.POP; goto B375_127;
            case LT: state = state[RR].SWI; goto B377_127;
            case RR: state = state.SWI; goto B377_127;
            case RD: state = state.ROT; goto B376_128;
            case RL: state = state.POP; goto B375_127;
            case RT: state = state[LR].SWI; goto B377_127;
        }

        B349_142: switch (state.PT) // Size = 3, Colour = light blue
        {
            case LR: state = state.ROL; goto B352_142;
            case LL: state = state.PSH(3); goto B348_142;
            case RR: state = state.ROL; goto B352_142;
            case RL: state = state.PSH(3); goto B348_142;
        }

        B314_135: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B315_135;
            case LD: state = state.ROT; goto B314_136;
            case LL: state = state.POP; goto B313_135;
            case LT: state = state[RR].SWI; goto B315_135;
            case RR: state = state.SWI; goto B315_135;
            case RD: state = state.ROT; goto B314_136;
            case RL: state = state.POP; goto B313_135;
            case RT: state = state[LR].SWI; goto B315_135;
        }

        B428_137: switch (state.PT) // Size = 1, Colour = dark red
        {
            case LR: state = state[LL].SWI; goto B427_137;
            case LD: state = state[RL].SWI; goto B427_137;
            case LL: state = state.SWI; goto B427_137;
            case LT: return;
            case RR: state = state[RL].SWI; goto B427_137;
            case RD: state = state[LL].SWI; goto B427_137;
            case RL: state = state.SWI; goto B427_137;
            case RT: return;
        }

        B375_127: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B389_127;
            case RL: state = state.PSH(2); goto B389_127;
        }

        B376_128: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[RR].POP; goto B377_129;
            case LD: state = state[LT].SWI; goto B376_127;
            case LL: state = state[RT].SWI; goto B376_127;
            case LT: state = state.SWI; goto B376_127;
            case RR: state = state.POP; goto B377_129;
            case RD: state = state[RT].SWI; goto B376_127;
            case RL: state = state[LT].SWI; goto B376_127;
            case RT: state = state.SWI; goto B376_127;
        }

        B348_142: switch (state.PT) // Size = 1, Colour = blue
        {
            case LR: state = state.POP; goto B349_142;
            case LL: state = state.MUL; goto B347_142;
            case RR: state = state.POP; goto B349_142;
            case RL: state = state.MUL; goto B347_142;
        }

        B313_135: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B327_135;
            case RL: state = state.PSH(2); goto B327_135;
        }

        B314_136: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[RR].POP; goto B315_137;
            case LD: state = state[LT].SWI; goto B314_135;
            case LL: state = state[RT].SWI; goto B314_135;
            case LT: state = state.SWI; goto B314_135;
            case RR: state = state.POP; goto B315_137;
            case RD: state = state[RT].SWI; goto B314_135;
            case RL: state = state[LT].SWI; goto B314_135;
            case RT: state = state.SWI; goto B314_135;
        }

        B427_137: switch (state.PT) // Size = 1, Colour = cyan
        {
            case LL: state = state.POP; goto B416_137;
            case RL: state = state.POP; goto B416_137;
        }

        B377_129: state = state[LD].PSH(1); goto B391_131; // PT = RR, Size = 1, Colour = cyan

        B347_142: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LR: state = state.OUTi; goto B348_142;
            case LL: state = state.DUP; goto B346_142;
            case RR: state = state.OUTi; goto B348_142;
            case RL: state = state.DUP; goto B346_142;
        }

        B315_137: state = state[LD].PSH(1); goto B329_139; // PT = RR, Size = 1, Colour = cyan

        B391_131: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B391_132;
            case LT: state = state.POP; goto B391_130;
            case RD: state = state.ROT; goto B391_132;
            case RT: state = state.POP; goto B391_130;
        }

        B346_142: switch (state.PT) // Size = 1, Colour = light cyan
        {
            case LR: state = state.DIV; goto B347_142;
            case LL: state = state.ROT; goto B345_142;
            case RR: state = state.DIV; goto B347_142;
            case RL: state = state.ROT; goto B345_142;
        }

        B329_139: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LD: state = state.ROT; goto B329_140;
            case LT: state = state.POP; goto B329_138;
            case RD: state = state.ROT; goto B329_140;
            case RT: state = state.POP; goto B329_138;
        }

        B391_132: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state[RR].PSH(1); goto B409_045;
            case LL: state = state[LR].PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B391_131;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state[LR].PSH(1); goto B409_045;
            case RL: state = state[RR].PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B391_131;
        }

        B345_142: switch (state.PT) // Size = 1, Colour = red
        {
            case LR: state = state.SWI; goto B346_142;
            case LD: state = state.ROT; goto B345_143;
            case LL: state = state.POP; goto B344_142;
            case LT: state = state[RR].SWI; goto B346_142;
            case RR: state = state.SWI; goto B346_142;
            case RD: state = state.ROT; goto B345_143;
            case RL: state = state.POP; goto B344_142;
            case RT: state = state[LR].SWI; goto B346_142;
        }

        B329_140: switch (state.PT) // Size = 1, Colour = green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state[RR].PSH(1); goto B409_045;
            case LL: state = state[LR].PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B329_139;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state[LR].PSH(1); goto B409_045;
            case RL: state = state[RR].PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B329_139;
        }

        B421_127: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state[LL].PSH(2); goto B420_127;
            case RR: state = state[RL].PSH(2); goto B420_127;
        }

        B344_142: switch (state.PT) // Size = 1, Colour = light red
        {
            case LL: state = state.PSH(2); goto B358_142;
            case RL: state = state.PSH(2); goto B358_142;
        }

        B345_143: switch (state.PT) // Size = 2, Colour = dark cyan
        {
            case LR: state = state[RR].POP; goto B346_144;
            case LD: state = state[LT].SWI; goto B345_142;
            case LL: state = state[RT].SWI; goto B345_142;
            case LT: state = state.SWI; goto B345_142;
            case RR: state = state.POP; goto B346_144;
            case RD: state = state[RT].SWI; goto B345_142;
            case RL: state = state[LT].SWI; goto B345_142;
            case RT: state = state.SWI; goto B345_142;
        }

        B391_130: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state[LD].PSH(1); goto B391_131;
            case RT: state = state[RD].PSH(1); goto B391_131;
        }

        B346_144: state = state[LD].PSH(1); goto B360_146; // PT = RR, Size = 1, Colour = cyan

        B329_138: switch (state.PT) // Size = 1, Colour = dark magenta
        {
            case LT: state = state[LD].PSH(1); goto B329_139;
            case RT: state = state[RD].PSH(1); goto B329_139;
        }

        B360_146: switch (state.PT) // Size = 1, Colour = magenta
        {
            case LD: state = state.ROT; goto B360_147;
            case LT: state = state.POP; goto B360_145;
            case RD: state = state.ROT; goto B360_147;
            case RT: state = state.POP; goto B360_145;
        }

        B360_147: switch (state.PT) // Size = 1, Colour = dark green
        {
            case LR: state = state.PSH(1); goto B409_045;
            case LD: state = state[RR].PSH(1); goto B409_045;
            case LL: state = state[LR].PSH(1); goto B409_045;
            case LT: state = state.SWI; goto B360_146;
            case RR: state = state.PSH(1); goto B409_045;
            case RD: state = state[LR].PSH(1); goto B409_045;
            case RL: state = state[RR].PSH(1); goto B409_045;
            case RT: state = state.SWI; goto B360_146;
        }

        B360_145: switch (state.PT) // Size = 1, Colour = light magenta
        {
            case LT: state = state[LD].PSH(1); goto B360_146;
            case RT: state = state[RD].PSH(1); goto B360_146;
        }

        B390_127: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state[LL].PSH(2); goto B389_127;
            case RR: state = state[RL].PSH(2); goto B389_127;
        }

        B328_135: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state[LL].PSH(2); goto B327_135;
            case RR: state = state[RL].PSH(2); goto B327_135;
        }

        B359_142: switch (state.PT) // Size = 2, Colour = light red
        {
            case LR: state = state[LL].PSH(2); goto B358_142;
            case RR: state = state[RL].PSH(2); goto B358_142;
        }
    }
}
