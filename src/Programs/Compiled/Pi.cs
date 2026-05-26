using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Piet.Programs.Compiled;

public static class Pi
{
    private const bool Exit = true;

    public static bool Execute(State state) => state.B000_000;

    extension(State state)
    {
        private bool B000_000 => state.PT switch
        {
            LR => state.RR.PSH(52).B001_051,
            _ => Exit,
        };

        private bool B001_051 => state.PT switch
        {
            RR => state.DUP.B002_051,
            _ => Exit,
        };

        private bool B002_051 => state.PT switch
        {
            RR => state.MUL.B003_051,
            _ => Exit,
        };

        private bool B003_051 => state.PT switch
        {
            RR => state.PSH(8492).B111_058,
            _ => Exit,
        };

        private bool B111_058 => state.PT switch
        {
            RR => state.PSH(10).B117_058,
            _ => Exit,
        };

        private bool B117_058 => state.PT switch
        {
            RR => state.DUP.B118_058,
            _ => Exit,
        };

        private bool B118_058 => state.PT switch
        {
            RR => state.MUL.B119_058,
            _ => Exit,
        };

        private bool B119_058 => state.PT switch
        {
            RR => state.DUP.B120_058,
            _ => Exit,
        };

        private bool B120_058 => state.PT switch
        {
            RR => state.MUL.B121_058,
            _ => Exit,
        };

        private bool B121_058 => state.PT switch
        {
            RR => state.MUL.B122_058,
            _ => Exit,
        };

        private bool B122_058 => state.PT switch
        {
            RR => state.PSH(2).B124_058,
            _ => Exit,
        };

        private bool B124_058 => state.PT switch
        {
            RR => state.PSH(1).B125_058,
            _ => Exit,
        };

        private bool B125_058 => state.PT switch
        {
            RR => state.ROL.B126_058,
            _ => Exit,
        };

        private bool B126_058 => state.PT switch
        {
            RR => state.DIV.B127_058,
            _ => Exit,
        };

        private bool B127_058 => state.PT switch
        {
            RR => state.OUTi.B128_058,
            _ => Exit,
        };

        private bool B128_058 => state.PT switch
        {
            RR => state.PSH(10).B135_058,
            _ => Exit,
        };

        private bool B135_058 => state.PT switch
        {
            RR => state.OUTc.B136_057,
            _ => Exit,
        };

        private bool B136_057 => state.PT switch
        {
            _ => Exit,
        };
    }
}
