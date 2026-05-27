namespace Piet.Syntax.Compilation;

public sealed class ExitExpression(CC_DP key) : Expression(key, null, Command.None, 0, Block.Black)
{
    public override void WriteTo(CSharpWriter writer)
        => writer.Write("return;");
}
