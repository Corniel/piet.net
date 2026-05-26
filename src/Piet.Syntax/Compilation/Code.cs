namespace Piet.Syntax.Compilation;

public interface Code
{
    void WriteTo(CSharpWriter writer);
}
