using PietDotNet.Drawing;
using System.Drawing;

namespace Colour_specs;

public class General
{
    [Test]
    public void _20_unique_colours_exist()
    {
        Assert.AreEqual(20, Colour.All.Count);
        Assert.AreEqual(20, new HashSet<int>(Colour.All.Select(codel => codel.RgbCode)).Count, "All colours should be different too.");
    }
}

public class Subtract
{
    [Test]
    public void With_Black_is_invalid_operation()
    {
        Assert.Throws<InvalidOperationException>(() => { var delta = Colour.Black - Colour.Green; });
    }

    [Test]
    public void With_White_is_invalid_operation()
    {
        Assert.Throws<InvalidOperationException>(() => { var delta = Colour.Red - Colour.White; });
    }

    [Test]
    public void Red_and_RedDark_is_Pop()
    {
        Assert.AreEqual(Command.Pop, Colour.Red - Colour.RedDark);
    }

    [Test]
    public void Red_and_GreenLight_is_Roll()
    {
        Assert.AreEqual(Command.Roll, Colour.Red - Colour.GreenLight);
    }
}

public class Display
{
    [Test]
    public void ToString_shows_RGB_code_and_name()
    {
        var str = Colour.YellowLight.ToString();
        Assert.AreEqual("#FFFFC0 light yellow", str);
    }
}

public class Relation_to_System_Drawing_Color
{
    [Test]
    public void Creation_from_not_matching_colour_returns_null()
    {
        var colour = Color.Brown;
        var codel = Bitmapping.Colour(colour);

        Assert.Null(codel);
    }

    [Test]
    public void Creation_from_matching_color_returns_codel_with_matching_colour()
    {
        var colour = Color.FromArgb(255, 255, 255);
        var codel = Bitmapping.Colour(colour);

        Assert.AreEqual(Colour.White, codel);
    }
}
