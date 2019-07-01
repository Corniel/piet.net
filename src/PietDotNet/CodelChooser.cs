namespace PietDotNet
{
    public enum CodelChooser
    {
        left = 0,
        right = 1,
    }

    public static class ClodelChooserExtensions
    {
        public static CodelChooser Toggle(this CodelChooser cc) => cc.Switch(1);
        public static CodelChooser Switch(this CodelChooser cc, long @switch)
        {
            var value = (long)cc + @switch;
            value &= 1;
            return value == 0 ? CodelChooser.left : CodelChooser.right;
        }
    }

}
