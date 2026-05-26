using Piet.Runtime;
using static Piet.Runtime.CC_DP;

namespace Specs.Programs.Compiled;

internal static class Pi
{
    public static bool Execute(State state) => state._000_000;

    extension(State state)
    {
        private bool _000_000 => state.PT switch
        {
            LR => state.RR.PSH(52)._002_052,
            _ => Exit(),
        };

        private bool _002_052 => state.PT switch
        {
            RR => state.RR.DUP._003_052,
            _ => Exit(),
        };

        private bool _003_052 => state.PT switch
        {
            RR => state.RR.MUL._111_058,
            _ => Exit(),
        };

        private bool _111_058 => state.PT switch
        {
            RR => state.RR.PSH(8492)._117_058,
            _ => Exit(),
        };

        private bool _117_058 => state.PT switch
        {
            RR => state.RR.PSH(100)._118_058,
            _ => Exit(),
        };

        private bool _118_058 => state.PT switch
        {
            RR => state.RR.DUP._119_058,
            _ => Exit(),
        };

        private bool _119_058 => state.PT switch
        {
            RR => state.RR.MUL._120_058,
            _ => Exit(),
        };

        private bool _120_058 => state.PT switch
        {
            RR => state.RR.MUL._121_058,
            _ => Exit(),
        };
        private bool _121_058 => state.PT switch
        {
            RR => state.RR.PSH(2)._122_058,
            _ => Exit(),
        };

        private bool _122_058 => state.PT switch
        {
            RR => state.RR.PSH(1)._124_058,
            _ => Exit(),
        };

        private bool _124_058 => state.PT switch
        {
            RR => state.RR.ROL._125_058,
            _ => Exit(),
        };

        private bool _125_058 => state.PT switch
        {
            RR => state.RR.DIV._126_058,
            _ => Exit(),
        };

        private bool _126_058 => state.PT switch
        {
            RR => state.RR.OUTi._127_058,
            _ => Exit(),
        };

        private bool _127_058 => Exit();
    }

    private static bool Exit() => true;
}
