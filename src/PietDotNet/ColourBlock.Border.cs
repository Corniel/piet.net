using System.Diagnostics;

namespace PietDotNet
{
    [DebuggerDisplay("Border")]
    internal class Border : ColourBlock
    {
        public override Colour Colour => Colour.Black;
    }
}
