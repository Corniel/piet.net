using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class PowerFunction
{
    private const bool Exit = true;

    public static bool Execute(State state) => state.B000_000;

    extension(State state)
    {
        private bool B000_000 => state.PT switch
        {
            LR => state.INi.B003_001,
            LL => state.LR.INi.B003_001,
            RL => state.LR.INi.B003_001,
            _ => Exit,
        };

        private bool B003_001 => state.PT switch
        {
            LR => state.INi.B004_001,
            LL => state.MOD.B000_000,
            RL => state.MOD.B000_000,
            _ => Exit,
        };

        private bool B004_001 => state.PT switch
        {
            LR => state.DUP.B005_001,
            LL => state.MOD.B003_001,
            RL => state.MOD.B003_001,
            _ => Exit,
        };

        private bool B005_001 => state.PT switch
        {
            LR => state.PSH(1).B006_001,
            LL => state.DIV.B004_001,
            RL => state.DIV.B004_001,
            _ => Exit,
        };

        private bool B006_001 => state.PT switch
        {
            LR => state.PSH(1).B007_001,
            LL => state.POP.B005_001,
            RR => state.PSH(1).B007_001,
            RL => state.POP.B005_001,
            _ => Exit,
        };

        private bool B007_001 => state.PT switch
        {
            LR => state.SUB.B008_001,
            LL => state.POP.B006_001,
            RR => state.SUB.B008_001,
            RL => state.POP.B006_001,
            _ => Exit,
        };

        private bool B008_001 => state.PT switch
        {
            LR => state.GT_.B009_001,
            LL => state.OUTc.B007_001,
            RR => state.GT_.B009_001,
            RL => state.OUTc.B007_001,
            _ => Exit,
        };

        private bool B009_001 => state.PT switch
        {
            LR => state.NOT.B010_001,
            LL => state.GT_.B008_001,
            RR => state.NOT.B010_001,
            RL => state.GT_.B008_001,
            _ => Exit,
        };

        private bool B010_001 => state.PT switch
        {
            LR => state.ROT.B011_001,
            LL => state.ROL.B009_001,
            RR => state.ROT.B011_001,
            RL => state.ROL.B009_001,
            _ => Exit,
        };

        private bool B011_001 => state.PT switch
        {
            LR => state.PSH(2).B013_001,
            LD => state.POP.B012_002,
            LL => state.SWI.B010_001,
            LT => state.RR.PSH(2).B013_001,
            RR => state.PSH(2).B013_001,
            RD => state.LR.GT_.B009_001,
            RL => state.SWI.B010_001,
            RT => state.LR.PSH(2).B013_001,
            _ => Exit,
        };

        private bool B013_001 => state.PT switch
        {
            LR => state.PSH(1).B014_001,
            RR => state.PSH(1).B014_001,
            RL => state.POP.B011_001,
            _ => Exit,
        };

        private bool B012_002 => state.PT switch
        {
            LD => state.POP.B012_003,
            _ => Exit,
        };

        private bool B014_001 => state.PT switch
        {
            LR => state.ROL.B015_001,
            RR => state.ROL.B015_001,
            RL => state.POP.B013_001,
            _ => Exit,
        };

        private bool B012_003 => state.PT switch
        {
            LD => state.PSH(1).B012_004,
            _ => Exit,
        };

        private bool B015_001 => state.PT switch
        {
            LR => state.DUP.B016_001,
            RR => state.DUP.B016_001,
            RL => state.NOT.B014_001,
            _ => Exit,
        };

        private bool B012_004 => state.PT switch
        {
            LD => state.OUTi.B005_007,
            _ => Exit,
        };

        private bool B016_001 => state.PT switch
        {
            LR => state.PSH(3).B017_001,
            LL => state.LR.PSH(1).B006_001,
            RR => state.PSH(1).B006_001,
            RL => state.DIV.B015_001,
            _ => Exit,
        };

        private bool B005_007 => state.PT switch
        {
            _ => Exit,
        };

        private bool B017_001 => state.PT switch
        {
            LR => state.PSH(2).B018_001,
            LL => state.POP.B016_001,
            RL => state.POP.B016_001,
            _ => Exit,
        };

        private bool B018_001 => state.PT switch
        {
            LR => state.ROL.B019_001,
            LL => state.POP.B017_001,
            RL => state.POP.B017_001,
            _ => Exit,
        };

        private bool B019_001 => state.PT switch
        {
            LR => state.DUP.B022_001,
            _ => Exit,
        };

        private bool B022_001 => state.PT switch
        {
            LR => state.PSH(1).B023_001,
            LL => state.DIV.B021_001,
            RR => state.PSH(1).B023_001,
            RL => state.DIV.B021_001,
            _ => Exit,
        };

        private bool B023_001 => state.PT switch
        {
            LR => state.GT_.B024_001,
            LL => state.POP.B022_001,
            RR => state.GT_.B024_001,
            RL => state.POP.B022_001,
            _ => Exit,
        };

        private bool B024_001 => state.PT switch
        {
            LR => state.ROT.B025_001,
            LL => state.GT_.B023_001,
            RR => state.ROT.B025_001,
            RL => state.GT_.B023_001,
            _ => Exit,
        };

        private bool B025_001 => state.PT switch
        {
            LR => state.PSH(3).B028_001,
            LD => state.PSH(1).B025_002,
            LL => state.SWI.B024_001,
            LT => state.LR.PSH(3).B028_001,
            RR => state.LR.PSH(3).B028_001,
            RD => state.PSH(1).B025_002,
            RL => state.SWI.B024_001,
            RT => state.LR.PSH(3).B028_001,
            _ => Exit,
        };

        private bool B028_001 => state.PT switch
        {
            LR => state.PSH(2).B029_001,
            _ => Exit,
        };

        private bool B025_002 => state.PT switch
        {
            LD => state.SUB.B025_003,
            RD => state.SUB.B025_003,
            _ => Exit,
        };

        private bool B029_001 => state.PT switch
        {
            LR => state.ROL.B030_001,
            _ => Exit,
        };

        private bool B025_003 => state.PT switch
        {
            LD => state.PSH(3).B025_006,
            RD => state.PSH(3).B025_006,
            _ => Exit,
        };

        private bool B030_001 => state.PT switch
        {
            LR => state.RD.POP.B030_002,
            _ => Exit,
        };

        private bool B025_006 => state.PT switch
        {
            LD => state.PSH(2).B025_008,
            RD => state.PSH(2).B025_008,
            _ => Exit,
        };

        private bool B030_002 => state.PT switch
        {
            RD => state.POP.B029_004,
            _ => Exit,
        };

        private bool B025_008 => state.PT switch
        {
            LD => state.ROL.B025_009,
            RD => state.ROL.B025_009,
            _ => Exit,
        };

        private bool B021_001 => state.PT switch
        {
            LL => state.NOT.B018_001,
            RL => state.NOT.B018_001,
            _ => Exit,
        };

        private bool B029_004 => state.PT switch
        {
            RD => state.OUTi.B029_008,
            _ => Exit,
        };

        private bool B025_009 => state.PT switch
        {
            LD => state.RL.DUP.B024_009,
            RD => state.LL.DUP.B024_009,
            _ => Exit,
        };

        private bool B029_008 => state.PT switch
        {
            _ => Exit,
        };

        private bool B024_009 => state.PT switch
        {
            LL => state.RL.PSH(4).B023_009,
            RL => state.PSH(4).B023_009,
            _ => Exit,
        };

        private bool B023_009 => state.PT switch
        {
            RL => state.PSH(3).B022_009,
            _ => Exit,
        };

        private bool B022_009 => state.PT switch
        {
            RL => state.LT.ROL.B022_008,
            _ => Exit,
        };

        private bool B022_008 => state.PT switch
        {
            LT => state.MUL.B022_006,
            _ => Exit,
        };

        private bool B022_006 => state.PT switch
        {
            LT => state.PSH(3).B022_005,
            _ => Exit,
        };

        private bool B022_005 => state.PT switch
        {
            LT => state.PSH(2).B022_004,
            _ => Exit,
        };

        private bool B022_004 => state.PT switch
        {
            LT => state.ROL.B021_003,
            _ => Exit,
        };

        private bool B021_003 => state.PT switch
        {
            LT => state.RR.DUP.B022_001,
            _ => Exit,
        };
    }
}
