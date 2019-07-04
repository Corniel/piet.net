using System.Diagnostics;

namespace PietDotNet
{
    [DebuggerDisplay("Border")]
    internal class Border : ColourBlock
    {
        public override bool IsBlack => true;
        public override bool IsWhite => false;
        public override Codel Codel => Codel.Black;
    }
}
