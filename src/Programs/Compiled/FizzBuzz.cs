using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class FizzBuzz
{
    private const bool Exit = true;

    public static bool Execute(State state) => state.B000_000;

    extension(State state)
    {
        private bool B000_000 => state.PT switch
        {
            LR => state.INi.B001_000,
            LL => state.LR.INi.B001_000,
            RL => state.RR.INi.B001_000,
            _ => Exit,
        };

        private bool B001_000 => state.PT switch
        {
            LR => state.DUP.B002_000,
            LL => state.MOD.B000_000,
            RR => state.DUP.B002_000,
            RL => state.MOD.B000_000,
            _ => Exit,
        };

        private bool B002_000 => state.PT switch
        {
            LR => state.PSH(3).B005_000,
            LL => state.DIV.B001_000,
            RR => state.PSH(3).B005_000,
            RL => state.DIV.B001_000,
            _ => Exit,
        };

        private bool B005_000 => state.PT switch
        {
            LR => state.MOD.B006_000,
            LL => state.POP.B002_000,
            RR => state.MOD.B006_000,
            RL => state.POP.B002_000,
            _ => Exit,
        };

        private bool B006_000 => state.PT switch
        {
            LR => state.NOT.B007_000,
            LL => state.INi.B005_000,
            RR => state.NOT.B007_000,
            RL => state.INi.B005_000,
            _ => Exit,
        };

        private bool B007_000 => state.PT switch
        {
            LR => state.ROT.B008_000,
            LL => state.ROL.B006_000,
            RR => state.ROT.B008_000,
            RL => state.ROL.B006_000,
            _ => Exit,
        };

        private bool B008_000 => state.PT switch
        {
            LR => state.PSH(1).B026_000,
            LD => state.PSH(3).B008_007,
            LL => state.SWI.B007_000,
            LT => state.RR.PSH(1).B026_000,
            RR => state.PSH(1).B026_000,
            RD => state.GT_.B006_007,
            RL => state.SWI.B007_000,
            RT => state.LR.PSH(1).B026_000,
            _ => Exit,
        };

        private bool B026_000 => state.PT switch
        {
            LR => state.PSH(2).B057_000,
            RR => state.PSH(2).B057_000,
            _ => Exit,
        };

        private bool B008_007 => state.PT switch
        {
            LD => state.ROT.B006_008,
            _ => Exit,
        };

        private bool B057_000 => state.PT switch
        {
            LR => state.PSH(1).B058_000,
            LL => state.POP.B055_000,
            RR => state.PSH(1).B058_000,
            RL => state.POP.B055_000,
            _ => Exit,
        };

        private bool B006_008 => state.PT switch
        {
            LR => state.PSH(70).B006_025,
            LD => state.PSH(70).B006_025,
            LL => state.PSH(70).B005_022,
            LT => state.ROT.B006_006,
            RD => state.PSH(70).B006_025,
            _ => Exit,
        };

        private bool B058_000 => state.PT switch
        {
            LR => state.ROL.B059_000,
            LL => state.POP.B057_000,
            RR => state.ROL.B059_000,
            RL => state.POP.B057_000,
            _ => Exit,
        };

        private bool B006_025 => state.PT switch
        {
            LR => state.OUTc.B018_020,
            LD => state.POP.B007_027,
            RD => state.POP.B007_027,
            _ => Exit,
        };

        private bool B005_022 => state.PT switch
        {
            LL => state.POP.B004_022,
            _ => Exit,
        };

        private bool B006_006 => state.PT switch
        {
            LR => state.RD.GT_.B006_007,
            LD => state.PSH(3).B008_007,
            LL => state.LR.PSH(1).B026_000,
            _ => Exit,
        };

        private bool B059_000 => state.PT switch
        {
            LR => state.DUP.B060_000,
            LL => state.NOT.B058_000,
            RR => state.DUP.B060_000,
            RL => state.NOT.B058_000,
            _ => Exit,
        };

        private bool B007_027 => state.PT switch
        {
            LD => state.PSH(1).B007_028,
            RD => state.PSH(1).B007_028,
            _ => Exit,
        };

        private bool B004_022 => state.PT switch
        {
            LL => state.PSH(1).B002_007,
            _ => Exit,
        };

        private bool B006_007 => state.PT switch
        {
            RD => state.POP.B006_008,
            _ => Exit,
        };

        private bool B018_020 => state.PT switch
        {
            LR => state.PSH(105).B029_015,
            _ => Exit,
        };

        private bool B060_000 => state.PT switch
        {
            LR => state.PSH(5).B069_000,
            RR => state.PSH(5).B069_000,
            _ => Exit,
        };

        private bool B007_028 => state.PT switch
        {
            LD => state.POP.B007_029,
            RD => state.POP.B007_029,
            _ => Exit,
        };

        private bool B002_007 => state.PT switch
        {
            _ => Exit,
        };

        private bool B029_015 => state.PT switch
        {
            LR => state.OUTc.B030_015,
            _ => Exit,
        };

        private bool B069_000 => state.PT switch
        {
            LR => state.MOD.B072_000,
            RR => state.MOD.B072_000,
            _ => Exit,
        };

        private bool B007_029 => state.PT switch
        {
            LD => state.PSH(1).B007_030,
            RD => state.PSH(1).B007_030,
            _ => Exit,
        };

        private bool B030_015 => state.PT switch
        {
            LR => state.PSH(122).B033_032,
            _ => Exit,
        };

        private bool B072_000 => state.PT switch
        {
            LR => state.NOT.B073_000,
            LL => state.INi.B071_000,
            RR => state.NOT.B073_000,
            RL => state.INi.B071_000,
            _ => Exit,
        };

        private bool B007_030 => state.PT switch
        {
            LD => state.POP.B007_031,
            RD => state.POP.B007_031,
            _ => Exit,
        };

        private bool B033_032 => state.PT switch
        {
            LR => state.OUTc.B051_031,
            _ => Exit,
        };

        private bool B073_000 => state.PT switch
        {
            LR => state.ROT.B074_000,
            LL => state.ROL.B072_000,
            RR => state.ROT.B074_000,
            RL => state.ROL.B072_000,
            _ => Exit,
        };

        private bool B007_031 => state.PT switch
        {
            LD => state.PSH(1).B007_032,
            RD => state.PSH(1).B007_032,
            _ => Exit,
        };

        private bool B051_031 => state.PT switch
        {
            LR => state.PSH(3).B054_031,
            _ => Exit,
        };

        private bool B074_000 => state.PT switch
        {
            LR => state.PSH(1).B077_000,
            LD => state.PSH(3).B076_007,
            LL => state.SWI.B073_000,
            LT => state.RR.PSH(1).B077_000,
            RR => state.PSH(1).B077_000,
            RD => state.GT_.B074_007,
            RL => state.SWI.B073_000,
            RT => state.LR.PSH(1).B077_000,
            _ => Exit,
        };

        private bool B007_032 => state.PT switch
        {
            LD => state.POP.B007_033,
            RD => state.POP.B007_033,
            _ => Exit,
        };

        private bool B054_031 => state.PT switch
        {
            LR => state.ROT.B053_015,
            _ => Exit,
        };

        private bool B077_000 => state.PT switch
        {
            LR => state.MUL.B143_000,
            RR => state.MUL.B143_000,
            _ => Exit,
        };

        private bool B076_007 => state.PT switch
        {
            LD => state.ROT.B076_008,
            _ => Exit,
        };

        private bool B007_033 => state.PT switch
        {
            LD => state.PSH(1).B002_007,
            RD => state.PSH(1).B002_007,
            _ => Exit,
        };

        private bool B053_015 => state.PT switch
        {
            LR => state.PSH(122).B054_015,
            LD => state.PSH(122).B052_033,
            LL => state.RT.PSH(122).B053_014,
            LT => state.PSH(122).B053_014,
            RD => state.PSH(122).B052_033,
            _ => Exit,
        };

        private bool B074_007 => state.PT switch
        {
            LL => state.RT.GT_.B074_006,
            RD => state.RT.GT_.B074_006,
            _ => Exit,
        };

        private bool B143_000 => state.PT switch
        {
            LR => state.MUL.B144_000,
            LL => state.OUTi.B142_000,
            RR => state.MUL.B144_000,
            RL => state.OUTi.B142_000,
            _ => Exit,
        };

        private bool B076_008 => state.PT switch
        {
            LR => state.RR.PSH(66).B094_015,
            LD => state.PSH(66).B092_018,
            LL => state.PSH(66).B074_007,
            LT => state.RR.PSH(66).B094_015,
            _ => Exit,
        };

        private bool B054_015 => state.PT switch
        {
            LR => state.LL.POP.B053_015,
            _ => Exit,
        };

        private bool B052_033 => state.PT switch
        {
            _ => Exit,
        };

        private bool B053_014 => state.PT switch
        {
            LD => state.POP.B053_015,
            LT => state.OUTc.B053_013,
            RD => state.POP.B053_015,
            RT => state.OUTc.B053_013,
            _ => Exit,
        };

        private bool B074_006 => state.PT switch
        {
            _ => Exit,
        };

        private bool B144_000 => state.PT switch
        {
            LR => state.DUP.B151_000,
            RR => state.DUP.B151_000,
            _ => Exit,
        };

        private bool B092_018 => state.PT switch
        {
            LD => state.RL.POP.B091_018,
            RR => state.RL.POP.B091_018,
            _ => Exit,
        };

        private bool B094_015 => state.PT switch
        {
            RR => state.OUTc.B095_015,
            _ => Exit,
        };

        private bool B071_000 => state.PT switch
        {
            LL => state.POP.B064_000,
            RL => state.POP.B064_000,
            _ => Exit,
        };

        private bool B053_013 => state.PT switch
        {
            LT => state.PSH(1).B053_010,
            RT => state.PSH(1).B053_010,
            _ => Exit,
        };

        private bool B151_000 => state.PT switch
        {
            LR => state.NOT.B152_000,
            LL => state.DIV.B150_000,
            RR => state.NOT.B152_000,
            RL => state.DIV.B150_000,
            _ => Exit,
        };

        private bool B091_018 => state.PT switch
        {
            RR => state.PSH(1).B092_018,
            RL => state.PSH(1).B090_018,
            _ => Exit,
        };

        private bool B095_015 => state.PT switch
        {
            RR => state.PSH(117).B119_015,
            _ => Exit,
        };

        private bool B064_000 => state.PT switch
        {
            LL => state.DIV.B059_000,
            RL => state.DIV.B059_000,
            _ => Exit,
        };

        private bool B053_010 => state.PT switch
        {
            LT => state.PSH(1).B053_007,
            RT => state.PSH(1).B053_007,
            _ => Exit,
        };

        private bool B152_000 => state.PT switch
        {
            LR => state.ROT.B164_000,
            RR => state.ROT.B164_000,
            _ => Exit,
        };

        private bool B090_018 => state.PT switch
        {
            RR => state.POP.B091_018,
            RL => state.POP.B089_018,
            _ => Exit,
        };

        private bool B119_015 => state.PT switch
        {
            RR => state.OUTc.B120_015,
            _ => Exit,
        };

        private bool B053_007 => state.PT switch
        {
            LT => state.SUB.B053_004,
            RT => state.SUB.B053_004,
            _ => Exit,
        };

        private bool B164_000 => state.PT switch
        {
            LR => state.OUTi.B165_000,
            LD => state.PSH(10).B163_008,
            LL => state.SWI.B163_000,
            LT => state.RR.OUTi.B165_000,
            RR => state.OUTi.B165_000,
            RD => state.PSH(10).B163_008,
            RL => state.SWI.B163_000,
            RT => state.LR.OUTi.B165_000,
            _ => Exit,
        };

        private bool B089_018 => state.PT switch
        {
            RR => state.PSH(1).B090_018,
            RL => state.PSH(1).B088_018,
            _ => Exit,
        };

        private bool B120_015 => state.PT switch
        {
            RR => state.PSH(122).B122_032,
            _ => Exit,
        };

        private bool B053_004 => state.PT switch
        {
            LT => state.PSH(1).B053_001,
            RT => state.PSH(1).B053_001,
            _ => Exit,
        };

        private bool B165_000 => state.PT switch
        {
            LR => state.PSH(1).B166_000,
            LL => state.MUL.B164_000,
            RR => state.PSH(1).B166_000,
            RL => state.MUL.B164_000,
            _ => Exit,
        };

        private bool B163_008 => state.PT switch
        {
            LD => state.OUTc.B165_026,
            RD => state.OUTc.B165_026,
            _ => Exit,
        };

        private bool B163_000 => state.PT switch
        {
            LL => state.ROL.B151_000,
            RL => state.ROL.B151_000,
            _ => Exit,
        };

        private bool B088_018 => state.PT switch
        {
            RR => state.POP.B089_018,
            RL => state.POP.B087_018,
            _ => Exit,
        };

        private bool B122_032 => state.PT switch
        {
            RR => state.LR.OUTc.B140_031,
            _ => Exit,
        };

        private bool B053_001 => state.PT switch
        {
            LD => state.POP.B053_002,
            LT => state.ROT.B053_000,
            RD => state.POP.B053_002,
            RT => state.ROT.B053_000,
            _ => Exit,
        };

        private bool B166_000 => state.PT switch
        {
            LR => state.ROT.B167_000,
            LL => state.POP.B165_000,
            RR => state.ROT.B167_000,
            RL => state.POP.B165_000,
            _ => Exit,
        };

        private bool B165_026 => state.PT switch
        {
            _ => Exit,
        };

        private bool B087_018 => state.PT switch
        {
            RR => state.PSH(1).B088_018,
            RL => state.PSH(1).B086_018,
            _ => Exit,
        };

        private bool B140_031 => state.PT switch
        {
            LR => state.PSH(3).B143_031,
            _ => Exit,
        };

        private bool B055_000 => state.PT switch
        {
            LL => state.POP.B025_000,
            RL => state.POP.B025_000,
            _ => Exit,
        };

        private bool B053_000 => state.PT switch
        {
            LR => state.PSH(2).B057_000,
            LD => state.SWI.B053_001,
            LL => state.POP.B025_000,
            LT => state.RR.PSH(2).B057_000,
            RR => state.PSH(2).B057_000,
            RD => state.SWI.B053_001,
            RL => state.POP.B025_000,
            RT => state.LR.PSH(2).B057_000,
            _ => Exit,
        };

        private bool B167_000 => state.PT switch
        {
            LR => state.LL.SWI.B166_000,
            LD => state.PSH(10).B163_008,
            LL => state.SWI.B166_000,
            LT => state.RL.SWI.B166_000,
            RR => state.RL.SWI.B166_000,
            RD => state.PSH(10).B163_008,
            RL => state.SWI.B166_000,
            RT => state.LL.SWI.B166_000,
            _ => Exit,
        };

        private bool B150_000 => state.PT switch
        {
            LL => state.OUTi.B143_000,
            RL => state.OUTi.B143_000,
            _ => Exit,
        };

        private bool B086_018 => state.PT switch
        {
            RL => state.RR.POP.B087_018,
            _ => Exit,
        };

        private bool B143_031 => state.PT switch
        {
            LR => state.ROT.B142_015,
            _ => Exit,
        };

        private bool B025_000 => state.PT switch
        {
            LL => state.SWI.B007_000,
            RL => state.SWI.B007_000,
            _ => Exit,
        };

        private bool B142_015 => state.PT switch
        {
            LR => state.PSH(122).B143_015,
            LD => state.PSH(122).B141_033,
            LL => state.RT.PSH(122).B142_014,
            LT => state.PSH(122).B142_014,
            _ => Exit,
        };

        private bool B053_002 => state.PT switch
        {
            LD => state.OUTc.B053_005,
            RD => state.OUTc.B053_005,
            _ => Exit,
        };

        private bool B142_000 => state.PT switch
        {
            LL => state.POP.B076_000,
            RL => state.POP.B076_000,
            _ => Exit,
        };

        private bool B143_015 => state.PT switch
        {
            LR => state.LL.POP.B142_015,
            _ => Exit,
        };

        private bool B141_033 => state.PT switch
        {
            _ => Exit,
        };

        private bool B142_014 => state.PT switch
        {
            LT => state.OUTc.B142_013,
            RT => state.OUTc.B142_013,
            _ => Exit,
        };

        private bool B053_005 => state.PT switch
        {
            LD => state.POP.B053_008,
            RD => state.POP.B053_008,
            _ => Exit,
        };

        private bool B076_000 => state.PT switch
        {
            LL => state.SWI.B073_000,
            RL => state.SWI.B073_000,
            _ => Exit,
        };

        private bool B142_013 => state.PT switch
        {
            LT => state.PSH(1).B142_010,
            RT => state.PSH(1).B142_010,
            _ => Exit,
        };

        private bool B053_008 => state.PT switch
        {
            LD => state.POP.B053_011,
            RD => state.POP.B053_011,
            _ => Exit,
        };

        private bool B142_010 => state.PT switch
        {
            LT => state.PSH(1).B142_007,
            RT => state.PSH(1).B142_007,
            _ => Exit,
        };

        private bool B053_011 => state.PT switch
        {
            LD => state.SUB.B053_014,
            RD => state.SUB.B053_014,
            _ => Exit,
        };

        private bool B142_007 => state.PT switch
        {
            LT => state.SUB.B142_004,
            RT => state.SUB.B142_004,
            _ => Exit,
        };

        private bool B142_004 => state.PT switch
        {
            LT => state.RR.MUL.B143_000,
            RT => state.LR.MUL.B143_000,
            _ => Exit,
        };
    }
}
