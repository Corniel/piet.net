using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class DayOfWeek
{
    private const bool Exit = true;

    public static bool Execute(State state) => state.B000_000;

    extension(State state)
    {
        private bool B000_000 => state.PT switch
        {
            LR => state.INi.B001_000,
            _ => Exit,
        };

        private bool B001_000 => state.PT switch
        {
            LR => state.PSH(10).B005_000,
            _ => Exit,
        };

        private bool B005_000 => state.PT switch
        {
            LR => state.PSH(10).B009_000,
            _ => Exit,
        };

        private bool B009_000 => state.PT switch
        {
            LR => state.PSH(10).B013_000,
            _ => Exit,
        };

        private bool B013_000 => state.PT switch
        {
            LR => state.PSH(2).B016_000,
            _ => Exit,
        };

        private bool B016_000 => state.PT switch
        {
            LR => state.MUL.B017_000,
            _ => Exit,
        };

        private bool B017_000 => state.PT switch
        {
            LR => state.MUL.B018_000,
            _ => Exit,
        };

        private bool B018_000 => state.PT switch
        {
            LR => state.MUL.B019_000,
            _ => Exit,
        };

        private bool B019_000 => state.PT switch
        {
            LR => state.SUB.B020_000,
            _ => Exit,
        };

        private bool B020_000 => state.PT switch
        {
            LR => state.DUP.B021_000,
            _ => Exit,
        };

        private bool B021_000 => state.PT switch
        {
            LR => state.DUP.B022_000,
            _ => Exit,
        };

        private bool B022_000 => state.PT switch
        {
            LR => state.PSH(3).B025_000,
            _ => Exit,
        };

        private bool B025_000 => state.PT switch
        {
            LR => state.ADD.B026_000,
            _ => Exit,
        };

        private bool B026_000 => state.PT switch
        {
            LR => state.PSH(4).B029_000,
            _ => Exit,
        };

        private bool B029_000 => state.PT switch
        {
            LR => state.DIV.B030_000,
            _ => Exit,
        };

        private bool B030_000 => state.PT switch
        {
            LR => state.RD.PSH(2).B030_004,
            _ => Exit,
        };

        private bool B030_004 => state.PT switch
        {
            RD => state.PSH(1).B030_007,
            _ => Exit,
        };

        private bool B030_007 => state.PT switch
        {
            RD => state.ROL.B030_008,
            _ => Exit,
        };

        private bool B030_008 => state.PT switch
        {
            RD => state.LD.PSH(4).B030_011,
            _ => Exit,
        };

        private bool B030_011 => state.PT switch
        {
            LD => state.MOD.B030_012,
            _ => Exit,
        };

        private bool B030_012 => state.PT switch
        {
            LD => state.NOT.B030_013,
            _ => Exit,
        };

        private bool B030_013 => state.PT switch
        {
            LD => state.INi.B030_016,
            _ => Exit,
        };

        private bool B030_016 => state.PT switch
        {
            LD => state.DUP.B030_017,
            _ => Exit,
        };

        private bool B030_017 => state.PT switch
        {
            LD => state.PSH(2).B030_020,
            _ => Exit,
        };

        private bool B030_020 => state.PT switch
        {
            LD => state.GT_.B030_021,
            _ => Exit,
        };

        private bool B030_021 => state.PT switch
        {
            LD => state.PSH(2).B030_024,
            _ => Exit,
        };

        private bool B030_024 => state.PT switch
        {
            LD => state.PSH(1).B030_027,
            _ => Exit,
        };

        private bool B030_027 => state.PT switch
        {
            LD => state.ROL.B030_028,
            _ => Exit,
        };

        private bool B030_028 => state.PT switch
        {
            LD => state.DUP.B030_029,
            _ => Exit,
        };

        private bool B030_029 => state.PT switch
        {
            LD => state.LL.PSH(6).B025_030,
            _ => Exit,
        };

        private bool B025_030 => state.PT switch
        {
            LL => state.GT_.B024_029,
            RR => state.POP.B026_030,
            _ => Exit,
        };

        private bool B024_029 => state.PT switch
        {
            LR => state.RR.GT_.B025_030,
            LL => state.ROT.B023_029,
            RR => state.GT_.B025_030,
            _ => Exit,
        };

        private bool B023_029 => state.PT switch
        {
            LR => state.SWI.B024_029,
            LD => state.RL.PSH(7).B018_030,
            LL => state.PSH(7).B018_030,
            LT => state.RL.PSH(6).B021_025,
            _ => Exit,
        };

        private bool B018_030 => state.PT switch
        {
            LL => state.PSH(9).B013_029,
            RL => state.PSH(9).B013_029,
            _ => Exit,
        };

        private bool B021_025 => state.PT switch
        {
            RL => state.SUB.B020_025,
            _ => Exit,
        };

        private bool B013_029 => state.PT switch
        {
            LL => state.MUL.B012_029,
            RL => state.MUL.B012_029,
            _ => Exit,
        };

        private bool B020_025 => state.PT switch
        {
            RL => state.PSH(8).B015_025,
            _ => Exit,
        };

        private bool B012_029 => state.PT switch
        {
            LL => state.PSH(9).B007_029,
            RL => state.PSH(9).B007_029,
            _ => Exit,
        };

        private bool B015_025 => state.PT switch
        {
            RL => state.PSH(9).B010_025,
            _ => Exit,
        };

        private bool B026_030 => state.PT switch
        {
            RR => state.LL.PSH(6).B025_030,
            _ => Exit,
        };

        private bool B007_029 => state.PT switch
        {
            LL => state.MUL.B006_029,
            RL => state.MUL.B006_029,
            _ => Exit,
        };

        private bool B010_025 => state.PT switch
        {
            RL => state.MUL.B009_025,
            _ => Exit,
        };

        private bool B006_029 => state.PT switch
        {
            LL => state.PSH(4).B002_030,
            RL => state.PSH(4).B002_030,
            _ => Exit,
        };

        private bool B009_025 => state.PT switch
        {
            RL => state.LT.PSH(8).B005_024,
            _ => Exit,
        };

        private bool B002_030 => state.PT switch
        {
            LL => state.ADD.B001_030,
            RL => state.ADD.B001_030,
            _ => Exit,
        };

        private bool B005_024 => state.PT switch
        {
            LT => state.ADD.B005_023,
            _ => Exit,
        };

        private bool B001_030 => state.PT switch
        {
            LL => state.RT.PSH(9).B001_024,
            RL => state.LT.PSH(9).B001_024,
            _ => Exit,
        };

        private bool B005_023 => state.PT switch
        {
            LT => state.PSH(9).B005_018,
            _ => Exit,
        };

        private bool B001_024 => state.PT switch
        {
            LT => state.MUL.B001_023,
            RT => state.MUL.B001_023,
            _ => Exit,
        };

        private bool B005_018 => state.PT switch
        {
            LT => state.MUL.B005_017,
            _ => Exit,
        };

        private bool B001_023 => state.PT switch
        {
            LT => state.PSH(9).B001_018,
            RT => state.PSH(9).B001_018,
            _ => Exit,
        };

        private bool B005_017 => state.PT switch
        {
            LT => state.PSH(7).B005_012,
            _ => Exit,
        };

        private bool B001_018 => state.PT switch
        {
            LT => state.MUL.B001_017,
            RT => state.MUL.B001_017,
            _ => Exit,
        };

        private bool B005_012 => state.PT switch
        {
            LT => state.ADD.B005_011,
            _ => Exit,
        };

        private bool B001_017 => state.PT switch
        {
            LT => state.PSH(7).B002_012,
            RT => state.PSH(7).B002_012,
            _ => Exit,
        };

        private bool B005_011 => state.PT switch
        {
            LT => state.RR.PSH(9).B010_010,
            _ => Exit,
        };

        private bool B002_012 => state.PT switch
        {
            LT => state.ADD.B002_011,
            RT => state.ADD.B002_011,
            _ => Exit,
        };

        private bool B010_010 => state.PT switch
        {
            RR => state.MUL.B011_010,
            _ => Exit,
        };

        private bool B002_011 => state.PT switch
        {
            LT => state.PSH(9).B001_006,
            RT => state.PSH(9).B001_006,
            _ => Exit,
        };

        private bool B011_010 => state.PT switch
        {
            RR => state.LD.PSH(6).B009_016,
            _ => Exit,
        };

        private bool B001_006 => state.PT switch
        {
            LT => state.RR.MUL.B004_006,
            RL => state.RR.MUL.B004_006,
            RT => state.LR.MUL.B004_006,
            _ => Exit,
        };

        private bool B009_016 => state.PT switch
        {
            LD => state.ADD.B009_017,
            _ => Exit,
        };

        private bool B004_006 => state.PT switch
        {
            LR => state.PSH(8).B009_006,
            RR => state.PSH(8).B009_006,
            _ => Exit,
        };

        private bool B009_017 => state.PT switch
        {
            LD => state.PSH(9).B011_022,
            _ => Exit,
        };

        private bool B009_006 => state.PT switch
        {
            LR => state.ADD.B010_006,
            RR => state.ADD.B010_006,
            RL => state.POP.B006_006,
            _ => Exit,
        };

        private bool B011_022 => state.PT switch
        {
            LD => state.MUL.B010_023,
            _ => Exit,
        };

        private bool B010_006 => state.PT switch
        {
            LR => state.PSH(2).B014_006,
            RR => state.PSH(2).B014_006,
            _ => Exit,
        };

        private bool B010_023 => state.PT switch
        {
            LD => state.LT.PSH(6).B013_020,
            _ => Exit,
        };

        private bool B014_006 => state.PT switch
        {
            LR => state.PSH(1).B017_006,
            RR => state.RL.POP.B013_006,
            _ => Exit,
        };

        private bool B013_020 => state.PT switch
        {
            LT => state.ADD.B013_019,
            _ => Exit,
        };

        private bool B017_006 => state.PT switch
        {
            LR => state.ROL.B018_006,
            _ => Exit,
        };

        private bool B013_019 => state.PT switch
        {
            LT => state.PSH(9).B013_014,
            _ => Exit,
        };

        private bool B013_006 => state.PT switch
        {
            RL => state.INc.B009_006,
            _ => Exit,
        };

        private bool B018_006 => state.PT switch
        {
            LR => state.RD.DUP.B018_007,
            LT => state.LD.DUP.B018_007,
            _ => Exit,
        };

        private bool B013_014 => state.PT switch
        {
            LT => state.MUL.B013_013,
            _ => Exit,
        };

        private bool B018_007 => state.PT switch
        {
            LD => state.PSH(1).B020_010,
            RD => state.LD.PSH(1).B020_010,
            _ => Exit,
        };

        private bool B013_013 => state.PT switch
        {
            LT => state.PSH(3).B013_010,
            _ => Exit,
        };

        private bool B006_006 => state.PT switch
        {
            RL => state.OUTi.B001_006,
            _ => Exit,
        };

        private bool B020_010 => state.PT switch
        {
            LD => state.GT_.B020_011,
            LT => state.POP.B020_009,
            RT => state.POP.B020_009,
            _ => Exit,
        };

        private bool B013_010 => state.PT switch
        {
            LT => state.ADD.B013_009,
            _ => Exit,
        };

        private bool B020_011 => state.PT switch
        {
            LD => state.NOT.B020_012,
            LT => state.GT_.B020_010,
            RT => state.GT_.B020_010,
            _ => Exit,
        };

        private bool B013_009 => state.PT switch
        {
            LT => state.RR.PSH(2).B014_006,
            _ => Exit,
        };

        private bool B020_012 => state.PT switch
        {
            LD => state.ROT.B020_013,
            LT => state.ROL.B020_011,
            RT => state.ROL.B020_011,
            _ => Exit,
        };

        private bool B020_013 => state.PT switch
        {
            LR => state.RD.PSH(1).B020_016,
            LD => state.PSH(1).B020_016,
            LL => state.POP.B019_013,
            LT => state.SWI.B020_012,
            _ => Exit,
        };

        private bool B020_016 => state.PT switch
        {
            LD => state.SUB.B020_017,
            RD => state.SUB.B020_017,
            _ => Exit,
        };

        private bool B019_013 => state.PT switch
        {
            LL => state.RD.PSH(10).B017_016,
            _ => Exit,
        };

        private bool B020_017 => state.PT switch
        {
            LD => state.PSH(2).B020_021,
            RD => state.LD.PSH(2).B020_021,
            _ => Exit,
        };

        private bool B017_016 => state.PT switch
        {
            RD => state.MOD.B017_017,
            _ => Exit,
        };

        private bool B020_021 => state.PT switch
        {
            LD => state.RT.PSH(1).B023_018,
            _ => Exit,
        };

        private bool B017_017 => state.PT switch
        {
            RD => state.LD.PSH(3).B018_020,
            _ => Exit,
        };

        private bool B023_018 => state.PT switch
        {
            RT => state.LR.ROL.B025_017,
            _ => Exit,
        };

        private bool B018_020 => state.PT switch
        {
            LD => state.PSH(1).B017_023,
            _ => Exit,
        };

        private bool B020_009 => state.PT switch
        {
            LT => state.DIV.B018_006,
            RT => state.DIV.B020_004,
            _ => Exit,
        };

        private bool B025_017 => state.PT switch
        {
            LR => state.LT.PSH(10).B022_013,
            _ => Exit,
        };

        private bool B017_023 => state.PT switch
        {
            LD => state.RR.ROL.B020_023,
            _ => Exit,
        };

        private bool B020_004 => state.PT switch
        {
            RT => state.RD.DUP.B018_007,
            _ => Exit,
        };

        private bool B022_013 => state.PT switch
        {
            LT => state.RT.DIV.B023_012,
            _ => Exit,
        };

        private bool B020_023 => state.PT switch
        {
            RR => state.MUL.B021_023,
            _ => Exit,
        };

        private bool B023_012 => state.PT switch
        {
            RT => state.PSH(2).B024_009,
            _ => Exit,
        };

        private bool B021_023 => state.PT switch
        {
            RR => state.ADD.B022_023,
            _ => Exit,
        };

        private bool B024_009 => state.PT switch
        {
            RT => state.PSH(1).B023_004,
            _ => Exit,
        };

        private bool B022_023 => state.PT switch
        {
            RR => state.ADD.B023_023,
            _ => Exit,
        };

        private bool B023_004 => state.PT switch
        {
            RT => state.LL.ROL.B022_005,
            _ => Exit,
        };

        private bool B023_023 => state.PT switch
        {
            RR => state.ADD.B024_023,
            _ => Exit,
        };

        private bool B022_005 => state.PT switch
        {
            LL => state.LD.DUP.B018_007,
            _ => Exit,
        };

        private bool B024_023 => state.PT switch
        {
            RR => state.LT.PSH(5).B025_021,
            _ => Exit,
        };

        private bool B025_021 => state.PT switch
        {
            LT => state.RT.ADD.B027_020,
            _ => Exit,
        };

        private bool B027_020 => state.PT switch
        {
            RT => state.INi.B027_019,
            _ => Exit,
        };

        private bool B027_019 => state.PT switch
        {
            RT => state.ADD.B027_018,
            _ => Exit,
        };

        private bool B027_018 => state.PT switch
        {
            RT => state.PSH(7).B027_013,
            _ => Exit,
        };

        private bool B027_013 => state.PT switch
        {
            RT => state.LT.MOD.B027_012,
            _ => Exit,
        };

        private bool B027_012 => state.PT switch
        {
            LT => state.OUTi.B027_011,
            _ => Exit,
        };

        private bool B027_011 => state.PT switch
        {
            _ => Exit,
        };
    }
}
