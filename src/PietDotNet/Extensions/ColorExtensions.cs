namespace System.Drawing
{
    public static class ColorExtensions
    {
        /// <summary>Represents the color as a 3 char RGB code.</summary>
        public static string Debug(this Color color)
        {
            return $"#{(color.R >> 4):X}{(color.G >> 4):X}{(color.B >> 4):X}";
        }
    }
}
