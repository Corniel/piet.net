using PietDotNet.Drawing;
using System.Drawing;

namespace Colour_specs;

public class General
{
    [Test]
    public void _20_unique_colours_exist()
    {
        Colour.All.Should().HaveCount(20);
        Colour.All.Select(c => c.RgbCode).ToHashSet().Should().HaveCount(20);
    }
}

public class Subtract
{
    [Test]
    public void With_Black_is_invalid_operation()
        => Colour.Black.Invoking(b => b - Colour.Green)
        .Should().Throw<InvalidOperationException>();

    [Test]
    public void With_White_is_invalid_operation()
        => Colour.Red.Invoking(r => r - Colour.White)
        .Should().Throw<InvalidOperationException>();

    [Test]
    public void Red_and_RedDark_is_Pop()
        => (Colour.Red - Colour.RedDark).Should().Be(Command.Pop);

    [Test]
    public void Red_and_GreenLight_is_Roll()
        => (Colour.Red - Colour.GreenLight).Should().Be(Command.Roll);
}

public class Display
{
    [Test]
    public void ToString_shows_RGB_code_and_name()
        => Colour.YellowLight.ToString()
        .Should().Be("#FFFFC0 light yellow");
}

public class Relation_to_System_Drawing_Color
{
    [Test]
    public void Creation_from_not_matching_colour_returns_null()
        => Bitmapping.Colour(Color.Brown).Should().BeNull();

    [Test]
    public void Creation_from_matching_color_returns_codel_with_matching_colour()
    {
        var colour = Color.FromArgb(255, 255, 255);
        Bitmapping.Colour(colour).Should().Be(Colour.White);
    }
}
