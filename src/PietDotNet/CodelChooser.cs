namespace PietDotNet;

public enum CodelChooser
{
    left = 0,
    right = 1,
}

public static class ClodelChooserExtensions
{
    public static CodelChooser Switch(this CodelChooser cc, long times)
        => ((long)cc + times).IsEven
        ? CodelChooser.left
        : CodelChooser.right;
}
