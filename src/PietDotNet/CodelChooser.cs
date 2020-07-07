using System;

namespace PietDotNet
{
    public enum CodelChooser
    {
        left = 0,
        right = 1,
    }

    public static class ClodelChooserExtensions
    {
        public static CodelChooser Switch(this CodelChooser cc, long @switch)
        {
            var value = (long)cc + Math.Abs(@switch);
            value &= 1;
            return value == 0 ? CodelChooser.left : CodelChooser.right;
        }
    }
}
